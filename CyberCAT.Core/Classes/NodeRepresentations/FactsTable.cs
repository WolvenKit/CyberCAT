using Newtonsoft.Json;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    [JsonObject]
    public class FactsTable
    {
        [JsonObject]
        public class FactEntry
        {
            public uint Hash { get; set; }
            public string FactName => FactResolver.GetName(Hash);
            public uint Value { get; set; }

            public override string ToString()
            {
                return $"{FactName}";
            }
        }

        public FactEntry[] FactEntries { get; set; }
    }
}