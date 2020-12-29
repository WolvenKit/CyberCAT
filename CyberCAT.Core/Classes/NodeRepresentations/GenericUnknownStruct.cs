using System.Collections.Generic;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    public class GenericUnknownStruct
    {
        public uint TotalLength { get; set; }
        public byte[] Unknown1 { get; set; }
        public uint Unknown2 { get; set; }
        public byte[] Unknown3 { get; set; }
        public byte[] Unknown4 { get; set; }
        public List<string> StringList { get; set; }
        public List<KeyValuePair<uint, uint>> PointerList { get; set; }
        public byte[] TrailingBytes { get; set; }

        public GenericUnknownStruct()
        {
            StringList = new List<string>();
            PointerList = new List<KeyValuePair<uint, uint>>();
        }
    }
}