using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
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
using CyberCAT.Core;
using CyberCAT.Core.Annotations;
using CyberCAT.Core.Classes;
using CyberCAT.Core.Classes.DumpedClasses;
using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;
using CyberCAT.Wpf.Classes;

namespace CyberCAT.Wpf
{
    /// <summary>
    /// Interaktionslogik für ItemEditor.xaml
    /// </summary>
    public partial class ItemEditor : UserControl, INotifyPropertyChanged
    {
        private ItemData _item;

        public SaveFile SaveFile
        {
            get => (SaveFile)GetValue(SaveFileProperty);
            set => SetValue(SaveFileProperty, value);
        }
        public static readonly DependencyProperty SaveFileProperty = DependencyProperty.Register("SaveFile", typeof(SaveFile), typeof(ItemEditor), new PropertyMetadata(null));

        public ItemData Item
        {
            get => _item;
            set
            {
                _item = value;
                if (_item != null && SaveFile != null)
                {
                    var statsNode = SaveFile.Nodes.FirstOrDefault(n => n.Name == Constants.NodeNames.STATS_SYSTEM);
                    if (statsNode == null)
                    {
                        _mapStructure = null;
                        return;
                    }
                    var rootData = (GenericUnknownStruct)statsNode.Value;
                    var mapStructure = rootData.ClassList[0];
                    _mapStructure = mapStructure as GameStatsStateMapStructure ?? throw new Exception("Unexpected Structure");
                }
                OnPropertyChanged();
                OnPropertyChanged(nameof(ControlVisibility));
                OnPropertyChanged(nameof(SelectTextVisibility));
                OnPropertyChanged(nameof(SimpleItem));
                OnPropertyChanged(nameof(IsSimpleItem));
                OnPropertyChanged(nameof(ModableItem));
                OnPropertyChanged(nameof(IsModableItem));
                OnPropertyChanged(nameof(ItemWithQuantity));
                OnPropertyChanged(nameof(IsItemWithQuantity));
                OnPropertyChanged(nameof(SelectedItemStats));
            }
        }

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
            ModCategory.SelectedIndex = 0;
            ModToAdd.SelectedIndex = 0;
            IntoAttachmentSlot.SelectedIndex = 0;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #region "Item mod handling"
        public ObservableCollection<string> ModCategories { get; } = new()
        {
            "Clothing mods",
            "Weapon mods",
        };

        public List<ItemData.ItemModData> AddableMods { get; set; } = TweakDb.ClothingMods;
        public List<TweakDbId> AttachmentSlots { get; set; } = TweakDb.ClothingAttachmentSlots;

        private static readonly Random Random = new Random();

        private GameStatsStateMapStructure _mapStructure;

        public void OnModCategoryChanged(object sender, SelectionChangedEventArgs e)
        {
            var selected = (string)ModCategory.SelectedItem;
            AddableMods = selected switch
            {
                "Clothing mods" => TweakDb.ClothingMods,
                "Weapon mods" => TweakDb.WeaponMods,
                _ => AddableMods
            };
            AttachmentSlots = selected switch
            {
                "Clothing mods" => TweakDb.ClothingAttachmentSlots,
                "Weapon mods" => TweakDb.WeaponAttachmentSlots,
                _ => AttachmentSlots
            };
            OnPropertyChanged(nameof(AddableMods));
            OnPropertyChanged(nameof(AttachmentSlots));
            ModToAdd.SelectedIndex = 0;
            IntoAttachmentSlot.SelectedIndex = 0;
        }

        public void OnAddModClicked(object sender, RoutedEventArgs e)
        {
            if (!IsModableItem)
            {
                // Not a modable item, there should not even be a button.
                return;
            }

            if (ModToAdd.SelectedItem == null || IntoAttachmentSlot.SelectedItem == null)
            {
                return;
            }
            var modToAdd = ((ItemData.ItemModData)ModToAdd.SelectedItem).Clone();
            var slot = ((TweakDbId)IntoAttachmentSlot.SelectedItem).Clone();

            modToAdd.AttachmentSlotTdbId = slot;
            var bytes = new byte[4];
            uint seed;
            while (true)
            {
                Random.NextBytes(bytes);
                seed = BitConverter.ToUInt32(bytes, 0);
                if (seed == 2)
                {
                    // Do not use the "simple item" seed
                    continue;
                }
                // Check if seed already in use
                if (_mapStructure.Values.FirstOrDefault(_ => _.Seed == seed) == null)
                {
                    break;
                }
            }
            modToAdd.Header.Seed = seed;

            ModableItem.RootNode.Children.Add(modToAdd);
        }

        public void OnDeleteModClicked(object sender, RoutedEventArgs e)
        {
            if (!IsModableItem)
            {
                // Not a modable item, there should not even be a button.
                return;
            }

            var selectedItem = ((Button)sender).Tag as ItemData.ItemModData;
            if (selectedItem == null)
            {
                return;
            }

            ModableItem.RootNode.Children.Remove(selectedItem);
        }
        #endregion

        #region "Item stat handling"

        public class HandleWrapper
        {
            public Handle<GameStatModifierData> Handle { get; }
            public HandleWrapper(Handle<GameStatModifierData> handle)
            {
                Handle = handle;
            }

            public IEnumerable<Core.DumpedEnums.gameStatModifierType> ModifierTypes => Enum.GetValues(typeof(Core.DumpedEnums.gameStatModifierType)).Cast<Core.DumpedEnums.gameStatModifierType>();
            public IEnumerable<Core.DumpedEnums.gamedataStatType> StatTypes => Enum.GetValues(typeof(Core.DumpedEnums.gamedataStatType)).Cast<Core.DumpedEnums.gamedataStatType>();

            public bool IsConstantModifier => Handle.Value is GameConstantStatModifierData;
            public GameConstantStatModifierData ConstantStatModifier => (GameConstantStatModifierData) Handle.Value;
        }

        public TweakDbId SelectedPartTweakDbId => Item?.ItemTdbId;
        public uint? SelectedPartSeed => Item?.Header.Seed;
        public IEnumerable<HandleWrapper> SelectedItemStats => _mapStructure?.Values.FirstOrDefault(v => v.RecordID.Equals(SelectedPartTweakDbId) && SelectedPartSeed.HasValue && v.Seed == SelectedPartSeed.Value)?.StatModifiers.Select(_ => new HandleWrapper(_));

        #endregion
    }
}
