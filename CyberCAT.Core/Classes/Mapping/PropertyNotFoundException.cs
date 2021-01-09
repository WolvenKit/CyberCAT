using System;

namespace CyberCAT.Core.Classes.Mapping
{
    public class PropertyNotFoundException : Exception
    {
        public string ClassName { get; set; }
        public string PropertyName { get; set; }

        public PropertyNotFoundException(string className, string propertyName)
        {
            ClassName = className;
            PropertyName = propertyName;
        }
    }
}