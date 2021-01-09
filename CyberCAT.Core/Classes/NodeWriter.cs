using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.Parsers;

namespace CyberCAT.Core.Classes
{
    public class NodeWriter : BinaryWriter
    {
        private MemoryStream _ms;
        private List<INodeParser> _parsers;
        
        private List<SaveFile.NodeInfo> _nodeInfos;
        private List<NodeMeta> _nodeMetaInfos;
        private int _currentId;
        private int _currentDepth;
        private int _lastDepth;

        public NodeWriter(Stream stream, List<INodeParser> parsers) : base(stream, Encoding.ASCII, true)
        {
            _parsers = parsers;
            _nodeInfos = new List<SaveFile.NodeInfo>();
            _nodeMetaInfos = new List<NodeMeta>();
        }

        public NodeWriter(List<INodeParser> parsers) : base(new MemoryStream(), Encoding.ASCII, true)
        {
            _parsers = parsers;
            _nodeInfos = new List<SaveFile.NodeInfo>();
            _nodeMetaInfos = new List<NodeMeta>();
        }

        private INodeParser GetParser(NodeEntry node)
        {
            return GetParser(node.Name);
        }

        private INodeParser GetParser(string name)
        {
            var parser = _parsers.FirstOrDefault(p => p.ParsableNodeName == name);
            if (parser == null)
                parser = new DefaultParser();

            return parser;
        }

        private int FakedPosition()
        {
            return (int) (BaseStream.Position + Constants.Numbers.DEFAULT_HEADER_SIZE);
        }

        public void Write(NodeEntry node)
        {
            var isChild = _currentDepth > _lastDepth;
            var isNext = _currentDepth == _lastDepth;
            var isParent = _currentDepth < _lastDepth;

            _lastDepth = _currentDepth;
            _currentDepth++;

            var currentId = _currentId++;
            var nodeInfo = new SaveFile.NodeInfo
            {
                Name = node.Name,
                Offset = FakedPosition()
            };

            if (isChild)
            {
                _nodeInfos[_nodeInfos.Count - 1].ChildId = currentId;
            }
            if (_nodeInfos.Count > 0 && isNext)
            {
                _nodeInfos[_nodeInfos.Count - 1].ChildId = -1;
                _nodeInfos[_nodeInfos.Count - 1].NextId = currentId;
            }
            if (isParent)
            {
                _nodeInfos[_nodeInfos.Count - 1].ChildId = -1;
                _nodeInfos[_nodeInfos.Count - 1].NextId = -1;
                var lastIdSameLevel = _nodeMetaInfos.Where(n => n.Depth == _currentDepth).LastOrDefault().Id;
                _nodeInfos[lastIdSameLevel].NextId = currentId;
            }

            _nodeInfos.Add(nodeInfo);
            _nodeMetaInfos.Add(new NodeMeta(currentId, _currentDepth));

            var parser = GetParser(node);
            Write(currentId);
            parser.Write(this, node);

            nodeInfo.Size = FakedPosition() - nodeInfo.Offset;
            if (node.WritesOwnTrailingSize)
                nodeInfo.Size -= node.TrailingSize;

            _currentDepth--;
        }

        public List<SaveFile.NodeInfo> GetFinalizedInfos()
        {
            for (int i = _nodeInfos.Count - 1; i >= 0; i--)
            {
                if (_nodeInfos[i].ChildId == 0)
                    _nodeInfos[i].ChildId = -1;

                if (_nodeInfos[i].NextId == 0)
                    _nodeInfos[i].NextId = -1;
            }

            return _nodeInfos;
        }

        private class NodeMeta
        {
            public int Id { get; set; }
            public int Depth { get; set; }

            public NodeMeta(int id, int depth)
            {
                Id = id;
                Depth = depth;
            }
        }
    }
}