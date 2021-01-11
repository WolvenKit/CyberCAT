using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CyberCAT.Core.Annotations;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Wpf
{
    /// <summary>
    /// Interaktionslogik für ItemEditor.xaml
    /// </summary>
    public partial class ItemEditor : UserControl, INotifyPropertyChanged
    {
        private ItemData _item;

        public ItemData Item
        {
            get => _item;
            set
            {
                _item = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ControlVisibility));
                OnPropertyChanged(nameof(SelectTextVisibility));
                OnPropertyChanged(nameof(SimpleItem));
                OnPropertyChanged(nameof(IsSimpleItem));
                OnPropertyChanged(nameof(ModableItem));
                OnPropertyChanged(nameof(IsModableItem));
                OnPropertyChanged(nameof(ItemWithQuantity));
                OnPropertyChanged(nameof(IsItemWithQuantity));
            }
        }

        [DependsOn(nameof(Item))]
        public Visibility ControlVisibility => _item == null ? Visibility.Hidden : Visibility.Visible;
        public Visibility SelectTextVisibility => _item != null ? Visibility.Hidden : Visibility.Visible;
        public ItemData.SimpleItemData SimpleItem => _item?.Data as ItemData.SimpleItemData;
        public bool IsSimpleItem => SimpleItem != null;
        public ItemData.ModableItemData ModableItem => _item?.Data as ItemData.ModableItemData;
        public bool IsModableItem => ModableItem != null;
        public ItemData.IItemWithQuantity ItemWithQuantity => _item?.Data as ItemData.IItemWithQuantity;
        public bool IsItemWithQuantity => ItemWithQuantity != null;

        public ItemEditor()
        {
            InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
