using System;
using System.IO;
using System.Linq;
using System.Text;

namespace CyberCAT.Core
{
    internal static class ExtensionMethods
    {
        public static string ReadString(this BinaryReader reader, int count)
        {
            return new string(reader.ReadChars(count));
        }

        public static string ReadPackedString(this BinaryReader reader)
        {
            var length = reader.ReadPackedInt();
            return reader.ReadString(-length);
        }

        public static int WritePackedString(this BinaryWriter writer, string s)
        {
            writer.WritePackedInt(-s.Length);
            writer.Write(Encoding.ASCII.GetBytes(s));
            return 1 + Encoding.ASCII.GetBytes(s).Length;
        }

        public static void Skip(this BinaryReader reader, int count)
        {
            reader.BaseStream.Position += count;
        }

        public static long SeekMagicBytes(this Stream stream, string identifier)
        {
            return stream.SeekMagicBytes(Encoding.ASCII.GetBytes(identifier));
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

        // a 1:1 copy of PixelRicks cpp implementation, could probably be better...
        public static int ReadPackedInt(this BinaryReader reader)
        {
            var a = reader.ReadSByte();
            int ret = a & 0x3F;
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

        public static void WritePackedInt(this BinaryWriter writer, int value)
        {
            var packed = new byte[5];
            var cnt = 1;
            var tmp = Math.Abs(value);
            if (value < 0)
                packed[0] |= 0x80;
            packed[0] |= (byte)(tmp & 0x3F);
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
                        }
                    }
                }
            }

            writer.Write(packed, 0, cnt);
        }
    }
}
