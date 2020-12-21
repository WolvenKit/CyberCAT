using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.NodeRepresentations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Core.Classes.Parsers
{
    public class DefaultParser
    {
        public object Parse(NodeEntry node, BinaryReader reader)
        {
            var result = new DefaultRepresentation();
            reader.Skip(4);//skip Id TODO maybe store later
            result.Blob = reader.ReadBytes(node.Size - 4);
            return result;
        }
    }
}
