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
        public NodeEntry Node;
        public NodeEntryTreeNode(NodeEntry sourceNode)
        {
            Text = $"[{sourceNode.Id}] {sourceNode.Name}";

            // TODO: this should also be generalized so that each node can provide additional text for the name
            // TODO: however, I did not want to put this into NodeEntry directly

            if (sourceNode.Value is ItemData item)
            {
                var tempDisplay = new ItemDataDisplay(item);
                Text += $" ({tempDisplay.ItemName})";
            }

            Node = sourceNode;
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
    }
}
