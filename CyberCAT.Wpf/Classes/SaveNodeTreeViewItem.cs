using CyberCAT.Core.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace CyberCAT.Wpf.Classes
{
    public class SaveNodeTreeViewItem : TreeViewItem
    {
        public readonly NodeEntry Node;
        public SaveNodeTreeViewItem(NodeEntry sourceNode)
        {
            Node = sourceNode;
            Header = Node.ToString();
        }
        public static List<SaveNodeTreeViewItem> FromList(List<NodeEntry> nodes)
        {
            var result = new List<SaveNodeTreeViewItem>();
            foreach (var node in nodes)
            {
                result.Add(new SaveNodeTreeViewItem(node));
            }
            return result;
        }

        //public new virtual string Text => Node.ToString();
        public override string ToString()
        {
            return Node.ToString();
        }

        public new bool Equals(object obj)
        {
            if (obj is SaveNodeTreeViewItem netn)
            {
                return netn.Node == Node;
            }

            return false;
        }

        protected bool Equals(SaveNodeTreeViewItem other)
        {
            return Equals(Node, other.Node);
        }

        public new int GetHashCode()
        {
            return Node != null ? Node.GetHashCode() : 0;
        }
    }
}
