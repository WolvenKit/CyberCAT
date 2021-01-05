using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.Global
{
    public class Handle<T> : IHandle where T : GenericUnknownStruct.BaseClassEntry
    {
        public uint Id { get; }

        public T Value { get; set; }

        public Handle()
        {
            Id = 0;
        }

        public Handle(uint handleId)
        {
            Id = handleId;
        }

        public uint GetId()
        {
            return Id;
        }

        public GenericUnknownStruct.BaseClassEntry GetValue()
        {
            return Value;
        }

        public void SetValue(object value)
        {
            Value = (T) value;
        }
    }
}