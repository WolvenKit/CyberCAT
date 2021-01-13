using System.Collections.Generic;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    public class JournalManager : NodeRepresentation
    {
        public List<JournalManagerEntry> Entries { get; set; }
        public uint Unk1_TrackedQuestPath { get; set; }
        public byte[] TrailingBytes { get; set; }

        public JournalManager()
        {
            Entries = new List<JournalManagerEntry>();
        }

        public class JournalManagerEntry
        {
            public uint Unk1_PathHash { get; set; }
            public uint Unk2_State { get; set; }
            public uint Unknown3 { get; set; }
            public uint Unknown4 { get; set; }
        }
    }
}