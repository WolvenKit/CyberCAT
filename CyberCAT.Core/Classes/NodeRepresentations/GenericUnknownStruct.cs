using System;
using System.Runtime.Serialization;
using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    public class GenericUnknownStruct : NodeRepresentation
    {
        public uint TotalLength { get; set; }
        public byte[] Unknown1 { get; set; }
        public uint Unknown2 { get; set; }
        public byte[] Unknown3 { get; set; }
        public ulong[] CNameHashes1 { get; set; }
        public BaseClassEntry[] ClassList { get; set; }
        public ulong[] CNameHashes2 { get; set; }

        public class BaseClassEntry
        {
            public override string ToString()
            {
                return GetType().Name;
            }
        }

        public class ClassEntry : BaseClassEntry
        {
            public string Name { get; set; }
            public BaseGenericField[] Fields { get; set; }

            public override string ToString()
            {
                return Name;
            }
        }

        public class BaseGenericField
        {
            public string Name { get; set; }
            public string Type { get; set; }
        }

        public class GenericField<T> : BaseGenericField
        {
            public GenericField(object val)
            {
                Value = (T)Convert.ChangeType(val, typeof(T));
            }

            public T Value { get; set; }
        }
    }
}