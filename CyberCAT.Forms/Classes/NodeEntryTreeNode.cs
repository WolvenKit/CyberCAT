using CyberCAT.Core.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Forms.Classes
{
    class NodeEntryTreeNode : TreeNode
    {
        public readonly NodeEntry Node;
        public NodeEntryTreeNode(NodeEntry sourceNode)
        {
            Node = sourceNode;
            Text = Node.ToString();
        }
        public static List<NodeEntryTreeNode> FromList(List<NodeEntry> nodes)
        {
            var result = new List<NodeEntryTreeNode>();
            foreach(var node in nodes)
            {
                result.Add(new NodeEntryTreeNode(node));
            }
            return result;
        }

        //public new virtual string Text => Node.ToString();
        public override string ToString()
        {
            return Node.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj is NodeEntryTreeNode netn)
            {
                return netn.Node == Node;
            }

            return false;
        }

        protected bool Equals(NodeEntryTreeNode other)
        {
            return Equals(Node, other.Node);
        }

        public override int GetHashCode()
        {
            return Node != null ? Node.GetHashCode() : 0;
        }
    }
}
