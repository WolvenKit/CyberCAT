using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CyberCAT.Core.Classes.NodeRepresentations;
using CyberCAT.Core.Classes;

namespace CyberCAT.Forms.Editor
{
    public partial class GameSessionConfigControl : UserControl
    {
        public GameSessionConfigControl(GameSessionConfig data, SaveFile saveFile)
        {
            InitializeComponent();

            hash1.Text = $"{data.Hash1:X}";
            hash2.Text = $"{data.Hash2:X}";
            hash3.Text = $"{data.Hash3:X}";
            textValue.Text = data.TextValue;
        }
    }
}
