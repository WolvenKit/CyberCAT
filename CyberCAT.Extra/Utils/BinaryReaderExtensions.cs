using System.IO;

namespace CyberCAT.Extra.Utils
{
    internal static class BinaryReaderExtensions
    {
        public static string ReadPackedString(this BinaryReader reader)
        {
            var length = -reader.ReadPackedInt();
            return new string(reader.ReadChars(length));
        }

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
    }
}