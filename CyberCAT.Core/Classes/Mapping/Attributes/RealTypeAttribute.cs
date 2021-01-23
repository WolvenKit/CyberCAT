using System;

namespace CyberCAT.Core.Classes.Mapping
{
    [System.AttributeUsage(AttributeTargets.Property)]
    public class RealTypeAttribute : System.Attribute
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