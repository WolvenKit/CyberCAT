using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    public class CharacterCustomizationAppearances
    {
        public class HashValueEntry
        {
            public ulong Hash { get; set; }
            public string FirstString { get; set; }
            public string SecondString { get; set; }
            public byte[] TrailingBytes { get; set; }

            public override string ToString()
            {
                return $"{FirstString} / {SecondString}";
            }
        }

        public class ValueEntry
        {
            public string FirstString { get; set; }
            public string SecondString { get; set; }
            public byte[] TrailingBytes { get; set; }

            public override string ToString()
            {
                return $"{FirstString} / {SecondString}";
            }
        }

        public byte[] UnknownFirstBytes { get; set; }

        /// <summary>
        /// Bytes that are not yet parsed into representation
        /// </summary>
        public byte[] TrailingBytes { get; set; }
        public List<HashValueEntry> ThirdPerson { get; set; }
        public List<ValueEntry> AdditionalThirdPerson { get; set; }
        public List<HashValueEntry> FirstPerson { get; set; }

        public CharacterCustomizationAppearances()
        {
            ThirdPerson = new List<HashValueEntry>();
            AdditionalThirdPerson = new List<ValueEntry>();
            FirstPerson = new List<HashValueEntry>();
        }
       
    }
}
