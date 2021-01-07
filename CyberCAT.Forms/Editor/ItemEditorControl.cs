using CyberCAT.Core;
using CyberCAT.Core.Classes;
using CyberCAT.Core.Classes.NodeRepresentations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CyberCAT.Core.Classes.DumpedClasses;
using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Forms.Editor
{
    public partial class ItemEditorControl : UserControl
    {
        SaveFile _saveFile;
        ItemData _itemData;
        Handle<GameStatModifierData>[] _gameStatModifierData;
        GameStatsStateMapStructure _mapStructure;
        public ItemEditorControl(object data, SaveFile saveFile)
        {
            var type = data.GetType();
            InitializeComponent();
            if (data is ItemData)
            {
                _saveFile = saveFile;
                var parts = new List<ItemData.ItemModData>();
                _itemData = (ItemData)data;
                if(_itemData.Data is ItemData.ModableItemData itemData)
                {
                    parts.Add(itemData.RootNode);
                    foreach(var part in itemData.RootNode.Children)
                    {
                        parts.Add(part);
                    }
                    partListBox.Items.AddRange(parts.ToArray());
                    FillStatsList();

                }
                itemNameLabel.Text = NameResolver.GetName(_itemData.ItemTdbId);

            }
            else
            {
                throw new Exception("Unexected data type");
            }
        }
        private void FillStatsList()
        {
            var statsNode = _saveFile.Nodes.FirstOrDefault(n => n.Name == Constants.NodeNames.STATS_SYSTEM);
            if (statsNode != null)
            {
                var mapStructure = ((GenericUnknownStruct)statsNode.Value).ClassList[0];
                
                if (!(mapStructure is GameStatsStateMapStructure))
                {
                    throw new Exception("Unexpected Structure");
                }
                _mapStructure = (GameStatsStateMapStructure)mapStructure;
                var statsData = _mapStructure.Values.Where(v => v.RecordID.Equals(_itemData.ItemTdbId) && v.Seed == _itemData.Header.ItemId);
                _gameStatModifierData = statsData.FirstOrDefault()?.StatModifiers;
                if (_gameStatModifierData != null)
                {
                    foreach (var modifier in _gameStatModifierData)
                    {
                        statsListBox.Items.Add(modifier);
                    }
                }
                

            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var part = (ItemData.ItemModData)partListBox.SelectedItem;
            
            
        }

        private void statsListBox_DoubleClick(object sender, EventArgs e)
        {
            if (statsListBox.SelectedItem != null)
            {
                var statsData = ((Handle<GameStatModifierData>)statsListBox.SelectedItem).Value;
                var propEditor = new PropertyEditControl(statsData, _saveFile);
                var editForm = new Form();
                editForm.Controls.Add(propEditor);
                editForm.AutoSize = true;
                editForm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                editForm.ShowDialog();

                statsListBox.Items.Clear();
                foreach (var modifier in _gameStatModifierData)
                {
                    statsListBox.Items.Add(modifier);
                }
            }
        }

        private void addStatButton_Click(object sender, EventArgs e)
        {
            statsListBox.Items.Clear();
            var stats = _gameStatModifierData.ToList();
            var statsData = _mapStructure.Values.Where(v => v.RecordID.Equals(_itemData.ItemTdbId)).FirstOrDefault();
            
            stats.Add(new Handle<GameStatModifierData>(new GameConstantStatModifierData()));
            _gameStatModifierData = stats.ToArray();
            statsData.StatModifiers = _gameStatModifierData;
            foreach (var modifier in _gameStatModifierData)
            {
                statsListBox.Items.Add(modifier);
            }
        }
    }
}
