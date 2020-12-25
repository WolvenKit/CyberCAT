using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using CyberCAT.Core.Classes;
using CyberCAT.Core.Classes.NodeRepresentations;
using CyberCAT.Forms.Classes;
using CyberCAT.Forms.Editor;

namespace CyberCAT.Forms
{
    partial class Form1
    {
        SaveFile _activeSaveFile;
        private Dictionary<Type, Type> ParsedToControlMap = new Dictionary<Type, Type>()
        {
            { typeof(DefaultRepresentation), typeof(HexEditorControl) },
            { typeof(GameSessionConfig), typeof(GameSessionConfigControl) },
            { typeof(CharacterCustomizationAppearances), typeof(PropertyEditControl) },
            { typeof(ItemData), typeof(PropertyEditControl) },
            { typeof(Inventory), typeof(PropertyEditControl) }
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
            _activeSaveFile = new SaveFile(_parserConfig.Where(p=>p.Enabled).Select(p=>p.Parser));
            var bytes = File.ReadAllBytes(fileName);
            try
            {
                _activeSaveFile.LoadFromCompressedStream(new MemoryStream(bytes));
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Error reading file: {exception.Message}");
                return;
            }

            EditorTree.Nodes.Clear();
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
    }
}
