using CyberCAT.Core;
using CyberCAT.Core.Classes;
using CyberCAT.Core.Classes.NodeRepresentations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using CyberCAT.Core.Classes.DumpedClasses;
using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.DumpedEnums;
using Newtonsoft.Json.Converters;

namespace CyberCAT.Forms.Editor
{
    public partial class ItemEditorControl : UserControl
    {
        private readonly GenericUnknownStruct _rootData;
        private readonly SaveFile _saveFile;
        private readonly ItemData _itemData;
        private Handle<GameStatModifierData>[] _gameStatModifierData;
        private readonly GameStatsStateMapStructure _mapStructure;

        private uint SelectedPartSeed { get; set; }
        private TweakDbId SelectedPartTweakDbId { get; set; }

        private static Random _random = new Random();

        private static readonly List<TweakDbId> AttachmentSlots = new List<TweakDbId>
        {
            TweakDbId.FromName("AttachmentSlots.OuterChestFabricEnhancer1"),
            TweakDbId.FromName("AttachmentSlots.OuterChestFabricEnhancer2"),
            TweakDbId.FromName("AttachmentSlots.OuterChestFabricEnhancer3"),
            TweakDbId.FromName("AttachmentSlots.OuterChestFabricEnhancer4"),
            TweakDbId.FromName("AttachmentSlots.InnerChestFabricEnhancer1"),
            TweakDbId.FromName("AttachmentSlots.InnerChestFabricEnhancer2"),
            TweakDbId.FromName("AttachmentSlots.InnerChestFabricEnhancer3"),
            TweakDbId.FromName("AttachmentSlots.InnerChestFabricEnhancer4"),
            TweakDbId.FromName("AttachmentSlots.LegsFabricEnhancer1"),
            TweakDbId.FromName("AttachmentSlots.LegsFabricEnhancer2"),
            TweakDbId.FromName("AttachmentSlots.LegsFabricEnhancer3"),
            TweakDbId.FromName("AttachmentSlots.LegsFabricEnhancer4"),
            TweakDbId.FromName("AttachmentSlots.FaceFabricEnhancer1"),
            TweakDbId.FromName("AttachmentSlots.FaceFabricEnhancer2"),
            TweakDbId.FromName("AttachmentSlots.FaceFabricEnhancer3"),
            TweakDbId.FromName("AttachmentSlots.FaceFabricEnhancer4"),
            TweakDbId.FromName("AttachmentSlots.FootFabricEnhancer1"),
            TweakDbId.FromName("AttachmentSlots.FootFabricEnhancer2"),
            TweakDbId.FromName("AttachmentSlots.FootFabricEnhancer3"),
            TweakDbId.FromName("AttachmentSlots.FootFabricEnhancer4"),
            TweakDbId.FromName("AttachmentSlots.HeadFabricEnhancer1"),
            TweakDbId.FromName("AttachmentSlots.HeadFabricEnhancer2"),
            TweakDbId.FromName("AttachmentSlots.HeadFabricEnhancer3"),
            TweakDbId.FromName("AttachmentSlots.HeadFabricEnhancer4"),
        };

        private static readonly List<ItemData.ItemModData> AddableMods = new List<ItemData.ItemModData>
        {
            new ItemData.ItemModData // Armadilo
            {
                ItemTdbId = TweakDbId.FromName("Items.SimpleFabricEnhancer01"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // Resist!
            {
                ItemTdbId = TweakDbId.FromName("Items.SimpleFabricEnhancer02"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // Fortuna
            {
                ItemTdbId = TweakDbId.FromName("Items.SimpleFabricEnhancer03"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // Bully
            {
                ItemTdbId = TweakDbId.FromName("Items.SimpleFabricEnhancer04"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // Backpacker
            {
                ItemTdbId = TweakDbId.FromName("Items.SimpleFabricEnhancer05"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // Footloose
            {
                ItemTdbId = TweakDbId.FromName("Items.SimpleFabricEnhancer06"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // Showtime
            {
                ItemTdbId = TweakDbId.FromName("Items.SimpleFabricEnhancer07"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // Osmosis
            {
                ItemTdbId = TweakDbId.FromName("Items.SimpleFabricEnhancer09"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // Plume
            {
                ItemTdbId = TweakDbId.FromName("Items.SimpleFabricEnhancer10"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // Zero drag
            {
                ItemTdbId = TweakDbId.FromName("Items.SimpleFabricEnhancer11"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // Tenacity
            {
                ItemTdbId = TweakDbId.FromName("Items.SimpleFabricEnhancer12"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // Vanguard
            {
                ItemTdbId = TweakDbId.FromName("Items.SimpleFabricEnhancer13"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // Boom Breaker
            {
                ItemTdbId = TweakDbId.FromName("Items.SimpleFabricEnhancer14"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // Crunch
            {
                ItemTdbId = TweakDbId.FromName("Items.SimpleWeaponMod01"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // Penetrator
            {
                ItemTdbId = TweakDbId.FromName("Items.SimpleWeaponMod02"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // Pacifier
            {
                ItemTdbId = TweakDbId.FromName("Items.SimpleWeaponMod03"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // Combat Amplifier
            {
                ItemTdbId = TweakDbId.FromName("Items.SimpleWeaponMod04"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
        };

        public ItemEditorControl(object data, SaveFile saveFile)
        {
            if (!(data is ItemData))
            {
                throw new Exception("Unexpected data type");
            }
            InitializeComponent();

            cbAttachmentSlot.DisplayMember = "Name";

            _saveFile = saveFile;
            _itemData = (ItemData)data;

            lblGameName.Text = NameResolver.GetGameName(_itemData.ItemTdbId);
            lblItemName.Text = NameResolver.GetName(_itemData.ItemTdbId);
            cbQuestItem.Checked = _itemData.Flags.IsQuestItem;
            cbUnequippable.Checked = _itemData.Flags.IsNotUnequippable;
            nudQuantity.Maximum = uint.MaxValue;

            if (_itemData.Data is ItemData.SimpleItemData sid)
            {
                nudQuantity.Enabled = true;
                nudQuantity.Value = sid.Quantity;
            }
            else if (_itemData.Data is ItemData.ModableItemWithQuantityData miwqd)
            {
                nudQuantity.Enabled = true;
                nudQuantity.Value = miwqd.Quantity;
            }

            if (_itemData.Data is ItemData.ModableItemData mid)
            {
                partListBox.Enabled = true;
                statsSelect.Enabled = true;
                addStatButton.Enabled = true;
                cbAttachmentSlot.Enabled = true;
                cbAttachmentSlot.Items.AddRange(AttachmentSlots.ToArray());
                cbAttachmentSlot.SelectedItem = 0;
                cbMod.Enabled = true;
                cbMod.Items.AddRange(AddableMods.ToArray());
                cbMod.SelectedIndex = 0;

                FillPartsList(mid);

                SelectedPartSeed = _itemData.Header.Seed;
                SelectedPartTweakDbId = _itemData.ItemTdbId;

                var statsNode = _saveFile.Nodes.FirstOrDefault(n => n.Name == Constants.NodeNames.STATS_SYSTEM);
                if (statsNode == null)
                {
                    return;
                }
                _rootData = (GenericUnknownStruct)statsNode.Value;
                var mapStructure = _rootData.ClassList[0];
                _mapStructure = mapStructure as GameStatsStateMapStructure ?? throw new Exception("Unexpected Structure");

                FillStatsList();
            }
        }

        private void FillPartsList(ItemData.ModableItemData mid)
        {
            var parts = new List<ItemData.ItemModData>();
            //parts.Add(mid.RootNode);
            foreach (var part in mid.RootNode.Children)
            {
                parts.Add(part);
            }

            partListBox.Items.Clear();
            partListBox.Items.Add("<Item>");
            partListBox.Items.AddRange(parts.ToArray());
        }

        private class HandleWrapper
        {
            public Handle<GameStatModifierData> Handle { get; }
            public HandleWrapper(Handle<GameStatModifierData> handle)
            {
                Handle = handle;
            }

            public override string ToString()
            {
                var value = "";
                if (Handle.Value is GameConstantStatModifierData co)
                {
                    value = $"{co.Value}";
                }
                else if (Handle.Value is GameCurveStatModifierData cu)
                {
                    value = $"{cu.CurveStat} {cu.CurveName}";
                }
                else if (Handle.Value is GameCombinedStatModifierData com)
                {
                    value = $"{com.Value} {com.Operation}";
                }
                return $"{Handle.Value.ModifierType} {value} {Handle.Value.StatType}";
            }
        }

        private void FillStatsList()
        {
            statsSelect.Items.Clear();
            editPanel.Controls.Clear();

            var statsData = _mapStructure.Values.Where(v => v.RecordID.Equals(SelectedPartTweakDbId) && v.Seed == SelectedPartSeed);
            _gameStatModifierData = statsData.FirstOrDefault()?.StatModifiers;
            if (_gameStatModifierData == null)
            {
                return;
            }

            foreach (var modifier in _gameStatModifierData)
            {
                statsSelect.Items.Add(new HandleWrapper(modifier));
            }
            statsSelect.SelectedIndex = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = partListBox.SelectedItem;
            if (selected is string)
            {
                SelectedPartSeed = _itemData.Header.Seed;
                SelectedPartTweakDbId = _itemData.ItemTdbId;
            }
            else if (selected is ItemData.ItemModData imd)
            {
                SelectedPartSeed = imd.Header.Seed;
                SelectedPartTweakDbId = imd.ItemTdbId;
            }
            FillStatsList();
        }

        private void addStatButton_Click(object sender, EventArgs e)
        {
            statsSelect.Items.Clear();
            editPanel.Controls.Clear();
            var stats = _gameStatModifierData?.ToList() ?? new List<Handle<GameStatModifierData>>();

            var statsData = _mapStructure.Values.FirstOrDefault(v => v.RecordID.Equals(_itemData.ItemTdbId) && v.Seed == SelectedPartSeed);

            if (statsData == null)
            {
                return;
            }

            var newHandle = _rootData.CreateHandle<GameStatModifierData>(new GameConstantStatModifierData { ModifierType = gameStatModifierType.Additive, StatType = gamedataStatType.PowerLevel, Value = 1});

            stats.Add(newHandle);
            _gameStatModifierData = stats.ToArray();
            statsData.StatModifiers = _gameStatModifierData;

            foreach (var modifier in _gameStatModifierData)
            {
                statsSelect.Items.Add(new HandleWrapper(modifier));
            }

            statsSelect.SelectedIndex = 0;
        }

        private void cbQuestItem_CheckedChanged(object sender, EventArgs e)
        {
            _itemData.Flags.IsQuestItem = cbQuestItem.Checked;
        }

        private void cbUnequippable_CheckedChanged(object sender, EventArgs e)
        {
            _itemData.Flags.IsNotUnequippable = cbUnequippable.Checked;
        }

        private void nudQuantity_ValueChanged(object sender, EventArgs e)
        {
            if (_itemData.Data is ItemData.SimpleItemData sid)
            {
                sid.Quantity = (uint) nudQuantity.Value;
            }
            else if (_itemData.Data is ItemData.ModableItemWithQuantityData miwqd)
            {
                miwqd.Quantity = (uint)nudQuantity.Value;
            }
        }

        private void statsSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statsSelect.SelectedItem != null)
            {
                var wrapper = (HandleWrapper)statsSelect.SelectedItem;
                var statsData = wrapper.Handle.Value;
                var propEditor = new PropertyEditControl(statsData, _saveFile) {AutoSize = true, Dock = DockStyle.Fill};
                editPanel.Controls.Clear();
                editPanel.Controls.Add(propEditor);
            }
        }

        private void btnAddMod_Click(object sender, EventArgs e)
        {
            var modToAdd = ((ItemData.ItemModData) cbMod.SelectedItem).Clone();
            var slot = (TweakDbId) cbAttachmentSlot.SelectedItem;

            modToAdd.AttachmentSlotTdbId = slot;
            var bytes = new byte[4];
            uint seed;
            while (true)
            {
                _random.NextBytes(bytes);
                seed = BitConverter.ToUInt32(bytes, 0);
                if (seed == 2)
                {
                    continue;
                }
                // Check if seed already in use
                if (_mapStructure.Values.FirstOrDefault(_ => _.Seed == seed) == null)
                {
                    break;
                }
            }
            modToAdd.Header.Seed = seed;

            var mid = (ItemData.ModableItemData) _itemData.Data;
            mid.RootNode.Children.Add(modToAdd);

            FillPartsList(mid);
        }
    }
}
