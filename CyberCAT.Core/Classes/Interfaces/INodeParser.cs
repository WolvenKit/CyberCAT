using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Core.Classes.Interfaces
{
    interface INodeParser
    {
        string ParsableNodeName { get; set; }
        object Parse(NodeEntry node, BinaryReader reader);
    }
}
