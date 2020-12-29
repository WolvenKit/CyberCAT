using System.Collections.Generic;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    public class GenericUnknownStruct
    {
        public class ClassEntry
        {
            public string Name { get; set; }
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
            public string Type { get; set; }
            public uint Offset { get; set; }
            public object Value { get; set; }
        }

        public uint TotalLength { get; set; }
        public byte[] Unknown1 { get; set; }
        public uint Unknown2 { get; set; }
        public byte[] Unknown3 { get; set; }
        public byte[] Unknown4 { get; set; }
        public List<ClassEntry> ClassList { get; set; }

        public GenericUnknownStruct()
        {
            ClassList = new List<ClassEntry>();
        }
    }
}