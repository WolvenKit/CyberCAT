using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Core.Classes.Interfaces
{
    public interface INodeParser
    {
        string DisplayName { get;}
        Guid Guid { get;}
        List<string> ParsableNodeNames { get;}
        object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers);
        byte[] Write(NodeEntry node, List<INodeParser> parsers);
    }
}
