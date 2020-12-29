using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.ExceptionServices;
using System.Text;
using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Parsers
{
    public class GenericUnknownStructParser : INodeParser
    {
        public string ParsableNodeName { get; private set; }

        public string DisplayName { get; private set; }

        public Guid Guid { get; private set; }

        public GenericUnknownStructParser()
        {
            ParsableNodeName = Constants.NodeNames.SCRIPTABLE_SYSTEMS_CONTAINER;
            DisplayName = "Generic Unknown Struct Parser";
            Guid = System.Guid.Parse("{CA17650B-E151-4246-A5F4-7834342E3CD1}");
        }

        private string ReadStringAtOffset(BinaryReader reader, long baseAddress, uint offset, int length)
        {
            var origPos = reader.BaseStream.Position;
            reader.BaseStream.Position = baseAddress + offset;
            var bytes = reader.ReadBytes(length);
            reader.BaseStream.Position = origPos;

            return Encoding.ASCII.GetString(bytes);
        }

        public object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            var result = new GenericUnknownStruct();

            reader.Skip(4); //skip Id

            result.TotalLength = reader.ReadUInt32();
            result.Unknown1 = reader.ReadBytes(4);
            result.Unknown2 = reader.ReadUInt32();
            result.Unknown3 = reader.ReadBytes(4);

            var stringTableOffset = reader.ReadUInt32();
            var indexTableOffset = reader.ReadUInt32();
            var dataTableOffset = reader.ReadUInt32();

            if (result.Unknown2 == 16)
            {
                // only for ScriptableSystemsContainer
                var count1 = reader.ReadInt32();
                result.Unknown4 = reader.ReadBytes(count1 * 8);
            }

            var stringTablePosition = reader.BaseStream.Position + stringTableOffset;
            var indexTablePosition = reader.BaseStream.Position + indexTableOffset;
            var dataTablePosition = reader.BaseStream.Position + dataTableOffset;

            // start of stringIndexTable
            var stringList = new List<string>();
            var stringBasePosition = reader.BaseStream.Position;
            var stringOffset = reader.ReadUInt16();
            var count2 = stringOffset / 4 - 1; // there could be another count somewhere...
            reader.Skip(1);
            var stringLength = reader.ReadByte(); // string is null terminated?


            // length - 1 because null terminated...
            // could probably ignore the stringIndexTable and read null terminated strings, then you also don't net the hacky jump after this
            result.StringList.Add(ReadStringAtOffset(reader, stringBasePosition, stringOffset, stringLength - 1));

            // there could be another count somewhere...
            for (int i = 0; i < count2; i++)
            {
                stringOffset = reader.ReadUInt16();
                reader.Skip(1);
                stringLength = reader.ReadByte();
                result.StringList.Add(ReadStringAtOffset(reader, stringBasePosition, stringOffset, stringLength - 1));
            }

            // jump straight behind the last string
            reader.BaseStream.Position = stringBasePosition + stringOffset + stringLength;

            Debug.Assert(reader.BaseStream.Position == indexTablePosition);

            var count3 = (dataTableOffset - indexTableOffset) / 8;

            for (int i = 0; i < count3; i++)
            {
                // probably counter, offset
                result.PointerList.Add(new KeyValuePair<uint, uint>(reader.ReadUInt32(), reader.ReadUInt32()));
            }

            Debug.Assert(reader.BaseStream.Position == dataTablePosition);

            /*int readSize = node.Size - ((int)reader.BaseStream.Position - node.Offset);
            Debug.Assert(readSize >= 0);
            result.TrailingBytes = reader.ReadBytes(readSize);*/

            var debugList1 = new List<KeyValuePair<string, uint>>();
            foreach (var pair in result.PointerList)
            {
                debugList1.Add(new KeyValuePair<string, uint>(result.StringList[(int)pair.Key], pair.Value));
            }

            var debugList2 = new List<byte[]>();
            var debugList3 = new List<ClassEntry>();
            var pos = reader.BaseStream.Position;
            for (int i = 0; i < debugList1.Count; i++)
            {
                var offset = debugList1[i].Value - debugList1[0].Value;

                var r = new ClassEntry();
                r.Name = debugList1[i].Key;

                int length = 0;
                if (i == debugList1.Count - 1)
                {
                    length = (int)(result.TotalLength - debugList1[i].Value);
                }
                else
                {
                    length = (int) (debugList1[i + 1].Value - debugList1[i].Value);
                }
                
                if (length < 6)
                {
                    debugList3.Add(r);
                    continue;
                }


                reader.BaseStream.Position = pos + offset;
                var bytes = reader.ReadBytes(6);
                r.Debug = BitConverter.ToString(bytes).Replace("-", " ");

                reader.BaseStream.Position = pos + offset;

                try
                {
                    r.Fields = ReadFields(reader, result.StringList);
                }
                catch (Exception e)
                {
                    throw;
                }

                debugList3.Add(r);
            }

            return result;
        }

        public List<FieldEntry> ReadFields(BinaryReader reader, List<string> stringList)
        {
            var fieldList = new List<FieldEntry>();

            var pos = reader.BaseStream.Position;
            var fieldCount = reader.ReadUInt16();
            for (int i = 0; i < fieldCount; i++)
            {
                var field = new FieldEntry();

                var pos2 = reader.BaseStream.Position;
                var bytes = reader.ReadBytes(6);
                field.Debug = BitConverter.ToString(bytes).Replace("-", " ");
                reader.BaseStream.Position = pos2;

                var s = reader.ReadUInt16();
                field.Name = stringList[s];
                s = reader.ReadUInt16();
                field.Type = stringList[s];
                field.Offset = reader.ReadUInt32();

                fieldList.Add(field);
            }

            foreach (var field in fieldList)
            {
                reader.BaseStream.Position = pos + field.Offset;
                var typeParts = field.Type.Split(':');
                field.Value = ReadValue(reader, stringList, typeParts, 0);
            }

            return fieldList;
        }

        public object ReadValue(BinaryReader reader, List<string> stringList, string[] typeParts, int index)
        {
            if (index == typeParts.Length)
            {

            }

            switch (typeParts[index])
            {
                case "array":
                    object result = new List<object>();
                    var arraySize = reader.ReadUInt32();
                    for (int i = 0; i < arraySize; i++)
                    {
                        ((List<object>)result).Add(ReadValue(reader, stringList, typeParts, index + 1));
                    }
                    return result;

                case "Int32":
                    return reader.ReadInt32();

                case "Uint32":
                case "handle":
                    return reader.ReadUInt32();

                case "Bool":
                    return reader.ReadByte() != 0;

                case "Uint64":
                case "TweakDBID":
                    return reader.ReadUInt64();

                case "SBraindanceInputMask":
                case "gameItemID":
                case "FastTravelSystemLock":
                case "SSubCharacter":
                case "gamePersistentID":
                case "entEntityID":
                case "gameSLoadout":
                case "gameSLastUsedWeapon":
                case "gameSEquipSlot":
                case "gameSSlotInfo":
                case "SProficiency":
                case "SAttribute":
                case "SDevelopmentPoints":
                case "SPerk":
                case "ItemRecipe":
                    return ReadFields(reader, stringList);

                // need to check
                case "gamedataEquipmentArea":
                case "gamedataLifePath":
                case "gameSEquipArea":
                case "gamedataProficiencyType":
                case "gamedataStatType":
                case "gamedataTraitType":
                case "gamedataDevelopmentPointType":
                case "gamedataItemType":
                case "gameEHotkey":
                case "gamedataPerkType":
                case "STrait":
                case "gamedataPerkArea":
                case "SPerkArea":
                    return null;

                case "CName":
                case "gamedataSubCharacter":
                    // what the hell is CName
                    return reader.ReadBytes(2);

                default:
                    return null;
            }
        }

        public class ClassEntry
        {
            public string Name { get; set; }
            public string Debug { get; set; }
            public string Section { get; set; }
            public List<FieldEntry> Fields { get; set; }

            public ClassEntry()
            {
                Fields = new List<FieldEntry>();
            }

            public override string ToString()
            {
                return Name;
            }
        }

        public class FieldEntry
        {
            public string Name { get; set; }
            public string Debug { get; set; }
            public string Type { get; set; }
            public uint Offset { get; set; }
            public object Value { get; set; }
        }

        public byte[] Write(NodeEntry node, List<INodeParser> parsers)
        {
            byte[] result;
            var data = (GenericUnknownStruct)node.Value;
            using (var stream = new MemoryStream())
            {
                using (var writer = new BinaryWriter(stream, Encoding.ASCII))
                {
                    writer.Write(node.Id);
                    writer.Write(new byte[] { 0, 0, 0, 0 });
                    writer.Write(data.Unknown1);
                    writer.Write(data.Unknown2);
                    writer.Write(data.Unknown3);
                    writer.Write(new byte[12]);

                    if (data.Unknown2 == 16)
                    {
                        var count = data.Unknown4.Length / 8;
                        writer.Write(count);
                        writer.Write(data.Unknown4);
                    }

                    var pos = writer.BaseStream.Position;

                    var offset = (short)(data.StringList.Count * 4);
                    foreach (var str in data.StringList)
                    {
                        writer.Write(offset);
                        writer.Write(new byte[] { 0 });
                        writer.Write((byte)(str.Length + 1));
                        offset += (short)(str.Length + 1);
                    }

                    var stringTableOffset = writer.BaseStream.Position - pos;

                    foreach (var str in data.StringList)
                    {
                        var bytes = Encoding.ASCII.GetBytes(str);
                        writer.Write(bytes);
                        writer.Write(new byte[] { 0 });
                    }

                    var indexTableOffset = writer.BaseStream.Position - pos;

                    foreach (var pair in data.PointerList)
                    {
                        writer.Write(pair.Key);
                        writer.Write(pair.Value);
                    }

                    var dataTableOffset = writer.BaseStream.Position - pos;

                    writer.Write(data.TrailingBytes);

                    writer.BaseStream.Position = 4;
                    writer.Write((int)writer.BaseStream.Length - 8);
                    writer.BaseStream.Position += 12;
                    writer.Write((int)stringTableOffset);
                    writer.Write((int)indexTableOffset);
                    writer.Write((int)dataTableOffset);
                }
                result = stream.ToArray();
            }
            return result;
        }
    }
}