using System;
using System.Collections.Generic;
using System.Linq;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping
{
    public class MappingHelper
    {
        internal static Dictionary<string, Type> DumpedClasses { get; private set; }

        internal static Dictionary<string, Type> DumpedEnums { get; private set; }

        internal static void LoadDumpedClasses()
        {
            var type = typeof(GenericUnknownStruct.BaseClassEntry);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => p.Namespace != null && p.Namespace.StartsWith("CyberCAT.Core.Classes.DumpedClasses") && type.IsAssignableFrom(p) && p.IsClass);

            DumpedClasses = new Dictionary<string, Type>();
            foreach (var type1 in types)
            {
                var attr = (RealNameAttribute[])type1.GetCustomAttributes(typeof(RealNameAttribute), true);
                if (attr.Length > 0)
                {
                    DumpedClasses.Add(attr[0].Name, type1);
                }
            }
        }

        internal static void LoadDumpedEnums()
        {
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => p.Namespace == "CyberCAT.Core.DumpedEnums" && p.IsEnum);

            DumpedEnums = new Dictionary<string, Type>();
            foreach (var type in types)
            {
                DumpedEnums.Add(type.Name, type);
            }
        }
    }
}