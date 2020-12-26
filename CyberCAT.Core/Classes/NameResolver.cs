using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Core.Classes
{
    
    public static class NameResolver
    {
        static Dictionary<uint, string> _items = new Dictionary<uint, string>();
        public static string GetName(uint hash)
        {
            if (_items.ContainsKey(hash))
            {
                return _items[hash];
            }
            return $"Unknown_{hash}";
        }
        public static void UseDictionary(Dictionary<uint, string> dictionary)
        {
            _items = dictionary;
        }
    }
    
}
