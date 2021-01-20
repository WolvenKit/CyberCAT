using System.Collections.Generic;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    public class JournalManager : NodeRepresentation
    {
        public List<Entry1> Entries { get; set; }
        public uint Unk1_TrackedQuestPath { get; set; }
        // could be wrong, strings with length 2?
        public List<ulong> Unknown2 { get; set; }
        public List<Entry2> Unknown3 { get; set; }
        public byte[] TrailingBytes { get; set; }

        public JournalManager()
        {
            Entries = new List<Entry1>();
            Unknown2 = new List<ulong>();
            Unknown3 = new List<Entry2>();
        }

        public class Entry1
        {
            public uint Unk1_PathHash { get; set; }
            public uint Unk2_State { get; set; }
            public uint Unknown3 { get; set; }
            public uint Unknown4 { get; set; }
        }

        public class Entry2
        {
            public uint Unknown1 { get; set; }
            public uint Unknown2 { get; set; }
            public uint Unknown3 { get; set; }
            public uint Unknown4 { get; set; }
        }
    }
}