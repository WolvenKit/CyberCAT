using System.Collections.Generic;

namespace CyberCAT.Core.Classes
{
    public class FactResolver
    {
        static Dictionary<ulong, string> _facts = new Dictionary<ulong, string>();
        public static string GetName(uint hash)
        {
            if (_facts.ContainsKey(hash))
            {
                return _facts[hash];
            }
            return $"Unknown_{hash:X}";
        }
        public static void UseDictionary(Dictionary<ulong, string> dictionary)
        {
            _facts = dictionary;
        }
    }
}