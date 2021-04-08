using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CyberCAT.Core.Classes;
using CyberCAT.Core.Classes.DumpedClasses;
using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;
using CyberCAT.Forms.Classes;
using CyberCAT.Forms.Editor;
using Control = System.Windows.Forms.Control;

namespace CyberCAT.Forms
{
    partial class Form1
    {
        private SaveFile _activeSaveFile;
        private Dictionary<Type, Type> ParsedToControlMap = new Dictionary<Type, Type>()
        {
            { typeof(ItemData), typeof(ItemEditorControl) },
        };

        private void SetPropertyEditControlSettings()
        {
            TypeDescriptor.AddAttributes(typeof(byte[]), new EditorAttribute(typeof(HexEditor), typeof(UITypeEditor)));
            TypeDescriptor.AddAttributes(typeof(CharacterCustomizationAppearances.AppearanceSection), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(CharacterCustomizationAppearances.Section), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ItemData.NextItemEntry), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ItemData.ItemFlags), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ItemData), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ItemData.HeaderThing), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ItemData.ItemInnerData), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ItemData.SimpleItemData), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ItemData.ModableItemData), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ItemData.ItemModData), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(Inventory.SubInventory), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ItemDropStorage), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(FactsTable.FactEntry), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(TweakDbId), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(GenericUnknownStruct.BaseClassEntry), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(IHandle), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
        }

        private void LoadPcSaveClick(object sender, EventArgs e)
        {
            var fd = new OpenFileDialog { Multiselect = false, InitialDirectory = Environment.CurrentDirectory };

            if (_settings.StartInSavesFolder)
            {
                fd.InitialDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Saved games", "CD Projekt Red", "Cyberpunk 2077");
            }

            if (fd.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            var fileName = fd.FileName;

            var bytes = File.ReadAllBytes(fileName);
            var newSaveFile = new SaveFile(_parserConfig.Where(p => p.Enabled).Select(p => p.Parser));
            newSaveFile.Load(new MemoryStream(bytes));
            _activeSaveFile = newSaveFile;
            footerLabel.Text = $"{_activeSaveFile.Header} - {fileName}";

            EditorTree.Nodes.Clear();
            txtEditorFilter.Text = "";

            foreach (var node in _activeSaveFile.Nodes)
            {
                var treeNode = new NodeEntryTreeNode(node);
                BuildVisualSubTree(treeNode, null);
                EditorTree.Nodes.Add(treeNode);
            }

            mainContainer.Panel2.Controls.Clear();
        }

        private void LoadPs4SaveClick(object sender, EventArgs e)
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
                newSaveFile.Load(new MemoryStream(bytes));
                _activeSaveFile = newSaveFile;
                footerLabel.Text = $"{_activeSaveFile.Header} - {fileName}";
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

            mainContainer.Panel2.Controls.Clear();
        }

        private void SavePcSaveClick(object sender, EventArgs e)
        {
            if (_activeSaveFile == null)
            {
                return;
            }

            var saveDialog = new SaveFileDialog { InitialDirectory = Environment.CurrentDirectory };

            if (_settings.StartInSavesFolder)
            {
                saveDialog.InitialDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Saved games", "CD Projekt Red", "Cyberpunk 2077");
            }

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(saveDialog.FileName, _activeSaveFile.Save());
            }
        }

        private void SavePs4SaveClick(object sender, EventArgs e)
        {
            if (_activeSaveFile == null)
            {
                return;
            }

            var saveDialog = new SaveFileDialog { InitialDirectory = Environment.CurrentDirectory };
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(saveDialog.FileName, _activeSaveFile.Save(true));
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
                    var real = subinventory as VirtualNodeEntry ?? throw new Exception("subinventory is not a VirtualNodeEntry, wtf?!");
                    var data = real.Value as Inventory.SubInventory;
                    var simpleItems = new VirtualNodeEntry { Value = "Simple items" };
                    var modableItems = new VirtualNodeEntry { Value = "Modable Items" };
                    foreach (var itemNode in treeNode.Node.Children)
                    {
                        if (data.Items.Contains(itemNode.Value) && (filter == null || itemNode.ToString().ToLowerInvariant().Contains(filter)))
                        {
                            var item = ((ItemData) itemNode.Value).Data;
                            if (item is ItemData.SimpleItemData sid)
                            {
                                simpleItems.Children.Add(itemNode);
                            }
                            else
                            {
                                modableItems.Children.Add(itemNode);
                            }
                        }
                    }

                    if (simpleItems.Children.Count > 0)
                    {
                        subinventory.Children.Add(simpleItems);
                    }
                    if (modableItems.Children.Count > 0)
                    {
                        subinventory.Children.Add(modableItems);
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
                mainContainer.Panel2.Controls.Clear();
                return;
            }

            var tabControl = new TabControl() {Dock = DockStyle.Fill};
            var propertyEditTabPage = new TabPage {Text = "Advanced"};
            var propertyEdit = new PropertyEditControl(node.Value, _activeSaveFile) {Dock = DockStyle.Fill};
            propertyEditTabPage.Controls.Add(propertyEdit);

            ParsedToControlMap.TryGetValue(node.Value.GetType(), out var control);
            if (control != null)
            {
                var instance = Activator.CreateInstance(control, node.Value, _activeSaveFile);
                if (instance is Control nodeControl)
                {
                    nodeControl.Dock = DockStyle.Fill;
                    var simpleTabPage = new TabPage {Text = "Simple"};
                    simpleTabPage.Controls.Add(nodeControl);
                    tabControl.TabPages.Add(simpleTabPage);
                }
            }

            tabControl.TabPages.Add(propertyEditTabPage);

            mainContainer.Panel2.Controls.Clear();
            mainContainer.Panel2.Controls.Add(tabControl);
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
