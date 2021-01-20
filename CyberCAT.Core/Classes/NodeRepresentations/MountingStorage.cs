using System.Collections.Generic;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    // TODO: Could be 3 List, but also could be Dict with Key and Value as Entry with 2 fields
    // first uint is counter
    public class MountingStorage : NodeRepresentation
    {
        public List<ulong> Unknown1 { get; set; }
        public List<ulong> Unknown2 { get; set; }
        public List<ulong> Unknown3 { get; set; }
    }
}