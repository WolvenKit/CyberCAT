using CyberCAT.Core.Classes.NodeRepresentations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CyberCAT.Core.Classes.Mapping.Global;
using CyberCAT.Core.Classes.Mapping.StatsSystem;

namespace CyberCAT.Core.Classes.NodeRepresentationWrappers
{
    public class StatsSystemWrapper
    {
        GenericUnknownStruct _sourceStruct;
        public IReadOnlyList<GameSavedStatsData> StatsData { get; private set; }
        public StatsSystemWrapper(GenericUnknownStruct source)
        {
            _sourceStruct = source;
            if (!(source.ClassList[0] is GameStatsStateMapStructure))
            {
                throw new Exception("Unexpected source structure");
            }
            var mapping = (GameStatsStateMapStructure)source.ClassList[0];
            var dict = new Dictionary<GameStatsObjectID, GameSavedStatsData>();
            int index = 0;
            foreach (var key in mapping.Keys)
            {
                dict[key] = mapping.Values[index];
                index++;
                var test = GetModifiersForEntry(dict[key]);
            }
        }
        public ModifierCollection GetModifiersForEntry(GameSavedStatsData entry)
        {
            var result= new ModifierCollection();
            if (entry.StatModifiers != null)
            {
                foreach (var reference in entry.StatModifiers)
                {
                    //var modifier = _sourceStruct.ClassList[reference];
                    //result.AddModifier(modifier, reference);
                }
            }
            return result;
        }
        public void UpdateModifiersForEntry(ModifierCollection modifiers, GameSavedStatsData entry)
        {
            foreach(var wrappedCombined in modifiers.CombinedStatModifiers)
            {
                if (wrappedCombined.NeedsAdding)
                {
                    var classList = _sourceStruct.ClassList.ToList();
                    classList.Add(wrappedCombined.CombinedStatData);
                    _sourceStruct.ClassList = classList.ToArray();
                    if (entry.StatModifiers != null)
                    {
                        var referenceList = entry.StatModifiers.ToList();
                        //referenceList.Add((uint)_sourceStruct.ClassList.Length - 1);
                        entry.StatModifiers = referenceList.ToArray();
                    }
                   
                }
            }
        }
        public class WrappedGameCombinedStatModifierData
        {
            public GameCombinedStatModifierData CombinedStatData {get;set;}
            public bool NeedsAdding { get; private set; }
            uint _reference;
            public WrappedGameCombinedStatModifierData(GameCombinedStatModifierData source, uint reference)
            {
                CombinedStatData = source;
                _reference = reference;
            }
            public uint GetReference()
            {
                return _reference;
            }
            public void UpdateReference(uint newReference)
            {
                _reference = newReference;
                NeedsAdding = false;
            }
        }
        public class WrappedGameConstantStatModifierData
        {
            public GameConstantStatModifierData ConstantStatData { get; set; }
            uint _reference;
            public WrappedGameConstantStatModifierData(GameConstantStatModifierData source, uint reference)
            {
                ConstantStatData = source;
                _reference = reference;
            }
            public uint GetReference()
            {
                return _reference;
            }
        }
        public class WrappedGameCurveStatModifierData
        {
            public GameCurveStatModifierData CurveStatData { get; set; }
            uint _reference;
            public WrappedGameCurveStatModifierData(GameCurveStatModifierData source, uint reference)
            {
                CurveStatData = source;
                _reference = reference;
            }
            public uint GetReference()
            {
                return _reference;
            }
        }
        public class ModifierCollection
        {
            public IReadOnlyList<WrappedGameCombinedStatModifierData> CombinedStatModifiers { get => _combinedStatModifiers; }
            public IReadOnlyList<WrappedGameConstantStatModifierData> ConstantStatModifiers { get => _constantStatModifiers; }
            public IReadOnlyList<WrappedGameCurveStatModifierData> CurveStatModifiers { get=> _curveStatModifiers;}

            private List<WrappedGameCombinedStatModifierData> _combinedStatModifiers;
            private List<WrappedGameConstantStatModifierData> _constantStatModifiers;
            private List<WrappedGameCurveStatModifierData> _curveStatModifiers;
            public ModifierCollection()
            {
                _combinedStatModifiers = new List<WrappedGameCombinedStatModifierData>();
                _constantStatModifiers = new List<WrappedGameConstantStatModifierData>();
                _curveStatModifiers = new List<WrappedGameCurveStatModifierData>();
            }
            public void AddModifier(GenericUnknownStruct.BaseClassEntry modifier, uint reference)
            {
                switch (modifier)
                {

                    case GameCombinedStatModifierData combinedModifier:
                        _combinedStatModifiers.Add(new WrappedGameCombinedStatModifierData(combinedModifier, reference));
                        break;
                    case GameConstantStatModifierData constantModifier:
                        _constantStatModifiers.Add(new WrappedGameConstantStatModifierData(constantModifier, reference));
                        break;
                    case GameCurveStatModifierData curveModifier:
                        _curveStatModifiers.Add(new WrappedGameCurveStatModifierData(curveModifier,reference));
                        break;
                    default:
                        break;
                }
            }
        }
    }

}
