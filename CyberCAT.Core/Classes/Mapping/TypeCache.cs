using System;
using System.Collections.Generic;

namespace CyberCAT.Core.Classes.Mapping
{
    public class TypeCache
    {
        private List<TypeCacheEntry> _tmpList;
        private TypeCacheEntry[] _cache;

        public TypeCache()
        {
            _tmpList = new List<TypeCacheEntry>();
        }

        public void Add(string name, Type type)
        {
            _tmpList.Add(new TypeCacheEntry(name, type));
        }

        public void FinalizeCache()
        {
            _cache = _tmpList.ToArray();
            _tmpList = null;
        }

        public int Length => _cache.Length;

        public TypeCacheEntry this[int index]
        {
            get => _cache[index];
            set => _cache[index] = value;
        }

        public string GetKey(Type value)
        {
            for (var i = 0; i < _cache.Length; i++)
            {
                if (_cache[i].Type == value)
                    return _cache[i].Name;
            }

            return null;
        }

        public Type GetValue(string key)
        {
            for (var i = 0; i < _cache.Length; i++)
            {
                if (_cache[i].Name == key)
                    return _cache[i].Type;
            }

            return null;
        }

        public class TypeCacheEntry
        {
            public string Name;
            public Type Type;

            public TypeCacheEntry(string name, Type type)
            {
                Name = name;
                Type = type;
            }
        }
    }
}