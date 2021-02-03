using System.Collections.Generic;
using System.Linq;
using CyberCAT.Core.Classes;
using CyberCAT.Core.Classes.Interfaces;

namespace CyberCAT.Forms.Classes
{
    public class JsonResolver : ITweakDbResolver
    {
        private static Dictionary<ulong, NameStruct> _items = new Dictionary<ulong, NameStruct>();
        private static Dictionary<string, ulong> _nameToHash = new Dictionary<string, ulong>();

        public string GetName(TweakDbId tdbid)
        {
            if (tdbid == null)
            {
                return "<null>";
            }

            if (_items.ContainsKey(tdbid.Raw64))
            {
                return _items[tdbid.Raw64].Name;
            }

            return $"Unknown_{tdbid}";
        }

        public string GetGameName(TweakDbId tdbid)
        {
            if (tdbid == null)
            {
                return "<null>";
            }

            if (_items.ContainsKey(tdbid.Raw64))
            {
                return _items[tdbid.Raw64].GameName;
            }

            return $"";
        }

        public string GetGameDescription(TweakDbId tdbid)
        {
            if (tdbid == null)
            {
                return "<null>";
            }

            if (_items.ContainsKey(tdbid.Raw64))
            {
                return _items[tdbid.Raw64].GameDescription;
            }

            return $"";
        }

        public ulong GetHash(string itemName)
        {
            return _nameToHash.ContainsKey(itemName) ? _nameToHash[itemName] : 0;
        }

        public JsonResolver(Dictionary<ulong, NameStruct> dictionary)
        {
            _items = dictionary;
            _nameToHash = dictionary.ToDictionary(pair => pair.Value.Name, pair => pair.Key);
        }

        public struct NameStruct
        {
            public string Name { get; set; }
            public string GameName { get; set; }
            public string GameDescription { get; set; }
        }
    }
}