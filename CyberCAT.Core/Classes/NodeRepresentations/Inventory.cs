using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    public class Inventory
    {
        public byte[] HeaderBytes { get; set; }
        public uint NumberOfItems { get; set; }

        public ItemData.NextItemEntry NextItem { get; set; }

        /// <summary>
        /// Bytes that are not yet parsed into representation
        /// </summary>
        public byte[] TrailingBytes { get; set; }
    }
}
