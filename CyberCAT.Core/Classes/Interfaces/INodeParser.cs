using System;
using System.Collections.Generic;
using System.IO;

namespace CyberCAT.Core.Classes.Interfaces
{
    public interface INodeParser
    {
        string DisplayName { get; }
        Guid Guid { get; }
        string ParsableNodeName { get; }

        object Read(NodeEntry node, BinaryReader reader, List<INodeParser> parsers);
        byte[] Write(NodeEntry node, List<INodeParser> parsers);
    }
}
