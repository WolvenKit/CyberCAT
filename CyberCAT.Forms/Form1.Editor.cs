using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CyberCAT.Core.Classes;
using CyberCAT.Core.Classes.NodeRepresentations;
using CyberCAT.Forms.Classes;
using CyberCAT.Forms.Editor;

namespace CyberCAT.Forms
{
    partial class Form1
    {
        private SaveFile _activeSaveFile;
        private Dictionary<Type, Type> ParsedToControlMap = new Dictionary<Type, Type>()
        {
            { typeof(DefaultRepresentation), typeof(PropertyEditControl) },
            { typeof(GameSessionConfig), typeof(PropertyEditControl) },
            { typeof(CharacterCustomizationAppearances), typeof(PropertyEditControl) },
            { typeof(ItemData), typeof(PropertyEditControl) },
            { typeof(Inventory), typeof(PropertyEditControl) },
            { typeof(FactsTable), typeof(PropertyEditControl) },
            { typeof(FactsDB), typeof(PropertyEditControl) },
            { typeof(ItemDropStorage), typeof(PropertyEditControl) },
            { typeof(ItemDropStorageManager), typeof(PropertyEditControl) },
        };

        private void EditorAddChildrenToTreeNode(NodeEntryTreeNode treeNode)
        {
            if (treeNode.Node.Children.Count > 0)
            {
                treeNode.Nodes.AddRange(NodeEntryTreeNode.FromList(treeNode.Node.Children).ToArray());
                foreach (var child in treeNode.Nodes)
                {
                    EditorAddChildrenToTreeNode((NodeEntryTreeNode)child);
                }
            }
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (_activeSaveFile == null)
            {
                return;
            }

            var saveDialog = new SaveFileDialog { InitialDirectory = Environment.CurrentDirectory };
            if(saveDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(saveDialog.FileName, _activeSaveFile.Save());
            }
        }
        private void EditorLoad_Click(object sender, EventArgs e)
        {
            var fd = new OpenFileDialog { Multiselect = false, InitialDirectory = Environment.CurrentDirectory };

            if (fd.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            var fileName = fd.FileName;

            var bytes = File.ReadAllBytes(fileName);

            try
            {
                var newSaveFile = new SaveFile(_parserConfig.Where(p => p.Enabled).Select(p => p.Parser));
                newSaveFile.LoadFromCompressedStream(new MemoryStream(bytes));
                _activeSaveFile = newSaveFile;
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Error reading file: {exception.Message}");
                return;
            }

            EditorTree.Nodes.Clear();
            txtEditorFilter.Text = "";

            foreach (var node in _activeSaveFile.Nodes)
            {
                var treeNode = new NodeEntryTreeNode(node);
                AddChildrenToTreeNode(treeNode);
                EditorTree.Nodes.Add(treeNode);
            }
        }

        private void EditorTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var node = (e.Node as NodeEntryTreeNode)?.Node;
            if (node == null)
            {
                splitContainer1.Panel2.Controls.Clear();
                return;
            }

            ParsedToControlMap.TryGetValue(node.Value.GetType(), out var control);
            if (control == null)
            {
                splitContainer1.Panel2.Controls.Clear();
                return;
            }

            var instance = Activator.CreateInstance(control, node.Value);
            var nodeControl = instance as Control;
            if (nodeControl == null)
            {
                splitContainer1.Panel2.Controls.Clear();
                return;
            }

            splitContainer1.Panel2.Controls.Clear();
            nodeControl.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(nodeControl);
        }

        private void AddChildrenToTreeNodeWithFilter(NodeEntryTreeNode treeNode, string filter)
        {
            if (treeNode.Node.Children.Count > 0)
            {
                var nodes = new List<NodeEntryTreeNode>();
                nodes.AddRange(NodeEntryTreeNode.FromList(treeNode.Node.Children).ToArray());

                foreach (var child in nodes)
                {
                    AddChildrenToTreeNodeWithFilter(child, filter);
                    if (child.Text.ToLowerInvariant().Contains(filter) || child.Nodes.Count > 0)
                    {
                        treeNode.Nodes.Add(child);
                    }
                }
            }

        }

        private void txtEditorFilter_TextChanged(object sender, EventArgs e)
        {
            if (_activeSaveFile == null)
            {
                return;
            }

            if (string.IsNullOrEmpty(txtEditorFilter.Text))
            {
                EditorTree.Nodes.Clear();
                foreach (var node in _activeSaveFile.Nodes)
                {
                    var treeNode = new NodeEntryTreeNode(node);
                    AddChildrenToTreeNode(treeNode);
                    EditorTree.Nodes.Add(treeNode);
                }

                return;
            }
            // Filter nodes. We also show parents if children contain the text.

            var filterString = txtEditorFilter.Text;

            List<NodeEntry> filteredNodes = new List<NodeEntry>();

            foreach (var node in _activeSaveFile.FlatNodes)
            {
                if (node.ToString().Contains(filterString))
                {
                    filteredNodes.Add(node);
                }
            }

            List<NodeEntryTreeNode> filteredTreeNodes = new List<NodeEntryTreeNode>();

            EditorTree.Nodes.Clear();
            foreach (var node in _activeSaveFile.Nodes)
            {
                var treeNode = new NodeEntryTreeNode(node);

                AddChildrenToTreeNodeWithFilter(treeNode, filterString);
                if (treeNode.Text.ToLowerInvariant().Contains(filterString) || treeNode.Nodes.Count > 0)
                {
                    EditorTree.Nodes.Add(treeNode);
                }

            }

            EditorTree.ExpandAll();
        }
    }
}
