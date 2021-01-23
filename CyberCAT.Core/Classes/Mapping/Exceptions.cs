using System;

namespace CyberCAT.Core.Classes.Mapping
{
    public class ClassNotFoundException : Exception
    {
        public string ClassName { get; set; }

        public ClassNotFoundException(string className) : base($"Unknown class: \"{className}\"")
        {
            ClassName = className;
        }
    }

    public class PropertyNotFoundException : Exception
    {
        public string ClassName { get; set; }
        public string PropertyName { get; set; }

        public PropertyNotFoundException(string className, string propertyName) : base($"Unknown property: \"{className}.{propertyName}\"")
        {
            ClassName = className;
            PropertyName = propertyName;
        }
    }

    public class UnknownTypeException : Exception
    {
        public string TypeStr { get; set; }

        public UnknownTypeException(string typeStr) : base($"Unknown type: \"{typeStr}\"")
        {
            TypeStr = typeStr;
        }
    }
}