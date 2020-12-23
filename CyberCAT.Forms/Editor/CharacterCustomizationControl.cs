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
    public partial class CharacterCustomizationControl : UserControl
    {
        private CharacterCustomizationAppearances _data;
        private Dictionary<string, ListViewGroup> _groups;

        public CharacterCustomizationControl(CharacterCustomizationAppearances data)
        {
            _data = data;
            _groups = new Dictionary<string, ListViewGroup>();
            InitializeComponent();
            var propertyGrid = new PropertyGrid();
            propertyGrid.Dock = DockStyle.Fill;

            propertyGrid.SelectedObject = new CharacterCustomizationAppearancesDisplay(_data);
            Controls.Add(propertyGrid);

        }
    }
}
