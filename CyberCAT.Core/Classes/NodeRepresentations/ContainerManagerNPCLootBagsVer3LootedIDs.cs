using System.Collections.Generic;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    public class ContainerManagerNPCLootBagsVer3LootedIDs : NodeRepresentation
    {
        public List<ulong> EntityIds { get; set; }


        public ContainerManagerNPCLootBagsVer3LootedIDs()
        {
            EntityIds = new List<ulong>();
        }
    }
}