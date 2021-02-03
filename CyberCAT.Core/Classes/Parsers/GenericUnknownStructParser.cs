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

namespace CyberCAT.Core.Classes.Parsers
{
    public class GenericUnknownStructParser
    {
        private bool _doMapping;

        private object _handlesLock = new object();
        private List<IHandle> _handles;
        private List<string> _stringList;

        public static event EventHandler<WrongDefaultValueEventArgs> WrongDefaultValue;

        internal static bool OnWrongDefaultValue(WrongDefaultValueEventArgs e)
        {
            WrongDefaultValue?.Invoke(null, e);

            return e.Ignore;
        }

        public object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            _doMapping = false;

            return InternalRead(node, reader);
        }

        public object ReadWithMapping(NodeEntry node, BinaryReader reader, List<INodeParser> parsers)
        {
            _doMapping = true;

            return InternalRead(node, reader);
        }

        private object InternalRead(NodeEntry node, BinaryReader reader)
        {
            var result = new GenericUnknownStruct();

            reader.Skip(4); //skip Id

            int readSize = node.Size - ((int)reader.BaseStream.Position - node.Offset);
            var dataBuffer = reader.ReadBytes(readSize);

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
                    var stringInfoList = new List<KeyValuePair<int, byte>>();
                    for (int i = 0; i < (stringListPosition - stringIndexListPosition) / 4; i++)
                    {
                        stringInfoList.Add(new KeyValuePair<int, byte>(br.ReadInt24(), br.ReadByte()));
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
                                {
                                    ReadMappedFields(br2, result.ClassList[pair.Key]);
                                }
                                else
                                {
                                    ((GenericUnknownStruct.ClassEntry)result.ClassList[pair.Key]).Fields = ReadUnmappedFields(br2);
                                }
                            }
                        }
                    });

                    if (_doMapping) 
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

        #region Mapped reading

        private void SetHandlesValue(GenericUnknownStruct data)
        {
            data.Handles = _handles;

            var usedIndexes = new HashSet<uint>();
            foreach (var handle in _handles)
            {
                var id = handle.Id;
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

        private GenericUnknownStruct.BaseClassEntry GetInstanceFromName(string name)
        {
            var type = MappingHelper.DumpedClasses.GetValue(name);
            if (type != null)
                return (GenericUnknownStruct.BaseClassEntry)Activator.CreateInstance(type);

            throw new ClassNotFoundException(name);
        }

        private string GetRealName(Type type)
        {
            if (MappingHelper.RealNameCache.TryGetValue(type.Name, out var name))
                return name;

            throw new Exception();
        }

        private string GetRealName(PropertyInfo propertyInfo)
        {
            if (propertyInfo == null) throw new ArgumentNullException(nameof(propertyInfo));
            if (propertyInfo.DeclaringType == null) throw new ArgumentNullException(nameof(propertyInfo.DeclaringType));

            var name = string.Join(".", propertyInfo.DeclaringType.Name, propertyInfo.Name);
            if (MappingHelper.RealNameCache.TryGetValue(name, out var realName))
                return realName;

            throw new Exception();
        }

        private Type GetInternalType(string fieldTypeName)
        {
            Type baseType = null;

            var isArray = false;
            var isEnum = false;
            var isHandle = false;

            if (fieldTypeName.StartsWith("array:"))
            {
                fieldTypeName = fieldTypeName.Substring("array:".Length);
                isArray = true;
            }

            if (fieldTypeName.StartsWith("static:"))
            {
                fieldTypeName = fieldTypeName.Substring(fieldTypeName.IndexOf(',') + 1);
                isArray = true;
            }

            if (fieldTypeName.StartsWith("["))
            {
                fieldTypeName = fieldTypeName.Substring(fieldTypeName.IndexOf(']') + 1);
                isArray = true;
            }

            if (fieldTypeName.StartsWith("handle:"))
            {
                fieldTypeName = fieldTypeName.Substring("handle:".Length);
                isHandle = true;
            }

            if (fieldTypeName.StartsWith("whandle:"))
            {
                throw new UnknownTypeException(fieldTypeName);
            }

            if (fieldTypeName.StartsWith("script_ref:"))
            {
                throw new UnknownTypeException(fieldTypeName);
            }

            var classType = MappingHelper.DumpedClasses.GetValue(fieldTypeName);
            if (classType != null)
                baseType = classType;

            var enumType = MappingHelper.DumpedEnums.GetValue(fieldTypeName);
            if (enumType != null)
            {
                baseType = enumType;
                isEnum = true;
            }

            var type = MappingHelper.BasicTypes.GetValue(fieldTypeName);
            if (type != null)
                baseType = type;

            if (baseType == null)
                throw new UnknownTypeException(fieldTypeName);

            if (isHandle)
            {
                baseType = typeof(Handle<>).MakeGenericType(baseType);
            }

            if (isEnum)
            {
                baseType = typeof(Nullable<>).MakeGenericType(baseType);
            }

            if (isArray)
            {
                baseType = baseType.MakeArrayType();
            }

            return baseType;
        }

        private void SetProperty(GenericUnknownStruct.BaseClassEntry cls, string propertyName, object value)
        {
            foreach (var prop in cls.GetType().GetProperties())
            {
                var attrName = GetRealName(prop);
                if (attrName != null && attrName == propertyName)
                {
                    if (MappingHelper.GetPropertyHelper(prop).IsDefault(value))
                    {
                        var ignore = OnWrongDefaultValue(new WrongDefaultValueEventArgs(cls.GetType().Name, propertyName, value));
                        if (!ignore)
                            throw new WrongDefaultValueException(cls.GetType().Name, propertyName, value);
                    }

                    MappingHelper.GetPropertyHelper(prop).Set(cls, value);
                    return;
                }
            }

            throw new PropertyNotFoundException(cls.GetType().Name, propertyName);
        }

        private void ReadMappedFields(BinaryReader reader, GenericUnknownStruct.BaseClassEntry cls)
        {
            var startPos = reader.BaseStream.Position;

            var fieldInfos = ReadFieldInfos(reader);
            for (int i = 0; i < fieldInfos.Length; i++)
            {
                reader.BaseStream.Position = startPos + fieldInfos[i].Offset;

                var internalType = GetInternalType(fieldInfos[i].Type);
                var ret = ReadMappedFieldValue(reader, internalType);

                SetProperty(cls, fieldInfos[i].Name, ret);
            }
        }

        private object ReadMappedFieldValue(BinaryReader reader, Type internalType)
        {
            if (internalType.IsArray)
            {
                var elementType = internalType.GetElementType();

                var arraySize = reader.ReadUInt32();
                var arr = (IList)Array.CreateInstance(elementType ?? throw new InvalidOperationException(), arraySize);

                for (int i = 0; i < arraySize; i++)
                {
                    arr[i] = ReadMappedFieldValue(reader, elementType);
                }

                return arr;
            }

            if (typeof(IHandle).IsAssignableFrom(internalType))
            {
                var handle = Activator.CreateInstance(internalType, reader.ReadUInt32());
                lock (_handlesLock)
                {
                    _handles.Add((IHandle)handle);
                }
                return handle;
            }

            if (internalType == typeof(sbyte))
                return reader.ReadSByte();

            if (internalType == typeof(byte))
                return reader.ReadByte();

            if (internalType == typeof(short))
                return reader.ReadInt16();

            if (internalType == typeof(ushort))
                return reader.ReadUInt16();

            if (internalType == typeof(int))
                return reader.ReadInt32();

            if (internalType == typeof(uint))
                return reader.ReadUInt32();

            if (internalType == typeof(long))
                return reader.ReadInt64();

            if (internalType == typeof(ulong))
                return reader.ReadUInt64();

            if (internalType == typeof(float))
                return reader.ReadSingle();

            if (internalType == typeof(bool))
                return reader.ReadBoolean();

            if (internalType == typeof(string))
                throw new NotImplementedException();

            if (internalType == typeof(CName))
                return (CName)_stringList[reader.ReadUInt16()];

            if (internalType == typeof(NodeRef))
            {
                var size = reader.ReadUInt16();
                var buffer = reader.ReadBytes(size);
                return (NodeRef)Encoding.ASCII.GetString(buffer);
            }

            if (internalType == typeof(TweakDbId))
                return reader.ReadTweakDbId();

            var underlyingType = Nullable.GetUnderlyingType(internalType);
            if (underlyingType != null && underlyingType.IsEnum)
                return Enum.Parse(underlyingType, _stringList[reader.ReadUInt16()]);

            var subCls = (GenericUnknownStruct.BaseClassEntry)Activator.CreateInstance(internalType);
            ReadMappedFields(reader, subCls);
            return subCls;
        }

        #endregion

        #region Unmapped reading

        private GenericUnknownStruct.BaseGenericField[] ReadUnmappedFields(BinaryReader reader)
        {
            var startPos = reader.BaseStream.Position;

            var fieldInfos = ReadFieldInfos(reader);
            var fieldArray = new GenericUnknownStruct.BaseGenericField[fieldInfos.Length];
            for (int i = 0; i < fieldInfos.Length; i++)
            {
                reader.BaseStream.Position = startPos + fieldInfos[i].Offset;

                var val = ReadUnmappedFieldValue(reader, fieldInfos[i].Type);

                var type = typeof(GenericUnknownStruct.GenericField<>).MakeGenericType(val.GetType());
                dynamic field = Activator.CreateInstance(type, val);
                field.Name = fieldInfos[i].Name;
                field.Type = fieldInfos[i].Type;

                fieldArray[i] = field;
            }

            return fieldArray;
        }

        private object ReadUnmappedFieldValue(BinaryReader reader, string fieldType)
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
                Array result = null;
                for (int i = 0; i < arraySize; i++)
                {
                    var val = ReadUnmappedFieldValue(reader, fieldType);

                    if (i == 0)
                        result = Array.CreateInstance(val.GetType(), arraySize);

                    if (result == null)
                        throw new Exception();

                    result.SetValue(val, i);
                }

                return result;
            }

            if (fieldType.StartsWith("script_ref:"))
            {
                throw new UnknownTypeException(fieldType);
            }

            if (fieldType.StartsWith("handle:"))
            {
                return reader.ReadUInt32();
            }

            if (fieldType.StartsWith("whandle:"))
            {
                throw new UnknownTypeException(fieldType);
            }

            switch (fieldType)
            {
                case "Bool":
                    return reader.ReadByte() != 0;

                case "Int16":
                    return reader.ReadInt16();

                case "Uint16":
                    return reader.ReadUInt16();

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
            }

            var enumType = MappingHelper.DumpedEnums.GetValue(fieldType);
            if (enumType != null)
                return _stringList[reader.ReadUInt16()];

            return ReadUnmappedFields(reader);
        }

        #endregion

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

                    var stringList = new string[classList.Length][];
                    Parallel.For(0, classList.Length, (index, state) =>
                    {
                        stringList[index] = GenerateStringList(classList[index]);
                    });

                    var tmpSringList = new HashSet<string>();
                    foreach (var strings in stringList)
                    {
                        foreach (var str in strings)
                        {
                            tmpSringList.Add(str);
                        }
                    }

                    _stringList = tmpSringList.ToList();
                    //_stringList = GenerateStringList(classList);

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

        private string[] GenerateStringList(GenericUnknownStruct.BaseClassEntry cls)
        {
            var result = new HashSet<string>();

            if (_doMapping)
            {
                result.Add(GetRealName(cls.GetType()));
                GenerateStringListFromMappedFields(cls, ref result);
            }
            else
            {
                result.Add(((GenericUnknownStruct.ClassEntry)cls).Name);
                GenerateStringListFromUnmappedFields(((GenericUnknownStruct.ClassEntry)cls).Fields, ref result);
            }

            return result.ToArray();
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


        #region Mapped writing

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
                var handles = data.Handles.OrderBy(h => h.Id).ToList();

                var lastOrgIdx = (uint)0;
                var idx = (uint)newClassList.Count - 1;
                for (int i = 0; i < handles.Count; i++)
                {
                    var handleId = handles[i].Id;

                    if (lastOrgIdx == handleId)
                    {
                        handles[i].Id = idx;
                    }
                    else
                    {
                        lastOrgIdx = handleId;
                        handles[i].Id = ++idx;
                    }
                }

                var usedIds = new HashSet<uint>();
                foreach (var handle in handles)
                {
                    if (usedIds.Contains(handle.Id))
                        continue;

                    newClassList.Add(handle.GetValue());
                    usedIds.Add(handle.Id);
                }
            }

            return newClassList.ToArray();
        }

        private string GetTypeStringFromProperty(PropertyInfo propInfo, GenericUnknownStruct.BaseClassEntry cls)
        {
            var (typeStr, _) = GetTypeStringFromProperty(propInfo, propInfo.GetValue(cls));
            return typeStr;
        }

        private (string, string) GetTypeStringFromType(Type type)
        {
            if (type.IsEnum)
            {
                var enumName = MappingHelper.DumpedEnums.GetKey(type);
                if (enumName != null)
                    return (enumName, enumName);
            }

            var className = MappingHelper.DumpedClasses.GetKey(type);
            if (className != null)
                return (className, className);

            var underlyingType = Nullable.GetUnderlyingType(type);
            if (underlyingType != null)
                return (underlyingType.Name, underlyingType.Name);

            if (typeof(IHandle).IsAssignableFrom(type))
            {
                var genericType = type.GetGenericArguments()[0];
                var attrName = GetRealName(genericType);
                if (attrName != null)
                {
                    return ("handle:" + attrName, attrName);
                }

                return ("handle:" + genericType.Name, genericType.Name);
            }

            var typeName = MappingHelper.BasicTypes.GetKey(type);
            if (typeName != null)
                return (typeName, typeName);

            throw new Exception();
        }

        private (string, string) GetTypeStringFromProperty(PropertyInfo propInfo, object propValue)
        {
            if (propInfo.DeclaringType == null)
                throw new Exception();

            if (MappingHelper.RealTypeCache.TryGetValue($"{propInfo.DeclaringType.Name}.{propInfo.Name}", out var attr))
            {
                var typeStr = attr.Type;

                if (attr.IsHandle && !typeStr.StartsWith("handle:"))
                    typeStr = "handle:" + typeStr;

                if (attr.IsFixedArray && !typeStr.StartsWith("["))
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
                var (typeString, baseType) = GetTypeStringFromType(elementType);

                return ("array:" + typeString, baseType);
            }

            return GetTypeStringFromType(propInfo.PropertyType);
        }

        private bool CanBeIgnored(PropertyInfo propInfo, object propValue)
        {
            if (MappingHelper.IgnoredCache.Contains(propInfo))
                return true;

            return MappingHelper.GetPropertyHelper(propInfo).IsDefault(propValue);
        }

        private void WriteValueFromPropValue(BinaryWriter writer, object propValue)
        {
            if (propValue is GenericUnknownStruct.BaseClassEntry subCls)
            {
                writer.Write(GenerateDataFromMappedFields(subCls));
            }
            else if (propValue is IHandle handle)
            {
                writer.Write(handle.Id);
            }
            else if (propValue is CName cname)
            {
                writer.Write((ushort)_stringList.IndexOf(cname));
            }
            else if (propValue is NodeRef nodeRef)
            {
                var valBytes = Encoding.ASCII.GetBytes(nodeRef);

                writer.Write((ushort)valBytes.Length);
                writer.Write(valBytes);
            }
            else if (propValue.GetType().IsEnum)
            {
                WriteValue(writer, (ushort)_stringList.IndexOf(propValue.ToString()));
            }
            else
            {
                WriteValue(writer, propValue);
            }
        }

        private void GenerateStringListFromMappedFields(GenericUnknownStruct.BaseClassEntry cls, ref HashSet<string> strings)
        {
            var props = new List<KeyValuePair<PropertyInfo, object>>();

            foreach (var prop in cls.GetType().GetProperties())
            {
                var propValue = MappingHelper.GetPropertyHelper(prop).Get(cls);
                if (CanBeIgnored(prop, propValue))
                    continue;

                props.Add(new KeyValuePair<PropertyInfo, object>(prop, propValue));
            }

            props = props
                .GroupBy(p => p.Key.DeclaringType)
                .Reverse()
                .SelectMany(g => g)
                .ToList();

            for (int i = 0; i < props.Count; i++)
            {
                var prop = props[i].Key;
                var propValue = props[i].Value;
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

        private void GetStringValueFromPropValue(object propValue, string baseType, ref HashSet<string> strings)
        {
            if (propValue is GenericUnknownStruct.BaseClassEntry cls)
            {
                GenerateStringListFromMappedFields(cls, ref strings);
            }
            else if (propValue is CName cname)
            {
                strings.Add(cname);
            }
            else if (propValue is string)
            {
                var enumName = MappingHelper.DumpedEnums.GetValue(baseType);
                if (enumName != null)
                    strings.Add((string)propValue);
            }
            else if (propValue.GetType().IsEnum)
            {
                strings.Add(propValue.ToString());
            }
        }

        private byte[] GenerateDataFromMappedFields(GenericUnknownStruct.BaseClassEntry cls)
        {
            byte[] result;

            using (var stream = new MemoryStream())
            {
                using (var writer = new BinaryWriter(stream, Encoding.ASCII))
                {
                    var props = new List<KeyValuePair<PropertyInfo, object>>();

                    foreach (var prop in cls.GetType().GetProperties())
                    {
                        var propValue = MappingHelper.GetPropertyHelper(prop).Get(cls);
                        if (CanBeIgnored(prop, propValue))
                            continue;

                        props.Add(new KeyValuePair<PropertyInfo, object>(prop, propValue));
                    }

                    props = props
                        .GroupBy(p => p.Key.DeclaringType)
                        .Reverse()
                        .SelectMany(g => g)
                        .ToList();

                    writer.Write((ushort)props.Count);
                    foreach (var prop in props)
                    {
                        writer.Write((ushort)_stringList.IndexOf(GetRealName(prop.Key)));
                        var typeString = GetTypeStringFromProperty(prop.Key, cls);
                        writer.Write((ushort)_stringList.IndexOf(typeString));
                        writer.Write(new byte[4]); // offset
                    }

                    for (int i = 0; i < props.Count; i++)
                    {
                        var pos = writer.BaseStream.Position;
                        writer.BaseStream.Position = 6 + (i * 8);
                        writer.Write((uint)pos);
                        writer.BaseStream.Position = pos;

                        if (props[i].Key.PropertyType.IsArray)
                        {
                            var arr = (IList)props[i].Value;

                            writer.Write(arr.Count);
                            foreach (var val in arr)
                            {
                                WriteValueFromPropValue(writer, val);
                            }
                        }
                        else
                        {
                            WriteValueFromPropValue(writer, props[i].Value);
                        }
                    }
                }

                result = stream.ToArray();
            }

            return result;
        }

        #endregion

        #region Unmapped writing

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

                if (field.Value is IList)
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

        private byte[] GenerateDataFromUnmappedFields(GenericUnknownStruct.BaseGenericField[] fields)
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
                            var valStr = (NodeRef)field.Value;

                            var valBytes = Encoding.ASCII.GetBytes(valStr);
                            writer.Write((ushort)valBytes.Length);
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
                                        var valStr = (NodeRef)t1;
                                        var valBytes = Encoding.ASCII.GetBytes(valStr);

                                        writer.Write((ushort)valBytes.Length);
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

        #endregion
        
        private class FieldInfo
        {
            public string Name { get; set; }
            public string Type { get; set; }
            public uint Offset { get; set; }
        }
    }
}