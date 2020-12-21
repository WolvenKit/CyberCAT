using CyberCAT.Core;
using CyberCAT.Core.ChunkedLz4;
using CyberCAT.Core.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public Form1()
        {
            InitializeComponent();
            if (!Directory.Exists(Constants.FileStructure.OUTPUT_FOLDER_NAME))
            {
                Directory.CreateDirectory(Constants.FileStructure.OUTPUT_FOLDER_NAME);
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
            using (var stream = new MemoryStream(fileBytes))
            {
                saveFile.Load(stream);
                File.WriteAllText($"{Constants.FileStructure.OUTPUT_FOLDER_NAME}\\{saveFile.DumpGuid}_dump.json", JsonConvert.SerializeObject(saveFile, Formatting.Indented));
            }
            MessageBox.Show($"Generated {Constants.FileStructure.OUTPUT_FOLDER_NAME}\\{saveFile.DumpGuid}_dump.json");

        }
    }
}
