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

        public List<FactEntry> FactEntries { get; set; }

        public FactsTable()
        {
            FactEntries = new List<FactEntry>();
        }
    }
}