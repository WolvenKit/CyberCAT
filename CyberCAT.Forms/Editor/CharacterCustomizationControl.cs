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

            foreach (var ai in _data.Instances)
            {
                _groups.TryGetValue(ai.Group, out var group);
                if (group == null)
                {
                    group = new ListViewGroup(ai.Group);
                    _groups[ai.Group] = group;
                    tppList.Groups.Add(group);
                }
                tppList.Items.Add(new ListViewItem() { Text = $"{ai.Hash:X}", SubItems = { $"{ai.SecondString}", $"{ai.FirstString}" }, Group = group});
            }
            var helmetGroup = new ListViewGroup("Helmet Hair");
            tppList.Groups.Add(helmetGroup);
            tppList.Items.Add(new ListViewItem() { Text = "-", SubItems = { "Helmet Hair Color", $"{_data.HelmetHairColor}" }, Group = helmetGroup });
            tppList.Items.Add(new ListViewItem() { Text = "-", SubItems = { "Helmet Hair Length", $"{_data.HelmetHairLength}" }, Group = helmetGroup });

            tppList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
    }
}
