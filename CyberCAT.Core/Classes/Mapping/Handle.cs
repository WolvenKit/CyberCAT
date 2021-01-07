using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping
{
    public class Handle<T> : IHandle where T : GenericUnknownStruct.BaseClassEntry
    {
        public uint Id { get; private set; }

        public T Value { get; private set; }

        public Handle()
        {
            Id = 0;
        }

        public Handle(uint handleId)
        {
            Id = handleId;
        }

        public Handle(T value)
        {
            Value = value;
        }

        public uint GetId()
        {
            return Id;
        }

        public void SetId(uint handleId)
        {
            Id = handleId;
        }

        public GenericUnknownStruct.BaseClassEntry GetValue()
        {
            return Value;
        }

        public void SetValue(object value)
        {
            Value = (T) value;
        }
        public override string ToString()
        {
            return $"({Id}) {Value}";
        }
    }
}