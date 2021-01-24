using System.Collections.Generic;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    public class Choices : NodeRepresentation
    {
        public List<Entry1> Unknown1 { get; set; }

        public Choices()
        {
            Unknown1 = new List<Entry1>();
        }

        public class Entry1
        {
            public ulong Unknown1 { get; set; }
            public List<Entry2> Unknown2 { get; set; }

            public Entry1()
            {
                Unknown2 = new List<Entry2>();
            }
        }

        public class Entry2
        {
            public uint Unknown1 { get; set; }
            public uint Unknown2 { get; set; }
            public uint Unknown3 { get; set; }
        }
    }
}