using CyberCAT.Forms.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberCAT.Forms
{
    public partial class HexEditorForm : Form
    {
        public byte[] Data;
        ByteProvider _byteProvider;
        public HexEditorForm()
        {
            InitializeComponent();
        }
        public HexEditorForm(byte[] editData)
        {
            InitializeComponent();
            _byteProvider = new ByteProvider(editData);
            hexBox.ByteProvider = _byteProvider;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            _byteProvider.ApplyChanges();
            Data = _byteProvider.Data;
        }
    }
}
