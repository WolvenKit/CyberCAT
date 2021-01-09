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
using CyberCAT.Core.Classes.DumpedClasses;
using CyberCAT.Core.Classes.Mapping;
using static CyberCAT.Core.Classes.Parsers.StatsSystemParser;

namespace CyberCAT.Forms
{
    
    public partial class Form1 : Form
    {
        SaveFileCompressionHelper _saveFileCompressionHelper = new SaveFileCompressionHelper();
        List<ParserConfig> _parserConfig = new List<ParserConfig>();
        Settings _settings;
        private const string SETTINGS_FILE_NAME = "Settings.json";
        private const string NAMES_FILE_NAME = "Names.json";
        private const string FACTS_FILE_NAME = "Facts.json";

        private string _selectedFileForDecompression;
        private string _selectedFileForRecompression;
        private string _selectedMetaFileForRecompression;

        public Form1()
        {
            InitializeComponent();
            if (!Directory.Exists(Constants.FileStructure.OUTPUT_FOLDER_NAME))
            {
                Directory.CreateDirectory(Constants.FileStructure.OUTPUT_FOLDER_NAME);
            }
            exportToolStripMenuItem.Click += ExportToolStripMenuItem_Click;
            tsmiImport.Click += ImportBinaryClick;
            NameResolver.UseDictionary(JsonConvert.DeserializeObject<Dictionary<ulong, NameResolver.NameStruct>>(File.ReadAllText(NAMES_FILE_NAME)));
            FactResolver.UseDictionary(JsonConvert.DeserializeObject<Dictionary<ulong, string>>(File.ReadAllText(FACTS_FILE_NAME)));
            //Make rightclick select node. Better usability of context menu
            EditorTree.NodeMouseClick += (sender, args) => EditorTree.SelectedNode = args.Node;

            SetPropertyEditControlSettings();

            //Settings
            var interfaceType = typeof(INodeParser);
            var types = AppDomain.CurrentDomain.GetAssemblies().SelectMany(s => s.GetTypes()).Where(p => interfaceType.IsAssignableFrom(p) && p.IsClass && p != typeof(DefaultParser));
            if (File.Exists(SETTINGS_FILE_NAME))
            {
                _settings = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(SETTINGS_FILE_NAME));
                foreach (var type in types)
                {
                    var instance = (INodeParser)Activator.CreateInstance(type);
                    _parserConfig.Add(new ParserConfig(instance, _settings.EnabledParsers.Contains(instance.Guid)));
                    cbStartInSaves.Checked = _settings.StartInSavesFolder;
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
            _saveFileCompressionHelper = new SaveFileCompressionHelper();
        }

        private void ExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var data = (NodeEntryTreeNode)EditorTree.SelectedNode;

            if (data.Node is VirtualNodeEntry)
            {
                MessageBox.Show("This is a visual node and cannot be exported.\nVisual nodes are inserted to create more structure in the node tree and are denoted by the [V] prefix.");
                return;
            }

            if (data.Node.Children.Count > 0)
            {
                MessageBox.Show("Currently, nodes with children cannot be binary exported due to technical reasons.\nWell, we could export them but cannot import them.");
                return;
            }

            byte[] bytes;
            var parsers = _parserConfig.Where(p => p.Enabled).Select(p => p.Parser).ToList();
            using (var stream = new MemoryStream())
            {
                using (var writer = new NodeWriter(stream, parsers))
                {
                    writer.Write(data.Node);
                }

                bytes = stream.ToArray();
            }

            var saveDialog = new SaveFileDialog { InitialDirectory = Environment.CurrentDirectory };


            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(saveDialog.FileName, bytes);
            }
        }

        private void ImportBinaryClick(object sender, EventArgs e)
        {
            var data = (NodeEntryTreeNode)EditorTree.SelectedNode;

            if (data.Node is VirtualNodeEntry)
            {
                MessageBox.Show("This is a visual node and cannot be imported into.\nVisual nodes are inserted to create more structure in the node tree and are denoted by the [V] prefix.");
                return;
            }

            if (data.Node.Children.Count > 0)
            {
                MessageBox.Show("Currently, nodes with children cannot be binary imported due to technical reasons.");
                return;
            }

            var fd = new OpenFileDialog { Multiselect = false, InitialDirectory = Environment.CurrentDirectory };

            if (fd.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            var fileName = fd.FileName;

            try
            {
                var bytes = File.ReadAllBytes(fileName);
                var parsers = _parserConfig.Where(p => p.Enabled).Select(p => p.Parser).ToList();
                var parser = parsers.FirstOrDefault(p => p.ParsableNodeName == data.Node.Name) ?? throw new Exception("No parser for this node!");
                data.Node.Offset = 0;
                data.Node.Size = bytes.Length;
                if (data.Node.WritesOwnTrailingSize)
                {
                    data.Node.Size -= data.Node.TrailingSize;
                }
                using (var stream = new MemoryStream(bytes))
                {
                    using (var reader = new BinaryReader(stream))
                    {
                        var newObject = parser.Read(data.Node, reader, parsers);
                        data.Node.Value = newObject;
                    }
                }
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
        }

        private void uncompressButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(_selectedFileForDecompression))
            {
                using (var compressedInputStream = File.OpenRead(_selectedFileForDecompression))
                {
                    var decompressedFile = _saveFileCompressionHelper.Decompress(compressedInputStream);
                    string json = JsonConvert.SerializeObject(_saveFileCompressionHelper.MetaInformation, Formatting.Indented);
                    var outputFolder = new FileInfo(_selectedFileForDecompression).Directory.FullName;
                    File.WriteAllText($"{outputFolder}\\{_saveFileCompressionHelper.MetaInformation.FileGuid}_{Constants.FileStructure.METAINFORMATION_SUFFIX}.{Constants.FileExtensions.JSON}", json);
                    File.WriteAllBytes($"{outputFolder}\\{_saveFileCompressionHelper.MetaInformation.FileGuid}_{Constants.FileStructure.UNCOMPRESSED_SUFFIX}.{Constants.FileExtensions.DECOMPRESSED_FILE}", decompressedFile);
                }

                MessageBox.Show(Constants.Messages.DECOMPRESSION_SUCCESSFUL, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Constants.Messages.MISSING_FILE_TEXT, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void recompressButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(_selectedFileForRecompression))
            {
                if (File.Exists(_selectedMetaFileForRecompression))
                {
                    var outputFolder = new FileInfo(_selectedFileForRecompression).Directory.FullName;
                    _saveFileCompressionHelper.CompressFromSingleFile(_selectedFileForRecompression, _selectedMetaFileForRecompression, outputFolder);

                    MessageBox.Show(Constants.Messages.RECOMPRESSION_SUCCESSFUL, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(Constants.Messages.MISSING_METAINFO_FILE_TEXT);
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
            _settings.EnabledParsers.AddRange(_parserConfig.Where(p => p.Enabled == true).Select(p => p.Parser.Guid));
            _settings.StartInSavesFolder = cbStartInSaves.Checked;
            File.WriteAllText(SETTINGS_FILE_NAME, JsonConvert.SerializeObject(_settings, Formatting.Indented));
        }

        private void exportAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var info = Directory.CreateDirectory($"{Constants.FileStructure.OUTPUT_FOLDER_NAME}\\Export_{Guid.NewGuid()}");
            foreach(var node in _activeSaveFile.FlatNodes)
            {
                var filename = Path.Combine(info.FullName, $"{node.Id}_{string.Concat(node.Name.Split(Path.GetInvalidFileNameChars()))}");
                byte[] bytes;
                var parsers = _parserConfig.Where(p => p.Enabled).Select(p => p.Parser).ToList();
                using (var stream = new MemoryStream())
                {
                    using (var writer = new NodeWriter(stream, parsers))
                    {
                        writer.Write(node);
                    }

                    bytes = stream.ToArray();
                }
            }
            MessageBox.Show($"Exported All unparsed Nodes to {info.FullName}");
        }

        private void btnLoadSaveDecompress_Click(object sender, EventArgs e)
        {
            var fd = new OpenFileDialog { Multiselect = false, InitialDirectory = Environment.CurrentDirectory };

            if (fd.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            _selectedFileForDecompression = fd.FileName;
            uncompressButton.Enabled = true;
            lblSelectedFileForDecompression.Text = $"Selected File: {_selectedFileForDecompression}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fd = new OpenFileDialog { Multiselect = false, InitialDirectory = Environment.CurrentDirectory };

            if (fd.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            var metainfFile = fd.FileName.Replace(
                $"{Constants.FileStructure.UNCOMPRESSED_SUFFIX}.{Constants.FileExtensions.DECOMPRESSED_FILE}",
                $"{Constants.FileStructure.METAINFORMATION_SUFFIX}.{Constants.FileExtensions.JSON}");

            if (!File.Exists(metainfFile))
            {
                MessageBox.Show(Constants.Messages.MISSING_METAINFO_FILE_TEXT, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _selectedFileForRecompression = fd.FileName;
            _selectedMetaFileForRecompression = metainfFile;
            recompressButton.Enabled = true;
            lblSelectedFileForRecompression.Text = $"Selected File: {_selectedFileForRecompression}";
        }

        private void exportJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedNode = (NodeEntryTreeNode)EditorTree.SelectedNode;
            var data = (NodeEntry)selectedNode.Node;
            var json = JsonConvert.SerializeObject(data, Formatting.Indented);
            string folderPath = $"{Constants.FileStructure.OUTPUT_FOLDER_NAME}\\export_{_activeSaveFile.Guid}";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            File.WriteAllText($"{folderPath}\\{selectedNode.Node.Id}_{selectedNode.Node.Value}.json", json);
            MessageBox.Show($"Exported selected node to {folderPath}\\{selectedNode.Node.Id}_{selectedNode.Node.Value}.json");
        }
    }
}
