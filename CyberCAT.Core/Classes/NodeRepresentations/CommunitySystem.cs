using System.Collections.Generic;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    public class CommunitySystem : NodeRepresentation
    {
        public List<ulong> Unk_HashList { get; set; }
        public byte[] TrailingBytes { get; set; }

        public CommunitySystem()
        {
            Unk_HashList = new List<ulong>();
        }
    }
}