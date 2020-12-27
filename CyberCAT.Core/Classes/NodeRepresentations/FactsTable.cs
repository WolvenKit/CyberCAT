using System.Collections.Generic;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    public class FactsTable
    {
        public class FactEntry
        {
            public uint Hash { get; set; }

            public uint Value { get; set; }

            public override string ToString()
            {
                return FactResolver.GetName(Hash);
            }
        }

        // seem to be size related, but if there are more than 0xFF items, it doesn't add up...
        public byte[] Unknown1 { get; set; }

        public List<FactEntry> FactEntries { get; set; }

        public FactsTable()
        {
            FactEntries = new List<FactEntry>();
        }
    }
}