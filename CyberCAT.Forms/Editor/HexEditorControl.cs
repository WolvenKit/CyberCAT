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
        private DefaultRepresentation _data;

        public HexEditorControl(DefaultRepresentation data)
        {
            _data = data;
            InitializeComponent();

            var byteviewer = new ByteViewer();
            byteviewer.Dock = DockStyle.Fill;
            if (data.Blob == null)
            {
                byteviewer.SetBytes(new byte[] {});
            }
            else
            {
                byteviewer.SetBytes(data.Blob);
            }

            byteviewer.SetDisplayMode(DisplayMode.Hexdump);

            Controls.Add(byteviewer);
        }
    }
}
