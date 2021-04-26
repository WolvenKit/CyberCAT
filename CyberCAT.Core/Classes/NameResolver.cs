using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CyberCAT.Core.Classes.Interfaces;

namespace CyberCAT.Core.Classes
{
    
    public static class NameResolver
    {
        public static string GetName(TweakDbId tdbid)
        {
            if (tdbid == null)
            {
                return "<null>";
            }
            return TweakDbResolver?.GetName(tdbid) ?? $"Unknown_{tdbid}";
        }

        public static string GetGameName(TweakDbId tdbid)
        {
            if (tdbid == null)
            {
                return "<null>";
            }
            return TweakDbResolver?.GetGameName(tdbid) ?? "";
        }

        public static string GetGameDescription(TweakDbId tdbid)
        {
            if (tdbid == null)
            {
                return "<null>";
            }
            return TweakDbResolver?.GetGameDescription(tdbid) ?? "";
        }

        public static ulong GetHash(string itemName)
        {
            return TweakDbResolver?.GetHash(itemName) ?? 0;
        }

        public static ITweakDbResolver TweakDbResolver { get; set; }
    }
    
}
