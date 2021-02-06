using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Extra.Types.Primitive;
using CyberCAT.Extra.Utils;

namespace CyberCAT.Extra
{
    public class TweakDbParser
    {
        private static readonly Dictionary<string, ReadValueDelegate> _valueReaders = new Dictionary<string, ReadValueDelegate>();
        private Dictionary<ulong, string> _types;
        private Dictionary<TweakDBID, string> _hashMap;

        public Dictionary<string, object> FlatDict { get; }
        public Dictionary<string, object> RecordDict { get; }
        public Dictionary<string, List<string>> QueryDict { get; }
        public Dictionary<string, byte> GroupTagDict { get; }


        static TweakDbParser()
        {
            _valueReaders.Add("String", ReadString);
            _valueReaders.Add("Quaternion", ReadQuaternion);
            _valueReaders.Add("Bool", ReadBool);
            _valueReaders.Add("CName", ReadCName);
            _valueReaders.Add("Int32", ReadInt32);
            _valueReaders.Add("raRef:CResource", ReadRaRefCResource);
            _valueReaders.Add("Vector2", ReadVector2);
            _valueReaders.Add("Float", ReadFloat);
            _valueReaders.Add("Vector3", ReadVector3);
            _valueReaders.Add("TweakDBID", ReadTweakDBID);
            _valueReaders.Add("EulerAngles", ReadEulerAngles);
            _valueReaders.Add("gamedataLocKeyWrapper", ReadGamedataLocKeyWrapper);
        }

        private delegate object ReadValueDelegate(BinaryReader reader);

        public TweakDbParser()
        {
            _types = new Dictionary<ulong, string>();
            _hashMap = new Dictionary<TweakDBID, string>();

            FlatDict = new Dictionary<string, object>();
            RecordDict = new Dictionary<string, object>();
            QueryDict = new Dictionary<string, List<string>>();
            GroupTagDict = new Dictionary<string, byte>();
        }

        public void AddTypes(string filePath)
        {
            if (string.IsNullOrEmpty(filePath)) throw new ArgumentNullException(nameof(filePath));
            if (!File.Exists(filePath)) throw new Exception();

            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var splitted = line.Split('\t');
                _types.Add(HashGenerator.CalcFNV1A64(splitted[1]), splitted[1]);
            }
        }

        private TweakDBID GetTweakDBID(string str)
        {
            var buffer1 = new byte[8];
            var buffer2 = HashGenerator.CalcCRC32(str);
            Array.Reverse(buffer2);
            Array.Copy(buffer2, 0, buffer1, 0, buffer2.Length);
            buffer1[4] = (byte)str.Length;

            return BitConverter.ToUInt64(buffer1, 0);
        }

        public void AddStrings(string filePath)
        {
            if (string.IsNullOrEmpty(filePath)) throw new ArgumentNullException(nameof(filePath));
            if (!File.Exists(filePath)) throw new Exception();

            var data = File.ReadAllBytes(filePath);
            using (var ms = new MemoryStream(data))
            {
                using (var reader = new BinaryReader(ms, Encoding.ASCII))
                {
                    var magic = reader.ReadUInt32();
                    var unk1 = reader.ReadUInt32();
                    var unk2 = reader.ReadUInt32();
                    var unk3 = reader.ReadUInt32();
                    var queriesCount = reader.ReadUInt32();

                    // flat
                    for (int i = 0; i < unk2; i++)
                    {
                        var str = reader.ReadPackedString();
                        _hashMap.Add(GetTweakDBID(str), str);
                    }

                    // record
                    for (int i = 0; i < unk3; i++)
                    {
                        var str = reader.ReadPackedString();
                        _hashMap.Add(GetTweakDBID(str), str);
                    }

                    // queries
                    for (int i = 0; i < queriesCount; i++)
                    {
                        var str = reader.ReadPackedString();

                        var tweakDBID = GetTweakDBID(str);
                        if (_hashMap.ContainsKey(tweakDBID))
                            continue;

                        _hashMap.Add(tweakDBID, str);
                    }
                }
            }
        }

        public void Read(string filePath)
        {
            if (string.IsNullOrEmpty(filePath)) throw new ArgumentNullException(nameof(filePath));
            if (!File.Exists(filePath)) throw new Exception();

            var data = File.ReadAllBytes(filePath);
            using (var ms = new MemoryStream(data))
            {
                using (var reader = new BinaryReader(ms, Encoding.ASCII, true))
                {
                    var startMagic = reader.ReadBytes(4);
                    var blobVersion = reader.ReadInt32();
                    var parserVersion = reader.ReadInt32();
                    var recordsChecksum = reader.ReadInt32();
                    var flatOffset = reader.ReadInt32();
                    var recordsOffset = reader.ReadInt32();
                    var queriesOffset = reader.ReadInt32();
                    var groupTagsOffset = reader.ReadInt32();

                    var counter = reader.ReadInt32();
                    var flatIndexList = new Index[counter];
                    for (int i = 0; i < counter; i++)
                    {
                        var type = _types[reader.ReadUInt64()];

                        var isArray = type.StartsWith("array:");
                        if (isArray)
                            type = type.Substring("array:".Length);

                        flatIndexList[i] = new Index
                        {
                            Type = type,
                            IsArray = isArray,
                            Size = reader.ReadInt32()
                        };
                    }

                    foreach (var flatIndex in flatIndexList)
                    {
                        ReadFlatPair(reader, flatIndex);
                    }

                    counter = reader.ReadInt32();
                    for (int i = 0; i < counter; i++)
                    {
                        RecordDict.Add(GetName(reader.ReadUInt64()), reader.ReadUInt32());
                    }

                    counter = reader.ReadInt32();
                    for (int i = 0; i < counter; i++)
                    {
                        var tweakDBIDName = GetName(reader.ReadUInt64());
                        QueryDict.Add(tweakDBIDName, new List<string>());

                        var subCounter = reader.ReadInt32();
                        for (int j = 0; j < subCounter; j++)
                        {
                            QueryDict[tweakDBIDName].Add(GetName(reader.ReadUInt64()));
                        }
                    }

                    counter = reader.ReadInt32();
                    for (int i = 0; i < counter; i++)
                    {
                        GroupTagDict.Add(GetName(reader.ReadUInt64()), reader.ReadByte());
                    }
                }
            }
        }

        private void ReadFlatPair(BinaryReader reader, Index index)
        {
            var valueList = new List<object>();

            if (!_valueReaders.ContainsKey(index.Type))
                throw new NotImplementedException();

            var length = reader.ReadInt32();
            for (int i = 0; i < length; i++)
            {
                if (index.IsArray)
                {
                    var subValueList = new List<object>();
                    var subLength = reader.ReadInt32();
                    for (int j = 0; j < subLength; j++)
                    {
                        subValueList.Add(_valueReaders[index.Type](reader));
                    }
                    valueList.Add(subValueList.ToArray());
                }
                else
                {
                    valueList.Add(_valueReaders[index.Type](reader));
                }
            }

            length = reader.ReadInt32();
            for (int i = 0; i < length; i++)
            {
                FlatDict.Add(GetName(reader.ReadUInt64()), valueList[reader.ReadInt32()]);
            }
        }

        private string GetName(TweakDBID tweakDBID)
        {
            if (_hashMap.ContainsKey(tweakDBID))
                return _hashMap[tweakDBID];
            return tweakDBID.Value.ToString();
        }

        #region Value readers

        private static object ReadStruct(BinaryReader reader, Type type)
        {
            var result = Activator.CreateInstance(type);

            reader.ReadByte();
            foreach (var fieldInfo in type.GetFields())
            {
                if (reader.ReadPackedString() != fieldInfo.Name)
                    throw new Exception();

                reader.ReadPackedString(); // valueType
                reader.ReadInt32(); // 8

                fieldInfo.SetValue(result, reader.ReadSingle());
            }
            reader.ReadPackedString(); // None

            return result;
        }

        private static object ReadQuaternion(BinaryReader reader)
        {
            return ReadStruct(reader, typeof(Quaternion));
        }

        private static object ReadString(BinaryReader reader)
        {
            return reader.ReadPackedString();
        }

        private static object ReadBool(BinaryReader reader)
        {
            return reader.ReadBoolean();
        }

        private static object ReadCName(BinaryReader reader)
        {
            return (CName) reader.ReadPackedString();
        }

        private static object ReadInt32(BinaryReader reader)
        {
            return reader.ReadInt32();
        }

        private static object ReadRaRefCResource(BinaryReader reader)
        {
            return reader.ReadUInt64();
        }

        private static object ReadVector2(BinaryReader reader)
        {
            return ReadStruct(reader, typeof(Vector2));
        }

        private static object ReadFloat(BinaryReader reader)
        {
            return reader.ReadSingle();
        }

        private static object ReadVector3(BinaryReader reader)
        {
            return ReadStruct(reader, typeof(Vector3));
        }

        private static object ReadTweakDBID(BinaryReader reader)
        {
            return (TweakDBID) reader.ReadUInt64();
        }

        private static object ReadEulerAngles(BinaryReader reader)
        {
            return ReadStruct(reader, typeof(EulerAngles));
        }

        private static object ReadGamedataLocKeyWrapper(BinaryReader reader)
        {
            return reader.ReadUInt64();
        }

        #endregion

        public class Index
        {
            public string Type { get; set; }
            public bool IsArray { get; set; }
            public int Size { get; set; }
        }
    }
}