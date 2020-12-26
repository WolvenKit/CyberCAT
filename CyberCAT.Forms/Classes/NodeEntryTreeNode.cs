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
            // TODO: Make this generic or something
            if (sourceNode.Value is ItemData)
            {
                Text = $"[{sourceNode.Id}] {sourceNode.Value}";
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
