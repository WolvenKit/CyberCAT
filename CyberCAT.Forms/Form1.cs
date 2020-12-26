using CyberCAT.Core;
using CyberCAT.Core.ChunkedLz4;
using CyberCAT.Core.Classes;
using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.NodeRepresentations;
using CyberCAT.Core.Classes.Parsers;
using CyberCAT.Forms.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberCAT.Forms
{
    
    public partial class Form1 : Form
    {
        SaveFileCompressionHelper activeSaveFile = new SaveFileCompressionHelper();
        List<ParserConfig> _parserConfig = new List<ParserConfig>();
        Settings _settings;
        string _settingsFileName = "Settings.json";
        string _itemsFileName = "Items.json";
        public Form1()
        {
            InitializeComponent();
            if (!Directory.Exists(Constants.FileStructure.OUTPUT_FOLDER_NAME))
            {
                Directory.CreateDirectory(Constants.FileStructure.OUTPUT_FOLDER_NAME);
            }
            exportToolStripMenuItem.Click += ExportToolStripMenuItem_Click;
            NameResolver.UseDictionary(JsonConvert.DeserializeObject<Dictionary<uint, string>>(File.ReadAllText(_itemsFileName)));
            //Add Hexeditor as editor for byte arrays
            TypeDescriptor.AddAttributes(typeof(byte[]),new EditorAttribute(typeof(HexEditor), typeof(UITypeEditor)));
            TypeDescriptor.AddAttributes(typeof(CharacterCustomizationAppearances.AppearanceSection), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(CharacterCustomizationAppearances.Section), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));
            TypeDescriptor.AddAttributes(typeof(ItemData.NextItemEntry), new TypeConverterAttribute(typeof(ExpandableObjectConverter)));

            //Settings
            var interfaceType = typeof(INodeParser);
            var types = AppDomain.CurrentDomain.GetAssemblies().SelectMany(s => s.GetTypes()).Where(p => interfaceType.IsAssignableFrom(p) && p.IsClass);
            if (File.Exists(_settingsFileName))
            {
                _settings = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(_settingsFileName));
                foreach (var type in types)
                {
                    var instance = (INodeParser)Activator.CreateInstance(type);
                    _parserConfig.Add(new ParserConfig(instance, _settings.EnabledParsers.Contains(instance.Guid)));
                }
            }
            else
            {
                foreach (var type in types)
                {
                    var instance = Activator.CreateInstance(type);
                    _parserConfig.Add(new ParserConfig((INodeParser)instance, true));
                }
                _settings = new Settings();
                _settings.EnabledParsers.AddRange(_parserConfig.Where(p => p.Enabled = true).Select(p => p.Parser.Guid));
            }
            dataGridView1.DataSource = _parserConfig;
            
        }

        private void ExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveDialog = new SaveFileDialog { InitialDirectory = Environment.CurrentDirectory };
            var data = (NodeEntryTreeNode)EditorTree.SelectedNode;
            if (data.Node.Value is DefaultRepresentation)
            {
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    var representation = (DefaultRepresentation)data.Node.Value;
                    File.WriteAllBytes(saveDialog.FileName, representation.Blob);
                }
            }
            else
            {
                MessageBox.Show("Exporting known structures not supported yet");
            }
        }

        private void uncompressButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(decompressFilePathTextbox.Text))
            {
                using (var compressedInputStream = File.OpenRead(decompressFilePathTextbox.Text))
                {
                    activeSaveFile = new SaveFileCompressionHelper();
                    var decompressedFile = activeSaveFile.Decompress(compressedInputStream);
                    string json = JsonConvert.SerializeObject(activeSaveFile.MetaInformation, Formatting.Indented);
                    File.WriteAllText($"{Constants.FileStructure.OUTPUT_FOLDER_NAME}\\{activeSaveFile.MetaInformation.FileGuid}_{Constants.FileStructure.METAINFORMATION_SUFFIX}.{Constants.FileExtensions.JSON}", json);
                    File.WriteAllBytes($"{Constants.FileStructure.OUTPUT_FOLDER_NAME}\\{activeSaveFile.MetaInformation.FileGuid}_{Constants.FileStructure.UNCOMPRESSED_SUFFIX}.{Constants.FileExtensions.DECOMPRESSED_FILE}", decompressedFile);
                }
            }
            else
            {
                MessageBox.Show(Constants.Messages.MISSING_FILE_TEXT);
            }
        }
        private void recompressButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(recompressFilePathTextbox.Text))
            {
                if (File.Exists(metaInformationFilePathTextbox.Text))
                {
                    activeSaveFile.CompressFromSingleFile(recompressFilePathTextbox.Text,metaInformationFilePathTextbox.Text, out _);
                }
                else
                {
                    MessageBox.Show(Constants.Messages.MISSING_METAINFO_FILE_TEXT);
                }
            }
        }

        private void decompressFilePathTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void decompressFilePathTextbox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length != 0)
            {
                decompressFilePathTextbox.Text = files[0];
            }
        }

        private void decompressFilePathTextbox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void recompressFilePathTextbox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length != 0)
            {
                recompressFilePathTextbox.Text = files[0];
                var splitted = Path.GetFileName(files[0]).Split('_');
                var metainfoFileNameGuess = $"{splitted[0]}_{Constants.FileStructure.METAINFORMATION_SUFFIX}.{Constants.FileExtensions.JSON}";
                if (File.Exists($"{Constants.FileStructure.OUTPUT_FOLDER_NAME}\\{metainfoFileNameGuess}"))
                {
                    metaInformationFilePathTextbox.Text = Path.GetFullPath($"{Constants.FileStructure.OUTPUT_FOLDER_NAME}\\{metainfoFileNameGuess}");
                }
            }
        }

        private void recompressFilePathTextbox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void metaInformationFilePathTextbox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length != 0)
            {
                metaInformationFilePathTextbox.Text = files[0];
            }
        }

        private void metaInformationFilePathTextbox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void appearanceUncompressedSaveFilePathTextbox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void appearanceUncompressedSaveFilePathTextbox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length != 0)
            {
                appearanceUncompressedSaveFilePathTextbox.Text = files[0];
            }
        }

        private void loadAppearanceSectionButton_Click(object sender, EventArgs e)
        {
            var saveFile = new SaveFile();
            var fileBytes = File.ReadAllBytes(appearanceUncompressedSaveFilePathTextbox.Text);
            var guid = Guid.NewGuid();
            using (var stream = new MemoryStream(fileBytes))
            {
                saveFile.LoadFromCompressedStream(stream);
                File.WriteAllText($"{Constants.FileStructure.OUTPUT_FOLDER_NAME}\\{guid}_dump.json", JsonConvert.SerializeObject(saveFile, Formatting.Indented));
            }
            var growableSectionNames = new List<string>();
            growableSectionNames.AddRange(saveFile.Nodes.Where(n => n.Size == n.TrueSize).Select(n => n.Name));
            File.WriteAllLines($"{Constants.FileStructure.OUTPUT_FOLDER_NAME}\\{guid}_growableSectionNames.txt", growableSectionNames);
            MessageBox.Show($"Generated {Constants.FileStructure.OUTPUT_FOLDER_NAME}\\{guid}_dump.json");
            foreach (var node in saveFile.Nodes)
            {
                var treeNode = new NodeEntryTreeNode(node);
                AddChildrenToTreeNode(treeNode);
                treeView1.Nodes.Add(treeNode);
            }
        }
        private void AddChildrenToTreeNode(NodeEntryTreeNode treeNode)
        {
            if (treeNode.Node.Children.Count > 0)
            {
                treeNode.Nodes.AddRange(NodeEntryTreeNode.FromList(treeNode.Node.Children).ToArray());
                foreach(var child in treeNode.Nodes)
                {
                    AddChildrenToTreeNode((NodeEntryTreeNode)child);
                }
            }
            
        }

        private void editorTreeContextMenu_Opening(object sender, CancelEventArgs e)
        {
            if (EditorTree.SelectedNode !=null)
            {
                exportToolStripMenuItem.Enabled = true;
            }
        }

        private void saveSettingsButton_Click(object sender, EventArgs e)
        {
            _settings.EnabledParsers.Clear();
            _settings.EnabledParsers.AddRange(_parserConfig.Where(p => p.Enabled== true).Select(p => p.Parser.Guid));
            File.WriteAllText(_settingsFileName, JsonConvert.SerializeObject(_settings, Formatting.Indented));
        }

        private void exportAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var info = Directory.CreateDirectory($"{Constants.FileStructure.OUTPUT_FOLDER_NAME}\\Export_{Guid.NewGuid()}");
            foreach(var node in _activeSaveFile.FlatNodes)
            {
                if(node.Value is DefaultRepresentation)
                {
                    var representation = (DefaultRepresentation)node.Value;
                    File.WriteAllBytes(Path.Combine(info.FullName, $"{node.Id}_{string.Concat(node.Name.Split(Path.GetInvalidFileNameChars()))}"), representation.Blob);
                }
            }
            MessageBox.Show($"Exported All unparsed Nodes to {info.FullName}");
        }
    }
}
