using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping
{
    public class MappingHelper
    {
        internal static Dictionary<string, Type> DumpedClasses { get; private set; }

        internal static Dictionary<string, Type> DumpedEnums { get; private set; }

        internal static ConcurrentDictionary<string, string> RealNameCache { get; private set; }
        internal static ConcurrentDictionary<string, RealTypeAttribute> RealTypeCache { get; private set; }
        internal static ConcurrentDictionary<string, object> DefaultValueCache { get; private set; }
        internal static HashSet<string> IgnoredCache { get; private set; }

        internal static void Init()
        {
            LoadDumpedClasses();
            LoadDumpedEnums();
            BuildCache();
        }

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

        internal static void BuildCache()
        {
            RealNameCache = new ConcurrentDictionary<string, string>();
            RealTypeCache = new ConcurrentDictionary<string, RealTypeAttribute>();
            DefaultValueCache = new ConcurrentDictionary<string, object>();
            IgnoredCache = new HashSet<string>();

            foreach (var type in DumpedClasses.Values)
            {
                var className = (RealNameAttribute) Attribute.GetCustomAttribute(type, typeof(RealNameAttribute));
                if (className != null)
                    RealNameCache.TryAdd(type.Name, className.Name);

                var nCls = Activator.CreateInstance(type);

                foreach (var propertyInfo in type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly))
                {
                    var name = $"{propertyInfo.DeclaringType.Name}.{propertyInfo.Name}";
                    foreach (var attr in Attribute.GetCustomAttributes(propertyInfo))
                    {
                        if (attr is RealNameAttribute nameAttr)
                            RealNameCache.TryAdd(name, nameAttr.Name);

                        if (attr is RealTypeAttribute typeAttr)
                            RealTypeCache.TryAdd(name, typeAttr);

                        if(attr is ParserIgnoreAttribute)
                            IgnoredCache.Add(name);
                    }
                }

                foreach (var propertyInfo in type.GetProperties())
                {
                    var name = $"{type.Name}.{propertyInfo.Name}";
                    var nVal = propertyInfo.GetValue(nCls);
                    DefaultValueCache.TryAdd(name, nVal);
                }
            }
        }
    }
}