using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Core.Classes
{
    public class TweakDbId
    {
        public ulong Raw64
        {
            get
            {
                var idBytes = BitConverter.GetBytes(Id);

                var rawBytes = new byte[8];
                rawBytes[7] = Padding[2];
                rawBytes[6] = Padding[1];
                rawBytes[5] = Padding[0];
                rawBytes[4] = Length;
                rawBytes[3] = idBytes[3];
                rawBytes[2] = idBytes[2];
                rawBytes[1] = idBytes[1];
                rawBytes[0] = idBytes[0];

                return BitConverter.ToUInt64(rawBytes, 0);
            }
            set
            {
                var rawBytes = BitConverter.GetBytes(value);
                var idBytes = new byte[4];
                idBytes[0] = rawBytes[0];
                idBytes[1] = rawBytes[1];
                idBytes[2] = rawBytes[2];
                idBytes[3] = rawBytes[3];
                Id = BitConverter.ToUInt32(idBytes, 0);
                Length = rawBytes[4];
                Padding = new byte[3];
                Padding[0] = rawBytes[5];
                Padding[1] = rawBytes[6];
                Padding[2] = rawBytes[7];
            }
        }

        public uint Id { get; set; }
        public byte Length { get; set; }
        public byte[] Padding { get; set; }

        public override string ToString()
        {
            return $"{Id:X8}:{Length:X2}";
        }
    }

    public static class TweakDbIdExtensions
    {
        public static TweakDbId ReadTweakDbId(this BinaryReader reader)
        {
            var tdbid = new TweakDbId();
            tdbid.Id = reader.ReadUInt32();
            tdbid.Length = reader.ReadByte();
            tdbid.Padding = reader.ReadBytes(3);
            return tdbid;
        }

        public static void Write(this BinaryWriter writer, TweakDbId tdbid)
        {
            writer.Write(tdbid.Id);
            writer.Write(tdbid.Length);
            writer.Write(tdbid.Padding);
        }
    }
}
