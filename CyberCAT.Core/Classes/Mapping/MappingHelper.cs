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
        internal static TypeCache BasicTypes { get; private set; }
        internal static TypeCache DumpedClasses { get; private set; }
        internal static TypeCache DumpedEnums { get; private set; }
        internal static ConcurrentDictionary<string, string> RealNameCache { get; private set; }
        internal static ConcurrentDictionary<string, RealTypeAttribute> RealTypeCache { get; private set; }
        internal static ConcurrentDictionary<PropertyInfo, object> DefaultValueCache { get; private set; }
        internal static HashSet<PropertyInfo> IgnoredCache { get; private set; }


        private static readonly ConcurrentDictionary<PropertyInfo, PropertyHelper> PropertyHelpers = new ConcurrentDictionary<PropertyInfo, PropertyHelper>();

        internal static void Init()
        {
            LoadBasicTypes();
            LoadDumpedClasses();
            LoadDumpedEnums();
            BuildCache();
        }

        internal static void LoadBasicTypes()
        {
            BasicTypes = new TypeCache();
            BasicTypes.Add("Int8", typeof(sbyte));
            BasicTypes.Add("Uint8", typeof(byte));
            BasicTypes.Add("Int16", typeof(short));
            BasicTypes.Add("Uint16", typeof(ushort));
            BasicTypes.Add("Int32", typeof(int));
            BasicTypes.Add("Uint32", typeof(uint));
            BasicTypes.Add("Int64", typeof(long));
            BasicTypes.Add("Uint64", typeof(ulong));
            BasicTypes.Add("Float", typeof(float));
            BasicTypes.Add("Bool", typeof(bool));
            BasicTypes.Add("String", typeof(string));
            BasicTypes.Add("CName", typeof(CName));
            BasicTypes.Add("NodeRef", typeof(NodeRef));
            BasicTypes.Add("TweakDBID", typeof(TweakDbId));
            BasicTypes.FinalizeCache();
        }

        internal static void LoadDumpedClasses()
        {
            var type = typeof(GenericUnknownStruct.BaseClassEntry);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => p.Namespace != null && p.Namespace.StartsWith("CyberCAT.Core.Classes.DumpedClasses") && type.IsAssignableFrom(p) && p.IsClass);

            DumpedClasses = new TypeCache();
            foreach (var type1 in types)
            {
                var attr = (RealNameAttribute[])type1.GetCustomAttributes(typeof(RealNameAttribute), true);
                if (attr.Length > 0)
                {
                    DumpedClasses.Add(attr[0].Name, type1);
                }
            }

            DumpedClasses.FinalizeCache();
        }

        internal static void LoadDumpedEnums()
        {
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => p.Namespace == "CyberCAT.Core.DumpedEnums" && p.IsEnum);

            DumpedEnums = new TypeCache();
            foreach (var type in types)
            {
                DumpedEnums.Add(type.Name, type);
            }

            DumpedEnums.FinalizeCache();
        }

        internal static void BuildCache()
        {
            RealNameCache = new ConcurrentDictionary<string, string>();
            RealTypeCache = new ConcurrentDictionary<string, RealTypeAttribute>();
            DefaultValueCache = new ConcurrentDictionary<PropertyInfo, object>();
            IgnoredCache = new HashSet<PropertyInfo>();
            

            for (int i = 0; i < DumpedClasses.Length; i++)
            {
                var className = (RealNameAttribute)Attribute.GetCustomAttribute(DumpedClasses[i].Type, typeof(RealNameAttribute));
                if (className != null)
                    RealNameCache.TryAdd(DumpedClasses[i].Type.Name, className.Name);

                foreach (var propertyInfo in DumpedClasses[i].Type.GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly))
                {
                    var name = string.Join(".", propertyInfo.DeclaringType.Name, propertyInfo.Name);
                    foreach (var attr in Attribute.GetCustomAttributes(propertyInfo))
                    {
                        if (attr is RealNameAttribute nameAttr)
                            RealNameCache.TryAdd(name, nameAttr.Name);

                        if (attr is RealTypeAttribute typeAttr)
                            RealTypeCache.TryAdd(name, typeAttr);

                        if (attr is ParserIgnoreAttribute)
                            IgnoredCache.Add(propertyInfo);
                    }
                }
            }
        }

        internal static PropertyHelper GetPropertyHelper(PropertyInfo propertyInfo)
        {
            if (!PropertyHelpers.ContainsKey(propertyInfo))
                PropertyHelpers.TryAdd(propertyInfo, new PropertyHelper(propertyInfo));
            return PropertyHelpers[propertyInfo];
        }
    }
}