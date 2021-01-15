using System.Collections.Generic;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    public class CustomArray : NodeRepresentation
    {
        public List<ushort> Unknown { get; set; }

        public CustomArray()
        {
            Unknown = new List<ushort>();
        }
    }
}