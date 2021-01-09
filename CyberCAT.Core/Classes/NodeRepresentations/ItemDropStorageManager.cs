using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    [JsonObject]
    public class ItemDropStorageManager : NodeRepresentation
    {
        public uint NumberOfItemDropStorages { get; set; }
        public ItemDropStorage[] ItemDropStorages { get; set; }
        public byte[] TrailingBytes { get; set; }
    }
}
