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
using CyberCAT.Forms.Classes;

namespace CyberCAT.Forms.Editor
{
    public partial class PropertyEditControl : UserControl
    {
        public PropertyEditControl(object data)
        {
            InitializeComponent();
            var propertyGrid = new PropertyGrid
            {
                Dock = DockStyle.Fill,
                SelectedObject = data,
                PropertySort = PropertySort.NoSort
            };
            Controls.Add(propertyGrid);
        }
    }
}
