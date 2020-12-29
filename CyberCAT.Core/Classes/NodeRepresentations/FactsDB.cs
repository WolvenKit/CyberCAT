using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    [JsonObject]
    public class FactsDB
    {
        public byte FactsTableCount { get; set; }

        public byte[] TrailingBytes { get; set; }
    }
}
