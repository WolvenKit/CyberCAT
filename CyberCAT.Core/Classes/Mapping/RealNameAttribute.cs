using System;

namespace CyberCAT.Core.Classes.Mapping
{
    [System.AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
    public class RealNameAttribute : System.Attribute
    {
        public string Name;

        public RealNameAttribute(string name)
        {
            Name = name;
        }
    }
}