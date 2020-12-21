using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Core.Classes
{
    public class Flags
    {
        public bool HasUnknownFlag { get; set; }
        public int Length { get; set; }
        public Flags()
        {

        }
        public Flags(BinaryReader reader)
        {
            byte flags = reader.ReadByte();
            Length = (byte)(flags & 0x3F);
            HasUnknownFlag = (flags & 0x80) != 0; // don't know purpose yet
            if ((flags & 0x40) != 0)
            {
                int shift = -1;
                do
                {
                    shift += 7;
                    flags = reader.ReadByte();
                    Length |= ((flags & 0x7F) << shift);
                }
                while ((flags & 0x80) != 0);
            }
        }
        /// <summary>
        /// Gets the flag for one byte
        /// </summary>
        /// <param name="flagbyte"></param>
        public Flags(byte flagbyte)
        {
            Length = (byte)(flagbyte & 0x3F);
            HasUnknownFlag = (flagbyte & 0x80) != 0; // don't know purpose yet
        }
    }
}
