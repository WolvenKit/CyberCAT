using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Core.Classes
{
    public static class Extensions
    {
        public static long SeekMagicBytes(this Stream stream, string identifier)
        {
            return stream.SeekMagicBytes(System.Text.Encoding.ASCII.GetBytes(identifier));
        }

        public static long SeekMagicBytes(this Stream stream, byte[] magicBytes)
        {
            long oldPostion = stream.Position;
            long currentPosition;
            var buffer = new byte[magicBytes.Length - 1];

            stream.Position = 0;
            while ((currentPosition = stream.Position) < stream.Length)
            {
                if (stream.ReadByte() != magicBytes[0])
                {
                    continue;
                }

                var tmpPos = stream.Position;
                if (stream.Read(buffer, 0, buffer.Length) < buffer.Length)
                {
                    stream.Position = tmpPos;
                    continue;
                }

                if (!buffer.SequenceEqual(magicBytes.Skip(1)))
                {
                    stream.Position = tmpPos;
                    continue;
                }

                stream.Position -= magicBytes.Length;
                return currentPosition;
            }

            stream.Position = oldPostion;
            return -1;
        }

        public static int ReadInt24(this BinaryReader reader)
        {
            var buffer = new byte[4];
            reader.Read(buffer, 0, 3);
            return BitConverter.ToInt32(buffer, 0);
        }

        public static void WriteInt24(this BinaryWriter writer, int val)
        {
            var bytes = BitConverter.GetBytes(val);
            writer.Write(bytes, 0, 3);
        }

        public static uint ReadUInt24(this BinaryReader reader)
        {
            var buffer = new byte[4];
            reader.Read(buffer, 0, 3);
            return BitConverter.ToUInt32(buffer, 0);
        }

        public static void WriteUInt24(this BinaryWriter writer, uint val)
        {
            var bytes = BitConverter.GetBytes(val);
            writer.Write(bytes, 0, 3);
        }

        //TODO use dll probably too tired right now too add correctly
        public static void WriteBit6(this BinaryWriter stream, int c)
        {
            if (c == 0)
            {
                stream.Write((byte)128);
                return;
            }

            //var str2 = Convert.ToString(c, 2);

            var bytes = new List<int>();
            var left = c;

            for (var i = 0; (left > 0); i++)
            {
                if (i == 0)
                {
                    bytes.Add(left & 63);
                    left = left >> 6;
                }
                else
                {
                    bytes.Add(left & 255);
                    left = left >> 7;
                }
            }


            for (var i = 0; i < bytes.Count; i++)
            {
                var last = (i == bytes.Count - 1);
                var cleft = (bytes.Count - 1) - i;

                if (!last)
                {
                    if (cleft >= 1 && i >= 1)
                    {
                        bytes[i] = bytes[i] | 128;
                    }
                    else if (bytes[i] < 64)
                    {
                        bytes[i] = bytes[i] | 64;
                    }
                    else
                    {
                        bytes[i] = bytes[i] | 128;
                    }
                }

                if (bytes[i] == 128)
                {
                    throw new Exception("No clue what to do here, still need to think about it... :p");
                }

                stream.Write((byte)bytes[i]);
            }
        }
    }
}
