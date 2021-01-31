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

    public class WrongDefaultValueException : Exception
    {
        public string ClassName { get; set; }
        public string PropertyName { get; set; }
        public object Value { get; set; }

        public WrongDefaultValueException(string className, string propertyName, object value) : base($"property: \"{className}.{propertyName}\" has a wrong default value ({value})!")
        {
            ClassName = className;
            PropertyName = propertyName;
            Value = value;
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