using CyberCAT.Core;
using CyberCAT.Core.ChunkedLz4;
using CyberCAT.Core.Classes;
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
        CyberPunkSaveFile activeSaveFile = new CyberPunkSaveFile();
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
            if (File.Exists(uncompressFilePathTextbox.Text))
            {
                using (var compressedInputStream = File.OpenRead(uncompressFilePathTextbox.Text))
                {
                    activeSaveFile = new CyberPunkSaveFile();
                    activeSaveFile.ReadHeader(compressedInputStream);
                    activeSaveFile.Decompress(compressedInputStream);
                    
                    //_chunkedFile = new ChunkedLz4File(compressedInputStream);
                    //using (var inputStream = _chunkedFile.Decompress(compressedInputStream))
                    //{
                    //    using (var fileStream = File.Create(@"H:\CP2077_sg\output.bin"))
                    //    {
                    //        inputStream.Seek(0, SeekOrigin.Begin);
                    //        inputStream.CopyTo(fileStream);
                    //    }
                    //}
                }
            }
            else
            {
                MessageBox.Show("File does not exist");
            }
        }
        private void recompressButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(recompressFilePathTextbox.Text))
            {
                if (File.Exists(metaInformationFilePathTextbox.Text))
                {
                    activeSaveFile.CompressFromSingleFile(recompressFilePathTextbox.Text,metaInformationFilePathTextbox.Text);
                }
                else
                {
                    MessageBox.Show("Metainfo File not found");
                }
            }
        }

        private void uncompressFilePathTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void uncompressFilePathTextbox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length != 0)
            {
                uncompressFilePathTextbox.Text = files[0];
            }
        }

        private void uncompressFilePathTextbox_DragEnter(object sender, DragEventArgs e)
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
                var metainfoFileNameGuess = $"{splitted[0]}_{Constants.FileStructure.METAINFORMATION_SUFFIX}.json";
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
    }
}
