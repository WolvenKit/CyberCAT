using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping
{
    public class MappingHelper
    {
        internal static Dictionary<string, Type> GetMappings(string nameSpace)
        {
            var type = typeof(GenericUnknownStruct.BaseClassEntry);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => p.Namespace == nameSpace && type.IsAssignableFrom(p) && p.IsClass);

            Dictionary<string, Type> typeDictionary = new Dictionary<string, Type>();
            foreach (var type1 in types)
            {
                var attr = (RealNameAttribute[])type1.GetCustomAttributes(typeof(RealNameAttribute), true);
                if (attr.Length > 0)
                {
                    typeDictionary.Add(attr[0].Name, type1);
                }
            }

            return typeDictionary;
        }
    }
}