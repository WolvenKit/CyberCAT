using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Core.Classes.Parsers
{
    class ParserUtils
    {
        public static string ReadString(BinaryReader reader, out Flags flags)
        {
            flags = new Flags(reader.ReadByte());
            return reader.ReadString(flags.Length);
        }

        public static string ReadString(BinaryReader reader)
        {
            var flags = new Flags(reader.ReadByte());
            return reader.ReadString(flags.Length);
        }
    }
}
