using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Core.Classes.NodeRepresentations
{
    public class GameSessionConfig
    {
        public ulong Hash1 { get; set; }
        public ulong Hash2 { get; set; }
        public string TextValue { get; set; }
        public ulong Hash3 { get; set; }
        public byte[] TrailingBytes { get; set; }
    }
}
