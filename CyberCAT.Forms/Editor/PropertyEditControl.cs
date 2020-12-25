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
        private static readonly Dictionary<Type, Type> DisplayTypes = new Dictionary<Type, Type>()
        {
            { typeof(CharacterCustomizationAppearances), typeof(CharacterCustomizationAppearancesDisplay) },
            { typeof(ItemData), typeof(ItemDataDisplay) },
            { typeof(Inventory), typeof(InventoryDisplay) },
        };

        public PropertyEditControl(object data)
        {
            InitializeComponent();
            var propertyGrid = new PropertyGrid  {Dock = DockStyle.Fill };

            if (!DisplayTypes.TryGetValue(data.GetType(), out var displayType))
            {
                return;
            }

            var displayInstance = Activator.CreateInstance(displayType, data);
            propertyGrid.SelectedObject = displayInstance;
            Controls.Add(propertyGrid);
        }
    }
}
