using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.Mapping.StatsSystem;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Parsers
{
    public class GenericUnknownStructParser
    {
        public const bool DEBUG_WRITING = false;

        private static readonly Dictionary<string, Type> _dumpedEnums = new Dictionary<string, Type>();
        private List<string> _stringList;

        private bool _doMapping;
        private Dictionary<string, Type> _typeDictionary;

        private void init()
        {
            if (_dumpedEnums.Count == 0)
            {
                var types = AppDomain.CurrentDomain.GetAssemblies()
                    .SelectMany(s => s.GetTypes())
                    .Where(p => p.Namespace == "CyberCAT.Core.DumpedEnums" && p.IsEnum);

                foreach (var type in types)
                {
                    _dumpedEnums.Add(type.Name, type);
                }
            }
        }

        public object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            _doMapping = false;

            init();

            return internalRead(node, reader, parsers);
        }

        public object ReadWithMapping(NodeEntry node, BinaryReader reader, List<INodeParser> parsers, Dictionary<string, Type> typeDictionary)
        {
            _doMapping = true;
            _typeDictionary = typeDictionary;

            init();

            return internalRead(node, reader, parsers);
        }

        private object internalRead(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            var result = new GenericUnknownStruct();

            reader.Skip(4); //skip Id

            int readSize = node.Size - ((int)reader.BaseStream.Position - node.Offset);
            var dataBuffer = reader.ReadBytes(readSize);

            if (DEBUG_WRITING)
            {
                File.WriteAllBytes($"C:\\Dev\\T1\\{node.Name}.bin", dataBuffer);
            }

            using (var ms = new MemoryStream(dataBuffer))
            {
                using (var br = new BinaryReader(ms))
                {
                    result.TotalLength = br.ReadUInt32();
                    result.Unknown1 = br.ReadBytes(4);
                    result.Unknown2 = br.ReadUInt32();
                    result.Unknown3 = br.ReadBytes(4);

                    var stringListOffset = br.ReadUInt32();
                    var dataIndexListOffset = br.ReadUInt32();
                    var dataListOffset = br.ReadUInt32();

                    if (result.Unknown2 > 1)
                    {
                        var count1 = br.ReadInt32();

                        result.CNameHashes1 = new ulong[count1];
                        for (int i = 0; i < count1; i++)
                        {
                            result.CNameHashes1[i] = br.ReadUInt64();
                        }
                    }

                    var stringIndexListPosition = br.BaseStream.Position;
                    var stringListPosition = stringIndexListPosition + stringListOffset;
                    var dataIndexListPosition = stringIndexListPosition + dataIndexListOffset;
                    var dataListPosition = stringIndexListPosition + dataListOffset;

                    // start of stringIndexList
                    var stringInfoList = new List<KeyValuePair<uint, byte>>();
                    for (int i = 0; i < (stringListPosition - stringIndexListPosition) / 4; i++)
                    {
                        stringInfoList.Add(new KeyValuePair<uint, byte>(br.ReadUInt24(), br.ReadByte()));
                    }

                    // start of stringList
                    Debug.Assert(br.BaseStream.Position == stringListPosition);

                    _stringList = new List<string>();
                    foreach (var pair in stringInfoList)
                    {
                        Debug.Assert(br.BaseStream.Position == stringIndexListPosition + pair.Key);
                        _stringList.Add(br.ReadString(pair.Value - 1));
                        br.Skip(1); // null terminator
                    }

                    // start of dataIndexList
                    Debug.Assert(br.BaseStream.Position == dataIndexListPosition);

                    var pointerList = new List<KeyValuePair<uint, uint>>();
                    for (int i = 0; i < (dataListPosition - dataIndexListPosition) / 8; i++)
                    {
                        pointerList.Add(new KeyValuePair<uint, uint>(br.ReadUInt32(), br.ReadUInt32()));
                    }

                    // start of dataList
                    Debug.Assert(br.BaseStream.Position == dataListPosition);

                    var bufferDict = new Dictionary<int, byte[]>();
                    result.ClassList = new GenericUnknownStruct.BaseClassEntry[pointerList.Count];
                    for (int i = 0; i < result.ClassList.Length; i++)
                    {
                        Debug.Assert(br.BaseStream.Position == stringIndexListPosition + pointerList[i].Value);

                        long length;
                        if (i < result.ClassList.Length - 1)
                        {
                            length = pointerList[i+1].Value - pointerList[i].Value;
                        }
                        else
                        {
                            length = result.TotalLength - br.BaseStream.Position + 4;
                        }

                        GenericUnknownStruct.BaseClassEntry classEntry;
                        if (_doMapping)
                        {
                            classEntry = GetInstanceFromName(_stringList[(int) pointerList[i].Key]);
                        }
                        else
                        {
                            classEntry = new GenericUnknownStruct.ClassEntry();
                            ((GenericUnknownStruct.ClassEntry)classEntry).Name = _stringList[(int)pointerList[i].Key];

                        }

                        bufferDict.Add(i, br.ReadBytes((int)length));

                        result.ClassList[i] = classEntry;
                    }

                    Parallel.ForEach(bufferDict, (pair) =>
                    {
                        using (var ms2 = new MemoryStream(pair.Value))
                        {
                            using (var br2 = new BinaryReader(ms2))
                            {
                                if (_doMapping)
                                    ReadMappedFields(br2, result.ClassList[pair.Key]);
                                else
                                    ((GenericUnknownStruct.ClassEntry)result.ClassList[pair.Key]).Fields = ReadUnmappedFields(br2);
                            }
                        }
                    });

                    // end of mainData
                    Debug.Assert((br.BaseStream.Position - 4) == result.TotalLength);

                    readSize = (int) (br.BaseStream.Length - br.BaseStream.Position);
                    if (readSize > 0)
                    {
                        var count1 = br.ReadInt32();

                        result.CNameHashes2 = new ulong[count1];
                        for (int i = 0; i < count1; i++)
                        {
                            result.CNameHashes2[i] = br.ReadUInt64();
                        }
                    }
                }
            }

            readSize = node.Size - ((int)reader.BaseStream.Position - node.Offset);
            Debug.Assert(readSize == 0);

            return result;
        }

        private class FieldInfo
        {
            public string Name { get; set; }
            public string Type { get; set; }
            public uint Offset { get; set; }
        }

        private Type GetTypeFromName(string name)
        {
            if (_typeDictionary.ContainsKey(name))
            {
                return _typeDictionary[name];
            }

            return null;
        }

        private GenericUnknownStruct.BaseClassEntry GetInstanceFromName(string name)
        {
            if (_typeDictionary.ContainsKey(name))
            {
                var classType = _typeDictionary[name];
                return (GenericUnknownStruct.BaseClassEntry)Activator.CreateInstance(classType);
            }

            throw new Exception();
        }

        private void SetProperty(GenericUnknownStruct.BaseClassEntry cls, string fieldName, object value)
        {
            foreach (var prop in cls.GetType().GetProperties())
            {
                var attr = ((RealNameAttribute[])prop.GetCustomAttributes(typeof(RealNameAttribute), true)).FirstOrDefault(a => a.Name == fieldName);
                if (attr != null)
                {
                    if (prop.PropertyType.IsEnum)
                    {
                        value = (int)Enum.Parse(prop.PropertyType, (string)value);
                    }

                    prop.SetValue(cls, value);
                }
            }
        }

        private FieldInfo[] ReadFieldInfos(BinaryReader reader)
        {
            var fieldArray = new FieldInfo[reader.ReadUInt16()];
            for (int i = 0; i < fieldArray.Length; i++)
            {
                fieldArray[i] = new FieldInfo
                {
                    Name = _stringList[reader.ReadUInt16()],
                    Type = _stringList[reader.ReadUInt16()],
                    Offset = reader.ReadUInt32()
                };
            }

            return fieldArray;
        }

        private object ReadMappedFields(BinaryReader reader, GenericUnknownStruct.BaseClassEntry cls)
        {
            var startPos = reader.BaseStream.Position;

            var fieldInfos = ReadFieldInfos(reader);
            for (int i = 0; i < fieldInfos.Length; i++)
            {
                reader.BaseStream.Position = startPos + fieldInfos[i].Offset;

                var fieldTypeName = fieldInfos[i].Type;
                if (fieldTypeName.StartsWith("array:"))
                    fieldTypeName = fieldTypeName.Substring("array:".Length);

                var ret = ReadMappedFieldValue(reader, cls, fieldInfos[i].Name, fieldInfos[i].Type);
                SetProperty(cls, fieldInfos[i].Name, ret);
            }

            return null;
        }

        public GenericUnknownStruct.BaseGenericField[] ReadUnmappedFields(BinaryReader reader)
        {
            var startPos = reader.BaseStream.Position;

            var fieldInfos = ReadFieldInfos(reader);
            var fieldArray = new GenericUnknownStruct.BaseGenericField[fieldInfos.Length];
            for (int i = 0; i < fieldInfos.Length; i++)
            {
                reader.BaseStream.Position = startPos + fieldInfos[i].Offset;

                var val = ReadUnappedFieldValue(reader, fieldInfos[i].Name, fieldInfos[i].Type);

                var type = typeof(GenericUnknownStruct.GenericField<>).MakeGenericType(val.GetType());
                dynamic field = Activator.CreateInstance(type, val);
                field.Name = fieldInfos[i].Name;
                field.Type = fieldInfos[i].Type;

                fieldArray[i] = field;
            }

            return fieldArray;
        }

        public static List<string> KnownFieldTypes = new List<string>();
        public static List<string> KnownEnumTypes = new List<string>();

        private object ReadMappedFieldValue(BinaryReader reader, GenericUnknownStruct.BaseClassEntry cls, string fieldName, string fieldTypeName)
        {
            if (fieldTypeName.StartsWith("array:") || fieldTypeName.StartsWith("static:") || fieldTypeName.StartsWith("["))
            {
                if (fieldTypeName.StartsWith("array:"))
                    fieldTypeName = fieldTypeName.Substring("array:".Length);
                else if (fieldTypeName.StartsWith("static:"))
                    fieldTypeName = fieldTypeName.Substring(fieldTypeName.IndexOf(',') + 1);
                else
                    fieldTypeName = fieldTypeName.Substring(fieldTypeName.IndexOf(']') + 1);

                var arraySize = reader.ReadUInt32();

                Type fieldType;
                if (fieldTypeName.StartsWith("handle:"))
                    fieldType = typeof(uint);
                else
                    fieldType = GetTypeFromName(fieldTypeName);

                if (fieldType == null && _dumpedEnums.ContainsKey(fieldTypeName))
                    fieldType = _dumpedEnums[fieldTypeName];

                var arr = (IList)Array.CreateInstance(fieldType, arraySize);

                for (int i = 0; i < arraySize; i++)
                {
                    var val = ReadMappedFieldValue(reader, cls, fieldName, fieldTypeName);
                    if (fieldType.IsEnum)
                    {
                        arr[i] = Enum.Parse(fieldType, (string) val);
                    }
                    else if (fieldType == typeof(Handle))
                    {
                        arr[i] = new Handle()
                        {
                            Pointer = (uint) val
                        };
                    }
                    else
                    {
                        arr[i] = val;
                    }
                }

                return arr;
            }

            if (fieldTypeName.StartsWith("script_ref:"))
            {
                throw new Exception();
            }

            if (fieldTypeName.StartsWith("handle:"))
            {
                return reader.ReadUInt32();
            }

            switch (fieldTypeName)
            {
                case "Bool":
                    return reader.ReadByte() != 0;

                case "Int32":
                    return reader.ReadInt32();

                case "Uint32":
                    return reader.ReadUInt32();

                case "Int64":
                    return reader.ReadInt64();

                case "Uint64":
                case "TweakDBID":
                    return reader.ReadUInt64();

                case "Float":
                    return reader.ReadSingle();

                case "NodeRef":
                    var size = reader.ReadUInt16();
                    var buffer = reader.ReadBytes(size);
                    return Encoding.ASCII.GetString(buffer);

                case "CName":
                    return _stringList[reader.ReadUInt16()];

                // Not needed, but why not
                case "vehicleVehicleDoorInteractionState":
                case "gameEHotkey":
                case "gameStatIDType":
                case "gameStatPoolDataValueChangeMode":
                case "gameStatPoolDataStatPoolModificationStatus":
                case "gameuiHackingMinigameState":
                case "vehicleVehicleDoorState":
                case "vehicleEVehicleWindowState":
                case "vehicleCameraPerspective":
                    var val = _stringList[reader.ReadUInt16()];
                    return val;

                // TODO: special cases
                case "KEEP_FOR_DEBUG":
                    var cPos = reader.BaseStream.Position;
                    var buffer2 = reader.ReadBytes(256);
                    var debugStr = BitConverter.ToString(buffer2).Replace("-", " ");
                    reader.BaseStream.Position = cPos;
                    return new byte[2];
            }

            if (_dumpedEnums.ContainsKey(fieldTypeName) || KnownEnumTypes.Contains(fieldTypeName))
            {
                var strIdx = reader.ReadUInt16();
                return _stringList[strIdx];
            }
                

            if (KnownFieldTypes.Contains(fieldTypeName))
            {
                var subCls = GetInstanceFromName(fieldTypeName);
                ReadMappedFields(reader, subCls);
                return subCls;
            }

            // TODO:
            var pos2 = reader.BaseStream.Position;
            try
            {
                var subCls = GetInstanceFromName(fieldTypeName);
                ReadMappedFields(reader, subCls);
                if (!KnownFieldTypes.Contains(fieldTypeName))
                {
                    KnownFieldTypes.Add(fieldTypeName);
                }
                return subCls;
            }
            catch (Exception e)
            {
                reader.BaseStream.Position = pos2;

                var stringValue = _stringList[reader.ReadUInt16()];
                if (!KnownEnumTypes.Contains(fieldTypeName))
                {
                    KnownEnumTypes.Add(fieldTypeName);
                }
                return stringValue;
            }
        }

        private object ReadUnappedFieldValue(BinaryReader reader, string fieldName, string fieldType)
        {
            if (fieldType.StartsWith("array:") || fieldType.StartsWith("static:") || fieldType.StartsWith("["))
            {
                if (fieldType.StartsWith("array:"))
                    fieldType = fieldType.Substring("array:".Length);
                else if (fieldType.StartsWith("static:"))
                    fieldType = fieldType.Substring(fieldType.IndexOf(',') + 1);
                else
                    fieldType = fieldType.Substring(fieldType.IndexOf(']') + 1);

                var arraySize = reader.ReadUInt32();
                object result = null;
                for (int i = 0; i < arraySize; i++)
                {
                    var val = ReadUnappedFieldValue(reader, fieldName, fieldType);

                    if (i == 0)
                        result = Array.CreateInstance(val.GetType(), arraySize);
                    ((Array)result).SetValue(val, i);
                }

                return result;
            }

            if (fieldType.StartsWith("script_ref:"))
            {
                throw new Exception();
            }

            if (fieldType.StartsWith("handle:"))
            {
                return reader.ReadUInt32();
            }

            switch (fieldType)
            {
                case "Bool":
                    return reader.ReadByte() != 0;

                case "Int32":
                    return reader.ReadInt32();

                case "Uint32":
                    return reader.ReadUInt32();

                case "Int64":
                    return reader.ReadInt64();

                case "Uint64":
                case "TweakDBID":
                    return reader.ReadUInt64();

                case "Float":
                    return reader.ReadSingle();

                case "NodeRef":
                    var size = reader.ReadUInt16();
                    var buffer = reader.ReadBytes(size);
                    return Encoding.ASCII.GetString(buffer);

                case "CName":
                    return _stringList[reader.ReadUInt16()];

                // Not needed, but why not
                case "vehicleVehicleDoorInteractionState":
                case "gameEHotkey":
                case "gameStatIDType":
                case "gameStatPoolDataValueChangeMode":
                case "gameStatPoolDataStatPoolModificationStatus":
                case "gameuiHackingMinigameState":
                case "vehicleVehicleDoorState":
                case "vehicleEVehicleWindowState":
                case "vehicleCameraPerspective":
                    var val = _stringList[reader.ReadUInt16()];
                    return val;

                // TODO: special cases
                case "KEEP_FOR_DEBUG":
                    var cPos = reader.BaseStream.Position;
                    var buffer2 = reader.ReadBytes(256);
                    var debugStr = BitConverter.ToString(buffer2).Replace("-", " ");
                    reader.BaseStream.Position = cPos;
                    return new byte[2];
            }

            if (_dumpedEnums.ContainsKey(fieldType))
                return _stringList[reader.ReadUInt16()];

            if (KnownFieldTypes.Contains(fieldType))
                return ReadUnmappedFields(reader);

            if (KnownEnumTypes.Contains(fieldType))
                return _stringList[reader.ReadUInt16()];

            // TODO:
            var pos2 = reader.BaseStream.Position;
            try
            {
                var val = ReadUnmappedFields(reader);
                if (!KnownFieldTypes.Contains(fieldType))
                {
                    KnownFieldTypes.Add(fieldType);
                }
                return val;
            }
            catch (Exception)
            {
                reader.BaseStream.Position = pos2;

                var stringValue = _stringList[reader.ReadUInt16()];
                if (!KnownEnumTypes.Contains(fieldType))
                {
                    KnownEnumTypes.Add(fieldType);
                }
                return stringValue;
            }
        }

        public byte[] Write(NodeEntry node, List<INodeParser> parsers)
        {
            byte[] result;
            var data = (GenericUnknownStruct)node.Value;
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
                        if (_doMapping)
                        {
                            bufferList[index] = GenerateDataFromMappedFields(data.ClassList[index], stringList);
                        }
                        else
                        {
                            bufferList[index] = GenerateDataFromUnmappedFields(((GenericUnknownStruct.ClassEntry)data.ClassList[index]).Fields, stringList);
                        }
                    });

                    var dataListOffset = writer.BaseStream.Position - pos + (data.ClassList.Length * 8);
                    int classOffset = (int)dataListOffset;
                    for (int i = 0; i < data.ClassList.Length; i++)
                    {
                        if (_doMapping)
                        {
                            var strId = stringList.IndexOf(GetRealNameFromClass(data.ClassList[i]));
                            writer.Write(strId);
                        }
                        else
                        {
                            var strId = stringList.IndexOf(((GenericUnknownStruct.ClassEntry)data.ClassList[i]).Name);
                            writer.Write(strId);
                        }
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

        private string GetRealNameFromClass(GenericUnknownStruct.BaseClassEntry cls)
        {
            var attr = (RealNameAttribute)Attribute.GetCustomAttribute(cls.GetType(), typeof(RealNameAttribute));
            if (attr == null)
                throw new Exception();

            return attr.Name;
        }

        private string GetRealNameFromProperty(PropertyInfo prop)
        {
            var nameAttr = ((RealNameAttribute[])prop.GetCustomAttributes(typeof(RealNameAttribute), true)).FirstOrDefault();
            if (nameAttr == null)
                throw new Exception();

            return nameAttr.Name;
        }

        protected List<string> GenerateStringList(GenericUnknownStruct data)
        {
            var result = new HashSet<string>();

            foreach (var classEntry in data.ClassList)
            {
                if (_doMapping)
                {
                    result.Add(GetRealNameFromClass(classEntry));
                    GenerateStringListFromMappedFields(classEntry, ref result);
                }
                else
                {
                    result.Add(((GenericUnknownStruct.ClassEntry)classEntry).Name);
                    GenerateStringListFromUnmappedFields(((GenericUnknownStruct.ClassEntry)classEntry).Fields, ref result);
                }
            }

            return result.ToList();
        }

        private string GetRealTypeFromProperty(GenericUnknownStruct.BaseClassEntry cls, PropertyInfo prop)
        {
            string typeName = null;

            var typeAttr = ((RealTypeAttribute[])prop.GetCustomAttributes(typeof(RealTypeAttribute), true)).FirstOrDefault();
            if (typeAttr != null)
                typeName = typeAttr.Type;

            if (prop.PropertyType.IsEnum && _dumpedEnums.ContainsKey(prop.PropertyType.Name))
                typeName = prop.PropertyType.Name;

            if (prop.PropertyType.IsArray && prop.PropertyType.GetElementType().IsEnum && _dumpedEnums.ContainsKey(prop.PropertyType.GetElementType().Name))
                typeName = prop.PropertyType.GetElementType().Name;

            if (typeName == null)
                typeName = _typeDictionary.FirstOrDefault(x => prop.PropertyType.IsArray ? x.Value == prop.PropertyType.GetElementType() : x.Value == prop.PropertyType).Key;

            if (typeName == null)
                throw new Exception();

            // TODO: static and []
            if (prop.PropertyType.IsArray)
                typeName = "array:" + typeName;

            return typeName;
        }

        private void GenerateStringListFromMappedFields(GenericUnknownStruct.BaseClassEntry cls, ref HashSet<string> strings)
        {
            var props = cls.GetType().GetProperties();
            foreach (var prop in props)
            {
                var realType = GetRealTypeFromProperty(cls, prop);
                
                if (prop.PropertyType.IsArray)
                {
                    var arr = (IList) prop.GetValue(cls);
                    if (arr != null)
                    {
                        strings.Add(GetRealNameFromProperty(prop));
                        strings.Add(realType);
                        foreach (var val in arr)
                        {
                            if (val is GenericUnknownStruct.BaseClassEntry)
                            {
                                GenerateStringListFromMappedFields((GenericUnknownStruct.BaseClassEntry)val, ref strings);
                            }
                            else if (val.GetType().IsEnum)
                            {
                                strings.Add(val.ToString());
                            }
                        }
                    }
                }
                else
                {
                    strings.Add(GetRealNameFromProperty(prop));
                    strings.Add(realType);

                    var val = prop.GetValue(cls);
                    if (val == null)
                        continue;

                    if (realType == "CName")
                        strings.Add((string) val);
                    if (prop.PropertyType.IsEnum)
                    {
                        strings.Add(Enum.GetName(prop.PropertyType, val));
                    }
                    
                    if (val is GenericUnknownStruct.BaseClassEntry)
                    {
                        GenerateStringListFromMappedFields((GenericUnknownStruct.BaseClassEntry)val, ref strings);
                    }
                }
            }
        }

        private void GenerateStringListFromUnmappedFields(GenericUnknownStruct.BaseGenericField[] fields, ref HashSet<string> strings)
        {
            foreach (dynamic field in fields)
            {
                strings.Add(field.Name);
                strings.Add(field.Type);

                if (field.Type == "NodeRef" || field.Type == "array:NodeRef")
                {
                    continue;
                }
                else if (field.Value is IList)
                {
                    if (field.Value is GenericUnknownStruct.BaseGenericField[] subFields1)
                    {
                        GenerateStringListFromUnmappedFields(subFields1, ref strings);
                    }
                    else
                    {
                        var subList = (IList)field.Value;
                        foreach (var t1 in subList)
                        {
                            if (t1 is GenericUnknownStruct.BaseGenericField[] subFields2)
                            {
                                GenerateStringListFromUnmappedFields(subFields2, ref strings);
                            }
                            else if (t1 is String)
                            {
                                strings.Add((string) t1);
                            }
                        }
                    }
                }
                else if (field.Value is String)
                {
                    strings.Add((string)field.Value);
                }
            }
        }

        protected byte[] GenerateDataFromMappedFields(GenericUnknownStruct.BaseClassEntry cls, List<string> strings)
        {
            byte[] result;

            using (var stream = new MemoryStream())
            {
                using (var writer = new BinaryWriter(stream, Encoding.ASCII))
                {
                    var props = cls.GetType().GetProperties();

                    var count = 0;
                    foreach (var prop in props)
                    {
                        var val = prop.GetValue(cls);
                        if (val != null)
                            count++;
                    }
                    writer.Write((ushort)count);

                    foreach (var prop in props)
                    {
                        var val = prop.GetValue(cls);
                        if (val != null)
                        {
                            writer.Write((ushort)strings.IndexOf(GetRealNameFromProperty(prop)));
                            writer.Write((ushort)strings.IndexOf(GetRealTypeFromProperty(cls, prop)));
                            writer.Write(new byte[4]); // offset
                        }
                    }

                    var cnt = 0;
                    for (int i = 0; i < props.Length; i++)
                    {
                        var val1 = props[i].GetValue(cls);
                        if (val1 == null)
                            continue;

                        var pos = writer.BaseStream.Position;
                        writer.BaseStream.Position = 6 + (cnt * 8);
                        cnt++;
                        writer.Write((uint)pos);
                        writer.BaseStream.Position = pos;

                        var realType = GetRealTypeFromProperty(cls, props[i]);

                        if (props[i].PropertyType.IsArray)
                        {
                            var elementType = realType.Substring("array:".Length);

                            var arr = (IList)props[i].GetValue(cls);
                            if (arr != null)
                            {
                                writer.Write(arr.Count);
                                foreach (var val in arr)
                                {
                                    if (val is GenericUnknownStruct.BaseClassEntry)
                                    {
                                        var buffer = GenerateDataFromMappedFields((GenericUnknownStruct.BaseClassEntry)val, strings);
                                        writer.Write(buffer);
                                    }
                                    else if (elementType.StartsWith("handle:"))
                                    {
                                        writer.Write((uint)val);
                                    }
                                    else if (val.GetType().IsEnum)
                                    {
                                        WriteValue(writer, (ushort)strings.IndexOf(val.ToString()));
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (val1 is GenericUnknownStruct.BaseClassEntry)
                            {
                                var buffer = GenerateDataFromMappedFields((GenericUnknownStruct.BaseClassEntry)val1, strings);
                                writer.Write(buffer);
                            }
                            else if (val1 is string)
                            {
                                if (realType == "CName")
                                {
                                    var idx = (ushort) strings.IndexOf((string)val1);
                                    writer.Write(idx);
                                }
                            }
                            else if (props[i].PropertyType.IsEnum)
                            {
                                var idx = (ushort) strings.IndexOf(val1.ToString());
                                WriteValue(writer, idx);
                            }
                            else
                            {
                                WriteValue(writer, val1);
                            }
                        }
                    }
                }

                result = stream.ToArray();
            }

            return result;
        }

        protected byte[] GenerateDataFromUnmappedFields(GenericUnknownStruct.BaseGenericField[] fields, List<string> stringList)
        {
            byte[] result;

            using (var stream = new MemoryStream())
            {
                using (var writer = new BinaryWriter(stream, Encoding.ASCII))
                {
                    writer.Write((ushort)fields.Length);
                    foreach (var field in fields)
                    {
                        writer.Write((ushort)stringList.IndexOf(field.Name));
                        writer.Write((ushort)stringList.IndexOf(field.Type));
                        writer.Write(new byte[4]); // offset
                    }

                    for (int i = 0; i < fields.Length; i++)
                    {
                        var pos = writer.BaseStream.Position;
                        writer.BaseStream.Position = 6 + (i * 8);
                        writer.Write((uint)pos);
                        writer.BaseStream.Position = pos;

                        dynamic field = fields[i];
                        if (field.Type == "NodeRef")
                        {
                            var valStr = (string)field.Value;
                            var valBytes = Encoding.ASCII.GetBytes(valStr);

                            writer.Write((ushort)valStr.Length);
                            writer.Write(valBytes);
                        }
                        else if (field.Value is IList)
                        {
                            if (field.Value is GenericUnknownStruct.BaseGenericField[] subFields1)
                            {
                                var buffer = GenerateDataFromUnmappedFields(subFields1, stringList);
                                writer.Write(buffer);
                            }
                            else
                            {
                                var subList = (IList)field.Value;
                                writer.Write(subList.Count);
                                foreach (var t1 in subList)
                                {
                                    if (field.Type == "array:NodeRef")
                                    {
                                        var valStr = (string)t1;
                                        var valBytes = Encoding.ASCII.GetBytes(valStr);

                                        writer.Write((ushort)valStr.Length);
                                        writer.Write(valBytes);
                                    }
                                    else if (t1 is GenericUnknownStruct.BaseGenericField[] subFields2)
                                    {
                                        var buffer = GenerateDataFromUnmappedFields(subFields2, stringList);
                                        writer.Write(buffer);
                                    }
                                    else if (t1 is String)
                                    {
                                        writer.Write((ushort)stringList.IndexOf((string)t1));
                                    }
                                    else
                                    {
                                        WriteValue(writer, t1);
                                    }
                                }
                            }
                        }
                        else if (field.Value is String)
                        {
                            writer.Write((ushort)stringList.IndexOf((string)field.Value));
                        }
                        else
                        {
                            WriteValue(writer, field.Value);
                        }
                    }
                }

                result = stream.ToArray();
            }

            return result;
        }

        private void WriteValue(BinaryWriter writer, object value)
        {
            var type = value.GetType();
            var typeStr = type.FullName;

            switch (typeStr)
            {
                case "System.Byte":
                    writer.Write((byte)value);
                    break;

                case "System.Int16":
                    writer.Write((short)value);
                    break;

                case "System.UInt16":
                    writer.Write((ushort)value);
                    break;

                case "System.Int32":
                    writer.Write((int)value);
                    break;

                case "System.UInt32":
                    writer.Write((uint)value);
                    break;

                case "System.Int64":
                    writer.Write((long)value);
                    break;

                case "System.UInt64":
                    writer.Write((ulong)value);
                    break;

                case "System.Boolean":
                    writer.Write((bool)value);
                    break;

                case "System.Single":
                    writer.Write((float)value);
                    break;

                default:
                    throw new Exception();
            }
        }
    }
}