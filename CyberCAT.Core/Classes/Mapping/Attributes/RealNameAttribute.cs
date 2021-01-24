using System;

namespace CyberCAT.Core.Classes.Mapping
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Enum)]
    public class RealNameAttribute : Attribute
    {
        public string Name;

        public RealNameAttribute(string name)
        {
            Name = name;
        }
    }
}