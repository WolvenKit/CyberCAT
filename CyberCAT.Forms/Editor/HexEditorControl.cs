using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Forms.Editor
{
    public partial class HexEditorControl : UserControl
    {
        public HexEditorControl(byte[] data)
        {
            InitializeComponent();

            var byteviewer = new ByteViewer();
            byteviewer.Dock = DockStyle.Fill;

            byteviewer.SetBytes(data);

            byteviewer.SetDisplayMode(DisplayMode.Hexdump);

            Controls.Add(byteviewer);
        }
    }
}
