using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Core.Classes
{
    public class NodeEntry
    {
        public int Id { get; set; }
        public int NextId { get; set; }
        public int ChildId { get; set; }
        public string Name { get; set; }
        public int Offset { get; set; }
        public int Size { get; set; }
        public object Value { get; set; }
        public bool IsChild { get; set; }
        public List<NodeEntry> Children { get; set; }
        private NodeEntry _nextNode;
        private NodeEntry _previousNode;
        public NodeEntry()
        {
            Children = new List<NodeEntry>();
        }
        public void SetNextNode(NodeEntry nextNode)
        {
            _nextNode = nextNode;
            _nextNode.SetPreviousNode(this);
        }
        public void SetPreviousNode(NodeEntry previousNode)
        {
            _previousNode = previousNode;
        }
        public NodeEntry GetPreviousNode()
        {
            return _previousNode;
        }
        public NodeEntry GetNextNode()
        {
            return _nextNode;
        }
    }
}
