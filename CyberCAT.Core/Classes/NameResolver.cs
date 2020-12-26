using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberCAT.Core.Classes
{
    
    public static class NameResolver
    {
        static Dictionary<ulong, string> _items = new Dictionary<ulong, string>();
        public static string GetName(ulong hash)
        {
            if (_items.ContainsKey(hash))
            {
                return _items[hash];
            }
            return $"Unknown_{hash}";
        }
        public static void UseDictionary(Dictionary<ulong, string> dictionary)
        {
            _items = dictionary;
        }
    }
    
}
