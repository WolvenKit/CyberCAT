using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.NodeRepresentations;
using CyberCAT.Core.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.Parsers
{
    public class StatsSystemParser : GenericUnknownStructParser, INodeParser
    {
        public string ParsableNodeName { get; private set; }
        public string DisplayName { get; private set; }
        public Guid Guid { get; private set; }
        public StatsSystemParser()
        {
            ParsableNodeName = Constants.NodeNames.STATS_SYSTEM;
            DisplayName = "Stat System Parser";
            Guid = Guid.Parse("{8F3788DA-3ECD-47FC-A6F9-A50314F61AA7}");
        }

        public new object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            var dict = MappingHelper.GetMappings("CyberCAT.Core.Classes.Mapping.StatsSystem");
            var result = base.ReadWithMapping(node, reader, parsers, dict);
            var test = new NodeRepresentationWrappers.StatsSystemWrapper((GenericUnknownStruct)result);
            return result;
        }

        /*private int IndexOf(GenericUnknownStruct.ClassEntry[] classList, object obj)
        {
            for (int i = 0; i < classList.Length; i++)
            {
                if (classList[i] == obj)
                    return i;
            }

            return -1;
        }

        public new object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            //var dict = MappingHelper.GetMappings("CyberCAT.Core.Classes.Mapping.StatsSystem");
            //var result = base.ReadWithMapping(node, reader, parsers, dict);

            var result = (GenericUnknownStruct)base.Read(node, reader, parsers);

            foreach (var classEntry in result.ClassList)
            {
                ReplaceFieldsHandles(classEntry.Fields, result);
            }
            //File.WriteAllText("dump.json", JsonConvert.SerializeObject(result, Formatting.Indented));
            var entries = GenerateMappingStructure(result);
            var statsSystem = new StatsSystem(result);
            statsSystem.Entries = entries;
            return statsSystem;
            
        }

        public new byte[] Write(NodeEntry node, List<INodeParser> parsers)
        {
            var unknownStruct = ((StatsSystem)node.Value).GetUnknownStruct();
            foreach (var classEntry in unknownStruct.ClassList)
            {
                ReplaceFieldsReferences(classEntry.Fields, unknownStruct);
            }
            byte[] result;
            var data = unknownStruct;
            using (var stream = new MemoryStream())
            {
                using (var writer = new BinaryWriter(stream, Encoding.ASCII))
                {
                    writer.Write(new byte[4]);
                    writer.Write(data.Unknown1);
                    writer.Write(data.Unknown2);
                    writer.Write(data.Unknown3);
                    writer.Write(new byte[12]);

                    if (data.Unknown2 > 1)
                    {
                        writer.Write(data.CNameHashes1.Length);
                        foreach (var hash in data.CNameHashes1)
                        {
                            writer.Write(hash);
                        }
                    }

                    var pos = writer.BaseStream.Position;

                    var stringList = GenerateStringList(data);

                    var offset = stringList.Count * 4;
                    foreach (var str in stringList)
                    {
                        writer.WriteInt24(offset);
                        writer.Write((byte)(str.Length + 1));
                        offset += (short)(str.Length + 1);
                    }

                    var stringListOffset = writer.BaseStream.Position - pos;

                    foreach (var str in stringList)
                    {
                        var bytes = Encoding.ASCII.GetBytes(str);
                        writer.Write(bytes);
                        writer.Write(new byte[1]);
                    }

                    var dataIndexListOffset = writer.BaseStream.Position - pos;

                    var bufferList = new byte[data.ClassList.Length][];
                    Parallel.For(0, data.ClassList.Length, (index, state) =>
                    {
                        bufferList[index] = GenerateDataFromFields(data.ClassList[index].Fields, stringList);
                    });

                    var dataListOffset = writer.BaseStream.Position - pos + (data.ClassList.Length * 8);
                    int classOffset = (int)dataListOffset;
                    for (int i = 0; i < data.ClassList.Length; i++)
                    {
                        var strId = stringList.IndexOf(data.ClassList[i].Name);
                        writer.Write(strId);
                        writer.Write(classOffset);
                        classOffset += bufferList[i].Length;
                    }

                    Debug.Assert(writer.BaseStream.Position == dataListOffset + pos);

                    foreach (var buffer in bufferList)
                    {
                        writer.Write(buffer);
                    }

                    writer.BaseStream.Position = 0;
                    writer.Write((int)writer.BaseStream.Length - 4);
                    writer.BaseStream.Position += 12;
                    writer.Write((int)stringListOffset);
                    writer.Write((int)dataIndexListOffset);
                    writer.Write((int)dataListOffset);
                }

                result = stream.ToArray();
            }

            using (var stream = new MemoryStream())
            {
                using (var writer = new BinaryWriter(stream, Encoding.ASCII))
                {
                    writer.Write(node.Id);
                    writer.Write(result);
                    if (data.CNameHashes2 != null && data.CNameHashes2.Length > 0)
                    {
                        writer.Write(data.CNameHashes2.Length);
                        foreach (var hash in data.CNameHashes2)
                        {
                            writer.Write(hash);
                        }
                    }
                }
                result = stream.ToArray();
                node.Size = result.Length;
                node.TrueSize = result.Length;
            }

            if (DEBUG_WRITING)
            {
                var buffer = new byte[result.Length - 4];
                Array.Copy(result, 4, buffer, 0, buffer.Length);
                File.WriteAllBytes($"C:\\Dev\\T1\\{node.Name}_new.bin", buffer);
            }

            GC.Collect();
            return result;
        }

        private void ReplaceFieldsHandles(GenericUnknownStruct.BaseGenericField[] field, GenericUnknownStruct root)
        {
            for (int i = 0; i < field.Length; i++)
            {
                if (field[i].Type.StartsWith("handle:"))
                {
                    if (((dynamic)field[i]).Value is GenericUnknownStruct.ClassEntry)
                    {
                        continue;
                    }

                    var newField = new GenericUnknownStruct.GenericField<GenericUnknownStruct.ClassEntry>(root.ClassList[((dynamic)field[i]).Value]);
                    newField.Name = field[i].Name;
                    newField.Type = field[i].Type;
                    field[i] = newField;
                    //root.ClassList = root.ClassList.ToList().RemoveAt(root.ClassList[((dynamic)field[i]).Value]);
                }
                else if (field[i].Type.StartsWith("array:handle:"))
                {
                    if (((dynamic)field[i]).Value is GenericUnknownStruct.ClassEntry[])
                    {
                        continue;
                    }

                    var classes = new GenericUnknownStruct.ClassEntry[((dynamic)field[i]).Value.Length];
                    for (int j = 0; j < classes.Length; j++)
                    {
                        classes[j] = root.ClassList[((dynamic)field[i]).Value[j]];
                        var tmp = root.ClassList.ToList();
                    }

                    var newField = new GenericUnknownStruct.GenericField<GenericUnknownStruct.ClassEntry[]>(classes);
                    newField.Name = field[i].Name;
                    newField.Type = field[i].Type;
                    field[i] = newField;
                }
                else
                {
                    if (((dynamic)field[i]).Value is object[] subList)
                    {
                        ParseList(subList, root);
                    }
                }
            }
        }

        private void ParseList(object[] list, GenericUnknownStruct root)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] is object[] subList1)
                {
                    ParseList(subList1, root);
                }
                else if (list[i] is GenericUnknownStruct.BaseGenericField subField)
                {
                    ReplaceFieldsHandles((GenericUnknownStruct.BaseGenericField[])list, root);
                }
            }
        }

        private void ReplaceFieldsReferences(GenericUnknownStruct.BaseGenericField[] field, GenericUnknownStruct root)
        {
            for (int i = 0; i < field.Length; i++)
            {
                if (field[i].Type.StartsWith("handle:"))
                {
                    if (((dynamic)field[i]).Value is UInt32)
                    {
                        continue;
                    }

                    var handle = IndexOf(root.ClassList, ((dynamic)field[i]).Value);
                    if (handle == -1)
                    {
                        throw new Exception();
                    }
                    var newField = new GenericUnknownStruct.GenericField<UInt32>(handle);
                    newField.Name = field[i].Name;
                    newField.Type = field[i].Type;
                    field[i] = newField;
                }
                else if (field[i].Type.StartsWith("array:handle:"))
                {
                    if (((dynamic)field[i]).Value is UInt32[])
                    {
                        continue;
                    }

                    var classes = new uint[((dynamic)field[i]).Value.Length];
                    for (int j = 0; j < classes.Length; j++)
                    {
                        var handle = IndexOf(root.ClassList, ((dynamic)field[i]).Value[j]);
                        if (handle == -1)
                        {
                            throw new Exception();
                        }
                        classes[j] = (uint)handle;
                    }

                    var newField = new GenericUnknownStruct.GenericField<UInt32[]>(classes);
                    newField.Name = field[i].Name;
                    newField.Type = field[i].Type;
                    field[i] = newField;
                }
                else
                {
                    if (((dynamic)field[i]).Value is object[] subList)
                    {
                        ReplaceList(subList, root);
                    }
                }
            }
        }

        private void ReplaceList(object[] list, GenericUnknownStruct root)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] is object[] subList1)
                {
                    ReplaceList(subList1, root);
                }
                else if (list[i] is GenericUnknownStruct.BaseGenericField subField)
                {
                    ReplaceFieldsReferences((GenericUnknownStruct.BaseGenericField[])list, root);
                }
            }
        }
        private Dictionary<GameStatsObjectID, GameSavedStatsData> GenerateMappingStructure(GenericUnknownStruct source)
        {
            var mappingStructureKeys = source.ClassList[0].Fields[0];
            var mappingStructureValues = source.ClassList[0].Fields[1];
            int index = 0;
            var dictionary = new Dictionary<GameStatsObjectID, GameSavedStatsData>();
            foreach (var mappingStructureKey in ((GenericUnknownStruct.GenericField<GenericUnknownStruct.BaseGenericField[][]>)mappingStructureKeys).Value)
            {
                var key = new GameStatsObjectID(mappingStructureKey);
                var value = new GameSavedStatsData(((GenericUnknownStruct.GenericField<GenericUnknownStruct.BaseGenericField[][]>)mappingStructureValues).Value[index]);
                dictionary[key] = value;
                index++;
            }
            return dictionary;
        }
        [JsonObject]
        public class GameConstantStatModifierData
        {
            [JsonConverter(typeof(StringEnumConverter))]
            public DumpedEnums.gamedataStatType StatType
            {
                get =>(DumpedEnums.gamedataStatType)Enum.Parse(typeof(DumpedEnums.gamedataStatType), ((GenericUnknownStruct.GenericField<string>)_original.FirstOrDefault(o=>o.Name== "statType")).Value);
                set => ((GenericUnknownStruct.GenericField<string>)_original.FirstOrDefault(o => o.Name == "statType")).Value=value.ToString();
            }
            [JsonConverter(typeof(StringEnumConverter))]
            public DumpedEnums.gameStatModifierType ModifierType
            {
                get => (DumpedEnums.gameStatModifierType)Enum.Parse(typeof(DumpedEnums.gameStatModifierType), ((GenericUnknownStruct.GenericField<string>)_original.FirstOrDefault(o => o.Name == "modifierType")).Value);
                set => ((GenericUnknownStruct.GenericField<string>)_original.FirstOrDefault(o => o.Name == "modifierType")).Value = value.ToString();
            }
            public float Value
            {
                get =>((dynamic)_original.FirstOrDefault(o => o.Name == "value")).Value;
                set => ((dynamic)_original.FirstOrDefault(o => o.Name == "value")).Value = value;
            }
            GenericUnknownStruct.BaseGenericField[] _original;

            public GameConstantStatModifierData(GenericUnknownStruct.BaseGenericField[] source)
            {
                _original = source;
            }
        }
        [JsonObject]
        public class GameCurveStatModifierData
        {
            [JsonConverter(typeof(StringEnumConverter))]
            public DumpedEnums.gamedataStatType StatType
            {
                get => (DumpedEnums.gamedataStatType)Enum.Parse(typeof(DumpedEnums.gamedataStatType), ((GenericUnknownStruct.GenericField<string>)_original.FirstOrDefault(o => o.Name == "statType")).Value);
                set => ((GenericUnknownStruct.GenericField<string>)_original.FirstOrDefault(o => o.Name == "statType")).Value = value.ToString();
            }
            [JsonConverter(typeof(StringEnumConverter))]
            public DumpedEnums.gameStatModifierType ModifierType
            {
                get => (DumpedEnums.gameStatModifierType) Enum.Parse(typeof(DumpedEnums.gameStatModifierType), ((GenericUnknownStruct.GenericField<string>) _original.FirstOrDefault(o => o.Name == "modifierType")).Value);
                set => ((GenericUnknownStruct.GenericField<string>) _original.FirstOrDefault(o => o.Name == "modifierType")).Value = value.ToString();
            }
            public string CurveName
            {
                get => ((GenericUnknownStruct.GenericField<string>)_original.FirstOrDefault(o => o.Name == "curveName")).Value;
                set => ((GenericUnknownStruct.GenericField<string>)_original.FirstOrDefault(o => o.Name == "curveName")).Value = value;
            }
            public string ColumnName
            {
                get => ((GenericUnknownStruct.GenericField<string>)_original.FirstOrDefault(o => o.Name == "columnName")).Value;
                set => ((GenericUnknownStruct.GenericField<string>)_original.FirstOrDefault(o => o.Name == "columnName")).Value = value;
            }
            [JsonConverter(typeof(StringEnumConverter))]
            public DumpedEnums.gamedataStatType CurveStat
            {
                get => (DumpedEnums.gamedataStatType)Enum.Parse(typeof(DumpedEnums.gamedataStatType), ((GenericUnknownStruct.GenericField<string>)_original.FirstOrDefault(o => o.Name == "curveStat")).Value);
                set => ((GenericUnknownStruct.GenericField<string>)_original.FirstOrDefault(o => o.Name == "curveStat")).Value = value.ToString();
            }

            GenericUnknownStruct.BaseGenericField[] _original;

            public GameCurveStatModifierData(GenericUnknownStruct.BaseGenericField[] source)
            {
                _original = source;
            }
        }
        [JsonObject]
        public class GameSavedStatsData
        {
            public ulong? RecordID
            {
                get => ((GenericUnknownStruct.GenericField<ulong>)_original.FirstOrDefault(o => o.Name == "recordID"))?.Value;
                set => ((GenericUnknownStruct.GenericField<ulong>)_original.FirstOrDefault(o => o.Name == "recordID")).Value = value.GetValueOrDefault();
            }
            public uint? Seed
            {
                get => ((GenericUnknownStruct.GenericField<uint>)_original.FirstOrDefault(o => o.Name == "seed"))?.Value;
                set => ((GenericUnknownStruct.GenericField<uint>)_original.FirstOrDefault(o => o.Name == "seed")).Value = value.GetValueOrDefault();
            }
            public List<GameCurveStatModifierData> CurveModifiers { get; set; }
            public List<GameConstantStatModifierData> ConstantModifiers { get; set; }
            GenericUnknownStruct.BaseGenericField[] _original;
            public GameSavedStatsData(GenericUnknownStruct.BaseGenericField[] source)
            {
                CurveModifiers = new List<GameCurveStatModifierData>();
                ConstantModifiers = new List<GameConstantStatModifierData>();
                _original = source;

                var modifiers = _original.Where(o => o.Name == "statModifiers");
                foreach(var modifier in modifiers)
                {
                    var modifierValues = ((GenericUnknownStruct.GenericField<GenericUnknownStruct.ClassEntry[]>)modifier).Value;
                    var constantModifiers = modifierValues.Where(m => m.Name == "gameConstantStatModifierData");
                    var curveModifiers = modifierValues.Where(m => m.Name == "gameCurveStatModifierData");
                    foreach(var constantModifier in constantModifiers)
                    {
                        var parsedConstantModifier = new GameConstantStatModifierData(constantModifier.Fields);
                        ConstantModifiers.Add(parsedConstantModifier);
                    }
                    foreach(var curveModifier in curveModifiers)
                    {
                        var parsedCurveData = new GameCurveStatModifierData(curveModifier.Fields);
                        CurveModifiers.Add(parsedCurveData);
                    }
                }
            }
            public override string ToString()
            {
                return NameResolver.GetName(RecordID.GetValueOrDefault());
            }
        }
        [JsonObject]
        public class GameStatsObjectID
        {
            public ulong? EntityHash { 
                get => ((GenericUnknownStruct.GenericField<ulong>)_original.FirstOrDefault(o => o.Name == "entityHash"))?.Value; 
                set => ((GenericUnknownStruct.GenericField<ulong>)_original.FirstOrDefault(o => o.Name == "entityHash")).Value = value.GetValueOrDefault();
            }
            private GenericUnknownStruct.BaseGenericField[] _original;
            public GameStatsObjectID(GenericUnknownStruct.BaseGenericField[] source)
            {
                _original = source;
            }
            public override string ToString()
            {
                return EntityHash.ToString();
            }
        }*/
    }
}
