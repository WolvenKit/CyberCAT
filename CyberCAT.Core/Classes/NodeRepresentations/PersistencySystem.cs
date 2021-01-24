using System.Collections.Generic;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    public class PersistencySystem : NodeRepresentation
    {
        public List<uint> Unk_HashList { get; set; }

        public PersistencySystem()
        {
            Unk_HashList = new List<uint>();
        }
    }
}