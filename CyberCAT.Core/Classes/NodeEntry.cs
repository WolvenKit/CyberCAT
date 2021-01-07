using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.NodeRepresentations;

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
        public bool IsFirstChild { get; set; }
        public int DataSize { get; set; }
        public int TrailingSize { get; set; }
        public bool WritesOwnTrailingSize { get; set; }
        public List<NodeEntry> Children { get; set; }
        private NodeEntry _nextNode;
        private NodeEntry _previousNode;
        private NodeEntry _parent;

        public INodeParser Parser { get; set; }
        public List<INodeParser> Parsers { get; set; }

        public delegate void NodeSizeChangedEvent(NodeEntry node, int sizeChange);
        public event NodeSizeChangedEvent NodeSizeChanged;

        public delegate void NodeOffseteChangedEvent(NodeEntry node, int offsetChange);
        public event NodeOffseteChangedEvent NodeOffsetChanged;

        public delegate void ChildSizeChangedEvent(NodeEntry childNode);
        public event ChildSizeChangedEvent ChildSizeChanged;

        public NodeEntry()
        {
            WritesOwnTrailingSize = true;
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

        public void AddChild(NodeEntry child)
        {
            child.IsChild = true;
            if (Children.Count == 0)
            {
                child.IsFirstChild = true;
            }
            Children.Add(child);
            child.SetParent(this);
        }

        public void SetParent(NodeEntry parent)
        {
            _parent = parent;
        }

        public NodeEntry GetParent()
        {
            return _parent;
        }

        public NodeEntry GetPreviousNode()
        {
            return _previousNode;
        }

        public NodeEntry GetNextNode()
        {
            return _nextNode;
        }

        public override string ToString()
        {
            var s = $"[{Id}] {Name}";

            // TODO: Make this generic or something
            if (Value is ItemData)
            {
                s = $"[{Id}] {Value}";
            }

            return s;
        }

        public void MySizeChanged()
        {
            // My size changed! First, tell the node after me who will tell all the nodes after them.
            // Then, tell my parent.
            // I do not have to tell my children because if I had children, my size can only change because one of their sizes changed. (Is this really true?)

            // But first, actually determine my new size.
            var newSize = Parser.Write(this, Parsers).Length;
            newSize -= (WritesOwnTrailingSize ? TrailingSize : 0);
            var sizeChange = newSize - Size;

            if (sizeChange == 0)
            {
                // Nothing changed, do nothing.
                return;
            }

            Size = newSize;
            NodeSizeChanged?.Invoke(this, sizeChange);
            ChildSizeChanged?.Invoke(this);
        }

        public virtual void OnPreviousNodeSizeChanged(NodeEntry previousNode, int sizeChange)
        {
            Offset += sizeChange;

            NodeOffsetChanged?.Invoke(this, sizeChange);
        }

        public virtual void OnPreviousNodeOffsetChanged(NodeEntry previousNode, int offsetChange)
        {
            Offset += offsetChange;

            NodeOffsetChanged?.Invoke(this, offsetChange);
        }

        public virtual void OnParentNodeOffsetChanged(NodeEntry parentNode, int offsetChange)
        {
            Offset += offsetChange;

            NodeOffsetChanged?.Invoke(this, offsetChange);
        }

        public virtual void OnChildSizeChanged(NodeEntry childNode)
        {
            // A child changed their size. The child has notified all the nodes after it.
            // I need to adjust my size.
            MySizeChanged();
        }
    }
}
