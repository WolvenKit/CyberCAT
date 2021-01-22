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
using CyberCAT.Core.Classes.NodeRepresentations;
using Newtonsoft.Json;

namespace CyberCAT.Core.Classes.Parsers
{
    public class GenericUnknownStructParser
    {
        private const bool DEBUG = false;

        private bool _doMapping;

        private List<string> _stringList;

        public object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            _doMapping = false;

            return internalRead(node, reader, parsers);
        }

        public object ReadWithMapping(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            _doMapping = true;

            return internalRead(node, reader, parsers);
        }

        private object _handlesLock = new object();
        private List<IHandle> _handles;

        private object internalRead(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            var result = new GenericUnknownStruct();

            reader.Skip(4); //skip Id

            int readSize = node.Size - ((int)reader.BaseStream.Position - node.Offset);
            var dataBuffer = reader.ReadBytes(readSize);

            if (DEBUG)
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
                            length = pointerList[i + 1].Value - pointerList[i].Value;
                        }
                        else
                        {
                            length = result.TotalLength - br.BaseStream.Position + 4;
                        }

                        GenericUnknownStruct.BaseClassEntry classEntry;
                        if (_doMapping)
                        {
                            classEntry = GetInstanceFromName(_stringList[(int)pointerList[i].Key]);
                        }
                        else
                        {
                            classEntry = new GenericUnknownStruct.ClassEntry();
                            ((GenericUnknownStruct.ClassEntry)classEntry).Name = _stringList[(int)pointerList[i].Key];
                        }

                        bufferDict.Add(i, br.ReadBytes((int)length));

                        result.ClassList[i] = classEntry;
                    }

                    _handles = new List<IHandle>();

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

                    if (DEBUG)
                    {
                        var tmp = JsonConvert.SerializeObject(_defaultValues);
                        File.WriteAllText($"C:\\Dev\\T1\\values.json", tmp);
                    }

                    SetHandlesValue(result);
                    _handles = null;

                    // end of mainData
                    Debug.Assert((br.BaseStream.Position - 4) == result.TotalLength);

                    readSize = (int)(br.BaseStream.Length - br.BaseStream.Position);
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

            _stringList = null;

            result.Node = node;

            return result;
        }

        private void SetHandlesValue(GenericUnknownStruct data)
        {
            data.Handles = _handles;

            var usedIndexes = new HashSet<uint>();
            foreach (var handle in _handles)
            {
                var id = handle.GetId();
                handle.SetValue(data.ClassList[id]);
                usedIndexes.Add(id);
            }

            foreach (var index in usedIndexes)
            {
                data.ClassList[index] = null;
            }

            var newClassList = new List<GenericUnknownStruct.BaseClassEntry>();
            foreach (var classEntry in data.ClassList)
            {
                if (classEntry != null)
                    newClassList.Add(classEntry);
            }

            data.ClassList = newClassList.ToArray();
        }

        private class FieldInfo
        {
            public string Name { get; set; }
            public string Type { get; set; }
            public uint Offset { get; set; }
        }

        private Type GetTypeFromName(string name)
        {
            if (MappingHelper.DumpedClasses.ContainsKey(name))
            {
                return MappingHelper.DumpedClasses[name];
            }

            return null;
        }

        private GenericUnknownStruct.BaseClassEntry GetInstanceFromName(string name)
        {
            if (MappingHelper.DumpedClasses.ContainsKey(name))
            {
                var classType = MappingHelper.DumpedClasses[name];
                return (GenericUnknownStruct.BaseClassEntry)Activator.CreateInstance(classType);
            }

            throw new Exception();
        }

        private string GetRealName(Type type)
        {
            if (MappingHelper.RealNameCache.TryGetValue(type.Name, out var name))
                return name;

            throw new Exception();
        }

        private string GetRealName(PropertyInfo propertyInfo)
        {
            if (MappingHelper.RealNameCache.TryGetValue($"{propertyInfo.DeclaringType.Name}.{propertyInfo.Name}", out var name))
                return name;

            throw new Exception();
        }

        private RealTypeAttribute GetRealType(PropertyInfo propertyInfo)
        {
            if (MappingHelper.RealTypeCache.TryGetValue($"{propertyInfo.DeclaringType.Name}.{propertyInfo.Name}", out var name))
                return name;

            return null;
        }

        private void SetProperty(GenericUnknownStruct.BaseClassEntry cls, string propertyName, object value)
        {
            foreach (var prop in cls.GetType().GetProperties())
            {
                var attrName = GetRealName(prop);
                if (attrName != null && attrName == propertyName)
                {
                    if (prop.PropertyType.IsEnum)
                    {
                        value = Enum.Parse(prop.PropertyType, (string)value);
                    }
                    else if (typeof(IHandle).IsAssignableFrom(prop.PropertyType))
                    {
                        value = Activator.CreateInstance(prop.PropertyType, new[] { value });

                        lock (_handlesLock)
                        {
                            _handles.Add((IHandle)value);
                        }
                    }
                    else if (Nullable.GetUnderlyingType(prop.PropertyType) != null)
                    {
                        var underlyingType = Nullable.GetUnderlyingType(prop.PropertyType);
                        if (underlyingType.IsEnum)
                        {
                            value = Enum.Parse(underlyingType, (string)value);
                        }
                    }

                    prop.SetValue(cls, value);
                    return;
                }
            }

            throw new PropertyNotFoundException(cls.GetType().Name, propertyName);
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

        private Dictionary<string, Dictionary<string, HashSet<object>>> _missingProps =
            new Dictionary<string, Dictionary<string, HashSet<object>>>();

        private bool CompareValues(object valueA, object valueB)
        {
            bool result;
            IComparable selfValueComparer;

            selfValueComparer = valueA as IComparable;

            if (valueA == null && valueB != null || valueA != null && valueB == null)
                result = false; // one of the values is null
            else if (selfValueComparer != null && selfValueComparer.CompareTo(valueB) != 0)
                result = false; // the comparison using IComparable failed
            else if (!object.Equals(valueA, valueB))
                result = false; // the comparison using Equals failed
            else
                result = true; // match

            return result;
        }

        private bool CheckProperty(GenericUnknownStruct.BaseClassEntry cls, string propertyName, object value)
        {
            foreach (var prop in cls.GetType().GetProperties())
            {
                var attrName = GetRealName(prop);
                if (attrName != null && attrName == propertyName)
                {
                    var defaultValue = prop.GetValue(cls);
                    return CompareValues(defaultValue, value);
                }
            }

            throw new Exception();
        }

        private static object _defaultValuesLock = new object();
        private static Dictionary<string, List<string>> _defaultValues = new Dictionary<string, List<string>>();
        private object ReadMappedFields(BinaryReader reader, GenericUnknownStruct.BaseClassEntry cls)
        {
            var startPos = reader.BaseStream.Position;

            var fieldInfos = ReadFieldInfos(reader);
            for (int i = 0; i < fieldInfos.Length; i++)
            {
                reader.BaseStream.Position = startPos + fieldInfos[i].Offset;

                var ret = ReadMappedFieldValue(reader, cls, fieldInfos[i].Name, fieldInfos[i].Type);

                if (DEBUG)
                {
                    if (CheckProperty(cls, fieldInfos[i].Name, ret))
                    {
                        lock (_defaultValuesLock)
                        {
                            if (!_defaultValues.ContainsKey(cls.GetType().Name))
                                _defaultValues.Add(cls.GetType().Name, new List<string>());

                            if (!_defaultValues[cls.GetType().Name].Contains(fieldInfos[i].Name))
                                _defaultValues[cls.GetType().Name].Add(fieldInfos[i].Name);
                        }
                    }
                }

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

        private Type GetFieldType(GenericUnknownStruct.BaseClassEntry cls, string fieldName, string fieldTypeName)
        {
            if (fieldTypeName == "Bool")
                return typeof(bool);

            if (fieldTypeName == "Float")
                return typeof(float);

            if (fieldTypeName == "CName")
                return typeof(string);

            if (fieldTypeName == "NodeRef")
                return typeof(string);

            if (fieldTypeName == "TweakDBID")
                return typeof(TweakDbId);

            if (fieldTypeName.StartsWith("handle:"))
            {
                var tmpTypeName = fieldTypeName.Substring("handle:".Length);
                var tmpType = GetTypeFromName(tmpTypeName);

                return typeof(Handle<>).MakeGenericType(tmpType);
            }

            if (MappingHelper.DumpedEnums.ContainsKey(fieldTypeName))
            {
                var enumType = MappingHelper.DumpedEnums[fieldTypeName];
                return typeof(Nullable<>).MakeGenericType(enumType);
            }


            return GetTypeFromName(fieldTypeName);
        }

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

                var fieldType = GetFieldType(cls, fieldName, fieldTypeName);
                var arraySize = reader.ReadUInt32();

                var arr = (IList)Array.CreateInstance(fieldType, arraySize);

                for (int i = 0; i < arraySize; i++)
                {
                    var val = ReadMappedFieldValue(reader, cls, fieldName, fieldTypeName);
                    if (fieldType.IsEnum)
                    {
                        arr[i] = Enum.Parse(fieldType, (string)val);
                    }
                    else if (typeof(IHandle).IsAssignableFrom(fieldType))
                    {
                        arr[i] = Activator.CreateInstance(fieldType, new[] { val });

                        lock (_handlesLock)
                        {
                            _handles.Add((IHandle)arr[i]);
                        }
                    }
                    else if (Nullable.GetUnderlyingType(fieldType) != null)
                    {
                        var underlyingType = Nullable.GetUnderlyingType(fieldType);
                        if (underlyingType.IsEnum)
                        {
                            arr[i] = Enum.Parse(underlyingType, (string)val);
                        }
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
                    return reader.ReadUInt64();

                case "TweakDBID":
                    return reader.ReadTweakDbId();

                case "Float":
                    return reader.ReadSingle();

                case "NodeRef":
                    var size = reader.ReadUInt16();
                    var buffer = reader.ReadBytes(size);
                    return Encoding.ASCII.GetString(buffer);

                case "CName":
                    return _stringList[reader.ReadUInt16()];

                // TODO: special cases
                case "KEEP_FOR_DEBUG":
                    var cPos = reader.BaseStream.Position;
                    var buffer2 = reader.ReadBytes(256);
                    var debugStr = BitConverter.ToString(buffer2).Replace("-", " ");
                    reader.BaseStream.Position = cPos;
                    return new byte[2];
            }

            if (MappingHelper.DumpedEnums.ContainsKey(fieldTypeName))
                return _stringList[reader.ReadUInt16()];


            var subCls = GetInstanceFromName(fieldTypeName);
            ReadMappedFields(reader, subCls);
            return subCls;
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
                    return reader.ReadUInt64();

                case "TweakDBID":
                    return reader.ReadTweakDbId();

                case "Float":
                    return reader.ReadSingle();

                case "NodeRef":
                    var size = reader.ReadUInt16();
                    var buffer = reader.ReadBytes(size);
                    return Encoding.ASCII.GetString(buffer);

                case "CName":
                    return _stringList[reader.ReadUInt16()];

                // TODO: special cases
                case "KEEP_FOR_DEBUG":
                    var cPos = reader.BaseStream.Position;
                    var buffer2 = reader.ReadBytes(256);
                    var debugStr = BitConverter.ToString(buffer2).Replace("-", " ");
                    reader.BaseStream.Position = cPos;
                    return new byte[2];
            }

            if (MappingHelper.DumpedEnums.ContainsKey(fieldType))
                return _stringList[reader.ReadUInt16()];

            return ReadUnmappedFields(reader);
        }

        public void Write(NodeWriter writer2, NodeEntry node)
        {
            var data = (GenericUnknownStruct)node.Value;

            using (var ms = new MemoryStream())
            {
                using (var writer = new BinaryWriter(ms))
                {
                    GenericUnknownStruct.BaseClassEntry[] classList;
                    if (_doMapping)
                    {
                        classList = SetHandlesIndex(data);
                    }
                    else
                    {
                        classList = data.ClassList;
                    }

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

                    _stringList = GenerateStringList(classList);

                    var offset = _stringList.Count * 4;
                    foreach (var str in _stringList)
                    {
                        writer.WriteInt24(offset);
                        writer.Write((byte)(str.Length + 1));
                        offset += (short)(str.Length + 1);
                    }

                    var stringListOffset = writer.BaseStream.Position - pos;

                    foreach (var str in _stringList)
                    {
                        var bytes = Encoding.ASCII.GetBytes(str);
                        writer.Write(bytes);
                        writer.Write(new byte[1]);
                    }

                    var dataIndexListOffset = writer.BaseStream.Position - pos;

                    var bufferList = new byte[classList.Length][];
                    Parallel.For(0, classList.Length, (index, state) =>
                    {
                        if (_doMapping)
                        {
                            bufferList[index] = GenerateDataFromMappedFields(classList[index]);
                        }
                        else
                        {
                            bufferList[index] = GenerateDataFromUnmappedFields(((GenericUnknownStruct.ClassEntry)classList[index]).Fields);
                        }
                    });

                    var dataListOffset = writer.BaseStream.Position - pos + (classList.Length * 8);
                    int classOffset = (int)dataListOffset;
                    for (int i = 0; i < classList.Length; i++)
                    {
                        if (_doMapping)
                        {
                            var strId = _stringList.IndexOf(GetRealName(classList[i].GetType()));
                            writer.Write(strId);
                        }
                        else
                        {
                            var strId = _stringList.IndexOf(((GenericUnknownStruct.ClassEntry)classList[i]).Name);
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

                    var totalLength = (int)writer.BaseStream.Length - 4;

                    if (data.CNameHashes2 != null && data.CNameHashes2.Length > 0)
                    {
                        writer.Write(data.CNameHashes2.Length);
                        foreach (var hash in data.CNameHashes2)
                        {
                            writer.Write(hash);
                        }
                    }

                    writer.BaseStream.Position = 0;
                    writer.Write(totalLength);
                    writer.BaseStream.Position += 12;
                    writer.Write((int)stringListOffset);
                    writer.Write((int)dataIndexListOffset);
                    writer.Write((int)dataListOffset);
                }

                writer2.Write(ms.ToArray());
            }

            _stringList = null;

            GC.Collect();
        }

        private GenericUnknownStruct.BaseClassEntry[] SetHandlesIndex(GenericUnknownStruct data)
        {
            var newClassList = new List<GenericUnknownStruct.BaseClassEntry>();

            foreach (var classEntry in data.ClassList)
            {
                if (classEntry == null)
                    continue;

                newClassList.Add(classEntry);
            }

            if (data.Handles.Count > 0)
            {
                var handles = data.Handles.OrderBy(h => h.GetId()).ToList();

                var lastOrgIdx = (uint) 0;
                var idx = (uint) newClassList.Count - 1;
                for (int i = 0; i < handles.Count; i++)
                {
                    var handleId = handles[i].GetId();

                    if (lastOrgIdx == handleId)
                    {
                        handles[i].SetId(idx);
                    }
                    else
                    {
                        lastOrgIdx = handleId;
                        handles[i].SetId(++idx);
                    }
                }

                var usedIds = new HashSet<uint>();
                foreach (var handle in handles)
                {
                    if (usedIds.Contains(handle.GetId()))
                        continue;

                    newClassList.Add(handle.GetValue());
                    usedIds.Add(handle.GetId());
                }
            }

            return newClassList.ToArray();
        }


        protected List<string> GenerateStringList(GenericUnknownStruct.BaseClassEntry[] classes)
        {
            var result = new HashSet<string>();

            foreach (var classEntry in classes)
            {
                if (_doMapping)
                {
                    result.Add(GetRealName(classEntry.GetType()));
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

        private (string, string) GetTypeStringFromProperty(PropertyInfo propInfo, GenericUnknownStruct.BaseClassEntry cls)
        {
            return GetTypeStringFromProperty(propInfo, propInfo.GetValue(cls));
        }
        
        private (string, string) GetTypeStringFromProperty(PropertyInfo propInfo, object propValue)
        {
            var attr = GetRealType(propInfo);
            if (attr != null)
            {
                var typeStr = attr.Type;

                if (attr.IsHandle && !typeStr.StartsWith("handle:"))
                    typeStr = "handle:" + typeStr;

                if (attr.IsArray && !typeStr.StartsWith("["))
                    return ($"[{((IList)propValue).Count}]" + typeStr, attr.Type);

                if (attr.IsStatic && !typeStr.StartsWith("static:"))
                    return ($"static:{((IList)propValue).Count}," + typeStr, attr.Type);

                if (propInfo.PropertyType.IsArray)
                    typeStr = "array:" + typeStr;

                return (typeStr, attr.Type);
            }

            if (propInfo.PropertyType.IsArray)
            {
                var elementType = propInfo.PropertyType.GetElementType();

                if (elementType.IsEnum && MappingHelper.DumpedEnums.ContainsKey(elementType.Name))
                    return ("array:" + elementType.Name, elementType.Name);

                var typeStr = MappingHelper.DumpedClasses.FirstOrDefault(x => x.Value == elementType).Key;
                if (typeStr != null)
                    return ("array:" + typeStr, typeStr);

                if (Nullable.GetUnderlyingType(elementType) != null)
                    return ("array:" + Nullable.GetUnderlyingType(elementType).Name, Nullable.GetUnderlyingType(elementType).Name);

                if (typeof(IHandle).IsAssignableFrom(elementType))
                {
                    var genericType = elementType.GetGenericArguments()[0];
                    var attrName = GetRealName(genericType);
                    if (attrName != null)
                    {
                        return ("array:handle:" + attrName, attrName);
                    }
                    else
                    {
                        return ("array:handle:" + genericType.Name, genericType.Name);
                    }
                }

                throw new Exception();
            }
            else
            {
                if (propInfo.PropertyType.IsEnum && MappingHelper.DumpedEnums.ContainsKey(propInfo.PropertyType.Name))
                    return (propInfo.PropertyType.Name, propInfo.PropertyType.Name);

                var typeStr = MappingHelper.DumpedClasses.FirstOrDefault(x => x.Value == propInfo.PropertyType).Key;
                if (typeStr != null)
                    return (typeStr, typeStr);

                if (Nullable.GetUnderlyingType(propInfo.PropertyType) != null)
                    return (Nullable.GetUnderlyingType(propInfo.PropertyType).Name, Nullable.GetUnderlyingType(propInfo.PropertyType).Name);

                if (typeof(IHandle).IsAssignableFrom(propInfo.PropertyType))
                {
                    var genericType = propInfo.PropertyType.GetGenericArguments()[0];
                    var attrName = GetRealName(genericType);
                    if (attrName != null)
                    {
                        return ("handle:" + attrName, attrName);
                    }
                    else
                    {
                        return ("handle:" + genericType.Name, genericType.Name);
                    }
                }

                throw new Exception();
            }

            throw new Exception();
        }

        private void GetStringValueFromPropValue(object propValue, string baseType, ref HashSet<string> strings)
        {
            if (propValue is GenericUnknownStruct.BaseClassEntry)
            {
                GenerateStringListFromMappedFields((GenericUnknownStruct.BaseClassEntry)propValue, ref strings);
            }
            else if (propValue is string)
            {
                if (baseType == "CName")
                {
                    strings.Add((string)propValue);
                }
                else if (baseType == "NodeRef")
                {
                    return;
                }
                else if (MappingHelper.DumpedEnums.ContainsKey(baseType))
                {
                    strings.Add((string)propValue);
                }
            }
            else if (propValue.GetType().IsEnum)
            {
                strings.Add(propValue.ToString());
            }
        }

        private bool CanBeIgnored(GenericUnknownStruct.BaseClassEntry cls, PropertyInfo propInfo, object propValue)
        {
            var name = $"{cls.GetType().Name}.{propInfo.Name}";
            if (MappingHelper.IgnoredCache.Contains(name))
                return true;

            var defaultVal = MappingHelper.DefaultValueCache[name];
            return CompareValues(propValue, defaultVal);
        }

        private void GenerateStringListFromMappedFields(GenericUnknownStruct.BaseClassEntry cls, ref HashSet<string> strings)
        {
            var props = new List<PropertyInfo>();
            foreach (var prop in cls.GetType().GetProperties())
            {
                var propValue = prop.GetValue(cls);
                if (CanBeIgnored(cls, prop, propValue))
                    continue;

                props.Add(prop);
            }

            props = props
                .GroupBy(p => p.DeclaringType)
                .Reverse()
                .SelectMany(g => g)
                .ToList();

            foreach (var prop in props)
            {
                var propValue = prop.GetValue(cls);
                var (typeString, baseType) = GetTypeStringFromProperty(prop, propValue);

                strings.Add(GetRealName(prop));
                strings.Add(typeString);

                if (prop.PropertyType.IsArray)
                {
                    foreach (var val in (IList)propValue)
                    {
                        GetStringValueFromPropValue(val, baseType, ref strings);
                    }
                }
                else
                {
                    GetStringValueFromPropValue(propValue, baseType, ref strings);
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
                                strings.Add((string)t1);
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

        private void WriteValueFromPropValue(BinaryWriter writer, object propValue, string baseType, string elementType)
        {
            if (propValue is GenericUnknownStruct.BaseClassEntry subCls)
            {
                var newBuffer = GenerateDataFromMappedFields(subCls);
                writer.Write(newBuffer);
            }
            else if (propValue is IHandle handle)
            {
                writer.Write(handle.GetId());
            }
            else if (propValue.GetType().IsEnum)
            {
                WriteValue(writer, (ushort)_stringList.IndexOf(propValue.ToString()));
            }
            else if (propValue is string valStr)
            {
                if (baseType == "CName")
                {
                    writer.Write((ushort)_stringList.IndexOf(valStr));
                }
                else if (baseType == "NodeRef")
                {
                    var valBytes = Encoding.ASCII.GetBytes(valStr);

                    writer.Write((ushort)valStr.Length);
                    writer.Write(valBytes);
                }
            }
            else
            {
                WriteValue(writer, propValue);
            }
        }

        protected byte[] GenerateDataFromMappedFields(GenericUnknownStruct.BaseClassEntry cls)
        {
            byte[] result;

            using (var stream = new MemoryStream())
            {
                using (var writer = new BinaryWriter(stream, Encoding.ASCII))
                {
                    var props = new List<PropertyInfo>();

                    foreach (var prop in cls.GetType().GetProperties())
                    {
                        var propValue = prop.GetValue(cls);
                        if (CanBeIgnored(cls, prop, propValue))
                            continue;

                        props.Add(prop);
                    }
                    props = props
                        .GroupBy(p => p.DeclaringType)
                        .Reverse()
                        .SelectMany(g => g)
                        .ToList();

                    writer.Write((ushort)props.Count);
                    foreach (var prop in props)
                    {
                        writer.Write((ushort)_stringList.IndexOf(GetRealName(prop)));
                        var (typeString, baseType) = GetTypeStringFromProperty(prop, cls);
                        writer.Write((ushort)_stringList.IndexOf(typeString));
                        writer.Write(new byte[4]); // offset
                    }

                    for (int i = 0; i < props.Count; i++)
                    {
                        var pos = writer.BaseStream.Position;
                        writer.BaseStream.Position = 6 + (i * 8);
                        writer.Write((uint)pos);
                        writer.BaseStream.Position = pos;

                        var (typeString, baseType) = GetTypeStringFromProperty(props[i], cls);

                        if (props[i].PropertyType.IsArray)
                        {
                            var elementType = typeString.Substring("array:".Length);

                            var arr = (IList)props[i].GetValue(cls);

                            writer.Write(arr.Count);
                            foreach (var val in arr)
                            {
                                WriteValueFromPropValue(writer, val, baseType, elementType);
                            }
                        }
                        else
                        {
                            var val = props[i].GetValue(cls);
                            WriteValueFromPropValue(writer, val, baseType, null);
                        }
                    }
                }

                result = stream.ToArray();
            }

            return result;
        }

        protected byte[] GenerateDataFromUnmappedFields(GenericUnknownStruct.BaseGenericField[] fields)
        {
            byte[] result;

            using (var stream = new MemoryStream())
            {
                using (var writer = new BinaryWriter(stream, Encoding.ASCII))
                {
                    writer.Write((ushort)fields.Length);
                    foreach (var field in fields)
                    {
                        writer.Write((ushort)_stringList.IndexOf(field.Name));
                        writer.Write((ushort)_stringList.IndexOf(field.Type));
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
                                var buffer = GenerateDataFromUnmappedFields(subFields1);
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
                                        var buffer = GenerateDataFromUnmappedFields(subFields2);
                                        writer.Write(buffer);
                                    }
                                    else if (t1 is String)
                                    {
                                        writer.Write((ushort)_stringList.IndexOf((string)t1));
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
                            writer.Write((ushort)_stringList.IndexOf((string)field.Value));
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

                case "CyberCAT.Core.Classes.TweakDbId":
                    writer.Write((TweakDbId)value);
                    break;

                default:
                    throw new Exception();
            }
        }
    }
}