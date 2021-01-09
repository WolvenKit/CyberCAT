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

namespace CyberCAT.Forms.Editor
{
    public partial class ItemEditorControl : UserControl
    {
        private GenericUnknownStruct _rootData;

        SaveFile _saveFile;
        ItemData _itemData;
        Handle<GameStatModifierData>[] _gameStatModifierData;
        GameStatsStateMapStructure _mapStructure;

        private uint SelectedPartSeed { get; set; }
        private TweakDbId SelectedPartTweakDbId { get; set; }

        public ItemEditorControl(object data, SaveFile saveFile)
        {
            if (!(data is ItemData))
            {
                throw new Exception("Unexpected data type");
            }
            InitializeComponent();

            _saveFile = saveFile;
            var parts = new List<ItemData.ItemModData>();
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
                
                parts.Add(mid.RootNode);
                foreach (var part in mid.RootNode.Children)
                {
                    parts.Add(part);
                }

                partListBox.Items.Add("<Item>");
                partListBox.Items.AddRange(parts.ToArray());

                SelectedPartSeed = _itemData.Header.ItemId;
                SelectedPartTweakDbId = _itemData.ItemTdbId;

                FillStatsList();
            }
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
            var statsNode = _saveFile.Nodes.FirstOrDefault(n => n.Name == Constants.NodeNames.STATS_SYSTEM);
            statsSelect.Items.Clear();
            editPanel.Controls.Clear();
            if (statsNode != null)
            {
                _rootData = (GenericUnknownStruct) statsNode.Value;
                var mapStructure = _rootData.ClassList[0];

                _mapStructure = mapStructure as GameStatsStateMapStructure ?? throw new Exception("Unexpected Structure");

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
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = partListBox.SelectedItem;
            if (selected is string)
            {
                SelectedPartSeed = _itemData.Header.ItemId;
                SelectedPartTweakDbId = _itemData.ItemTdbId;
            }
            else if (selected is ItemData.ItemModData imd)
            {
                SelectedPartSeed = imd.Header.ItemId;
                SelectedPartTweakDbId = imd.ItemTdbId;
            }
            FillStatsList();
        }

        private void addStatButton_Click(object sender, EventArgs e)
        {
            statsSelect.Items.Clear();
            editPanel.Controls.Clear();
            var stats = _gameStatModifierData.ToList();
            var statsData = _mapStructure.Values.Where(v => v.RecordID.Equals(_itemData.ItemTdbId)).FirstOrDefault();

            stats.Add(_rootData.CreateHandle<GameStatModifierData>(new GameConstantStatModifierData()));
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
                var propEditor = new PropertyEditControl(statsData, _saveFile);
                propEditor.AutoSize = true;
                propEditor.Dock = DockStyle.Fill;
                /*
                var editForm = new Form();
                editForm.Controls.Add(propEditor);
                editForm.AutoSize = true;
                editForm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                editForm.ShowDialog();
                */
                editPanel.Controls.Clear();
                editPanel.Controls.Add(propEditor);

                /*
                statsSelect.Items.Clear();
                foreach (var modifier in _gameStatModifierData)
                {
                    statsSelect.Items.Add(new HandleWrapper(modifier));
                }
                */
            }
        }
    }
}
