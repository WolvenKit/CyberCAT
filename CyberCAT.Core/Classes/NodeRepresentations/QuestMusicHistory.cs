using System.Collections.Generic;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    public class QuestMusicHistory : NodeRepresentation
    {
        public List<Entry> Entries { get; set; }

        public QuestMusicHistory()
        {
            Entries = new List<Entry>();
        }

        public class Entry
        {
            public TweakDbId Unknown1 { get; set; }
            public ulong Unknown2 { get; set; }
            public ulong Unknown3 { get; set; }
            public ushort Unknown4 { get; set; }
            public ushort Unknown5 { get; set; }
            public uint Unknown6 { get; set; }
        }
    }
}