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
            { typeof(CharacterCustomizationAppearances.Section), typeof(PropertyEditControl) },
            { typeof(CharacterCustomizationAppearances.AppearanceSection), typeof(PropertyEditControl) },
            { typeof(ItemData), typeof(PropertyEditControl) },
            { typeof(Inventory), typeof(PropertyEditControl) },
            { typeof(Inventory.SubInventory), typeof(PropertyEditControl) },
            { typeof(FactsTable.FactEntry), typeof(PropertyEditControl) },
            { typeof(FactsTable), typeof(PropertyEditControl) },
            { typeof(FactsDB), typeof(PropertyEditControl) },
            { typeof(ItemDropStorage), typeof(PropertyEditControl) },
            { typeof(ItemDropStorageManager), typeof(PropertyEditControl) },
        };

        private void savbinCompressedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fd = new OpenFileDialog { Multiselect = false, InitialDirectory = Environment.CurrentDirectory };

            if (fd.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            var fileName = fd.FileName;

            try
            {
                var bytes = File.ReadAllBytes(fileName);
                var newSaveFile = new SaveFile(_parserConfig.Where(p => p.Enabled).Select(p => p.Parser));
                newSaveFile.LoadPCSaveFile(new MemoryStream(bytes));
                _activeSaveFile = newSaveFile;
                Text = $"CyberCAT: {fileName}";
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
                BuildVisualSubTree(treeNode, null);
                EditorTree.Nodes.Add(treeNode);
            }

            splitContainer1.Panel2.Controls.Clear();
        }

        private void uncompressedToolStripMenuItem_Click(object sender, EventArgs e)
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
                newSaveFile.LoadPS4SaveFile(new MemoryStream(bytes));
                _activeSaveFile = newSaveFile;
                Text = $"CyberCAT: {fileName}";
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
                BuildVisualSubTree(treeNode, null);
                EditorTree.Nodes.Add(treeNode);
            }

            splitContainer1.Panel2.Controls.Clear();
        }

        private void savbinCompressedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_activeSaveFile == null)
            {
                return;
            }

            var saveDialog = new SaveFileDialog { InitialDirectory = Environment.CurrentDirectory };
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(saveDialog.FileName, _activeSaveFile.SaveToPCSaveFile());
            }
        }

        private void uncompressedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_activeSaveFile == null)
            {
                return;
            }

            var saveDialog = new SaveFileDialog { InitialDirectory = Environment.CurrentDirectory };
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(saveDialog.FileName, _activeSaveFile.SaveToPS4SaveFile());
            }
        }

        private void BuildVisualSubTree(NodeEntryTreeNode treeNode, string filter)
        {
            if (treeNode.Node.Value is Inventory inv)
            {
                // For inventory, we insert virtual nodes for the sub inventories.
                var subinventories = inv.SubInventories.Select(_ => (NodeEntry)new VirtualNodeEntry() {Value = _}).ToList();
                foreach (var subinventory in subinventories)
                {
                    var real = subinventory as VirtualNodeEntry;
                    var data = real.Value as Inventory.SubInventory;
                    foreach (var itemNode in treeNode.Node.Children)
                    {
                        if (data.Items.Contains(itemNode.Value) && (filter == null || itemNode.ToString().ToLowerInvariant().Contains(filter)))
                        {
                            subinventory.Children.Add(itemNode);
                        }
                    }
                }
                treeNode.Nodes.AddRange(NodeEntryTreeNode.FromList(subinventories.Where(_ => filter == null || _.Children.Count > 0).ToList()).ToArray());
                foreach (var child in treeNode.Nodes)
                {
                    BuildVisualSubTree((NodeEntryTreeNode)child, filter);
                }

                return;
            }

            if (treeNode.Node.Value is CharacterCustomizationAppearances cca)
            {
                // For CCA we also insert virtual nodes for the three sections
                var sections = new List<CharacterCustomizationAppearances.Section> {cca.FirstSection, cca.SecondSection, cca.ThirdSection};

                foreach (var section in sections)
                {
                    var treeSection = new NodeEntryTreeNode(new VirtualNodeEntry { Value = section });
                    foreach (var appearanceSection in section.AppearanceSections)
                    {
                        if (filter == null || appearanceSection.ToString().ToLowerInvariant().Contains(filter))
                        {
                            treeSection.Nodes.Add(new NodeEntryTreeNode(new VirtualNodeEntry { Value = appearanceSection }));
                        }
                    }

                    if (treeSection.Nodes.Count > 0)
                    {
                        treeNode.Nodes.Add(treeSection);
                    }
                }

                return;
            }

            if (treeNode.Node.Value is FactsTable ft)
            {
                foreach (var fe in ft.FactEntries)
                {
                    if (filter == null || fe.ToString().ToLowerInvariant().Contains(filter))
                    {
                        treeNode.Nodes.Add(new NodeEntryTreeNode(new VirtualNodeEntry { Value = fe }));
                    }
                }

                return;
            }

            if (treeNode.Node.Children.Count > 0)
            {
                var nodes = new List<NodeEntryTreeNode>();
                nodes.AddRange(NodeEntryTreeNode.FromList(treeNode.Node.Children).ToArray());

                foreach (var child in nodes)
                {
                    BuildVisualSubTree((NodeEntryTreeNode)child, filter);
                    if (filter == null || child.Text.ToLowerInvariant().Contains(filter) || child.Nodes.Count > 0)
                    {
                        treeNode.Nodes.Add(child);
                    }
                }
            }
        }

        private void EditorTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var node = (e.Node as NodeEntryTreeNode)?.Node;
            if (node?.Value == null)
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
                    BuildVisualSubTree(treeNode, null);
                    EditorTree.Nodes.Add(treeNode);
                }

                return;
            }
            // Filter nodes. We also show parents if children contain the text.

            var filterString = txtEditorFilter.Text.ToLowerInvariant();

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

                BuildVisualSubTree(treeNode, filterString);
                if (treeNode.Text.ToLowerInvariant().Contains(filterString) || treeNode.Nodes.Count > 0)
                {
                    EditorTree.Nodes.Add(treeNode);
                }

            }

            EditorTree.ExpandAll();
        }
    }
}
