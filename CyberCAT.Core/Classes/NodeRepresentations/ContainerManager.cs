using System.Collections.Generic;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    public class ContainerManager : NodeRepresentation
    {
        public List<ContainerManagerEntry> ContainerManagerEntries { get; set; }

        public ContainerManager()
        {
            ContainerManagerEntries = new List<ContainerManagerEntry>();
        }

        public class ContainerManagerEntry
        {
            public ulong Unk_Hash { get; set; }
            public short Unknown2 { get; set; }
        }
    }
}