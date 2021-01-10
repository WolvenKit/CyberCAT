using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    public class GenericUnknownStruct : NodeRepresentation
    {
        public uint TotalLength { get; set; }
        public byte[] Unknown1 { get; set; }
        public uint Unknown2 { get; set; }
        public byte[] Unknown3 { get; set; }

        // list of FNV1A64 hashes of the classes
        public ulong[] CNameHashes1 { get; set; }
        public BaseClassEntry[] ClassList { get; set; }
        public ulong[] CNameHashes2 { get; set; }
        internal List<IHandle> Handles { get; set; }

        public GenericUnknownStruct()
        {
            Handles = new List<IHandle>();
        }

        public Handle<T> CreateHandle<T>(T data) where T : BaseClassEntry
        {
            var maxId = Handles.Max(h => h.GetId());
            var result = new Handle<T>(maxId + 1, data);
            Handles.Add(result);
            return result;
        }

        public void RemoveHandle(int id)
        {
            for (int i = Handles.Count - 1; i >= 0; i--)
            {
                if (Handles[i].GetId() == id)
                    Handles.Remove(Handles[i]);
            }
        }

        public void RemoveHandle(BaseClassEntry obj)
        {
            for (int i = Handles.Count - 1; i >= 0; i--)
            {
                if (Handles[i].GetValue() == obj)
                    Handles.Remove(Handles[i]);
            }
        }

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