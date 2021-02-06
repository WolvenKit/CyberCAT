using System;

namespace CyberCAT.Extra.Utils
{
    public static class HashGenerator
    {
        private static uint[] _crc32checksumTable;

        static HashGenerator()
        {
            _crc32checksumTable = new uint[0x100];

            for (uint index = 0; index < 0x100; ++index)
            {
                uint item = index;
                for (int bit = 0; bit < 8; ++bit)
                    item = ((item & 1) != 0) ? (0xEDB88320 ^ (item >> 1)) : (item >> 1);
                _crc32checksumTable[index] = item;
            }
        }

        public static byte[] CalcCRC32(string str)
        {
            var data = System.Text.Encoding.ASCII.GetBytes(str);
            uint result = 0xFFFFFFFF;

            foreach (var b in data)
            {
                result = _crc32checksumTable[(result & 0xFF) ^ b] ^ (result >> 8);
            }

            byte[] hash = BitConverter.GetBytes(~result);
            Array.Reverse(hash);
            return hash;
        }

        public static ulong CalcFNV1A64(string str)
        {
            var bytes = System.Text.Encoding.ASCII.GetBytes(str);
            var result = 14695981039346656037;

            foreach (var b in bytes)
            {
                result ^= b;
                result *= 0x100000001b3;
            }

            return result;
        }
    }
}