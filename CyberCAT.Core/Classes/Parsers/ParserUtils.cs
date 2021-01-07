using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CyberCAT.Core.Classes.Interfaces;

namespace CyberCAT.Core.Classes.Parsers
{
    class ParserUtils
    {
        public static string ReadString(BinaryReader reader)
        {
            var length = ReadPackedLong(reader);
            return reader.ReadString((int)-length);
        }

        public static int WriteString(BinaryWriter writer, string s)
        {
            WritePackedLong(writer, -s.Length);
            writer.Write(Encoding.ASCII.GetBytes(s));
            return 1 + Encoding.ASCII.GetBytes(s).Length;
        }

        public static void ParseChildren(IEnumerable<NodeEntry> children, BinaryReader reader, List<INodeParser> parsers)
        {
            foreach (var node in children)
            {
                reader.BaseStream.Position = node.Offset;
                var parser = parsers.FirstOrDefault(p => p.ParsableNodeName == node.Name);
                if (parser == null)
                {
                    parser = new DefaultParser();
                }
                node.Value = parser.Read(node, reader, parsers);
                node.Parser = parser;
            }
        }

        // a 1:1 copy of PixelRicks cpp implementation, could probably be better...
        public static long ReadPackedLong(BinaryReader reader)
        {
            var a = reader.ReadSByte();
            long ret = a & 0x3F;
            var sign = (a & 0x80) == 0x00;

            if ((a & 0x40) == 0x40)
            {
                a = reader.ReadSByte();
                ret |= (a & 0x7F) << 6;

                if (a < 0)
                {
                    a = reader.ReadSByte();
                    ret |= (a & 0x7F) << 13;

                    if (a < 0)
                    {
                        a = reader.ReadSByte();
                        ret |= (a & 0x7F) << 20;

                        if (a < 0)
                        {
                            a = reader.ReadSByte();
                            ret |= (a & 0x7F) << 27;
                        }
                    }
                }
            }

            return sign ? ret : -ret;
        }

        public static void WritePackedLong(BinaryWriter writer, long value)
        {
            var packed = new byte[5];
            var cnt = 1;
            var tmp = Math.Abs(value);
            if (value < 0)
                packed[0] |= 0x80;
            packed[0] |= (byte) (tmp & 0x3F);
            tmp >>= 6;
            if (tmp != 0)
            {
                packed[0] |= 0x40;
                cnt++;
                packed[1] |= (byte)(tmp & 0x7F);
                tmp >>= 7;
                if (tmp != 0)
                {
                    packed[1] |= 0x80;
                    cnt++;
                    packed[2] |= (byte)(tmp & 0x7F);
                    tmp >>= 7;
                    if (tmp != 0)
                    {
                        packed[2] |= 0x80;
                        cnt++;
                        packed[3] |= (byte)(tmp & 0x7F);
                        tmp >>= 7;
                        if (tmp != 0)
                        {
                            packed[3] |= 0x80;
                            cnt++;
                            packed[4] |= (byte)(tmp & 0x7F);
                            tmp >>= 7;
                        }
                    }
                }
            }

            writer.Write(packed, 0, cnt);
        }
    }
}
