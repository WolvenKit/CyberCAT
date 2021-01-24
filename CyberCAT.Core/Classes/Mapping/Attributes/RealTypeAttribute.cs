using System;

namespace CyberCAT.Core.Classes.Mapping
{
    [AttributeUsage(AttributeTargets.Property)]
    public class RealTypeAttribute : Attribute
    {
        public string Type;
        public bool IsStatic;
        public bool IsFixedArray;
        public bool IsHandle;

        public RealTypeAttribute(string type)
        {
            Type = type;
        }
    }
}