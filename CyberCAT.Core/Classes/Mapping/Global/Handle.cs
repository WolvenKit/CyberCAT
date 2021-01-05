using CyberCAT.Core.Classes.Interfaces;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.Global
{
    public class Handle<T> : IHandle where T : GenericUnknownStruct.BaseClassEntry
    {
        public uint Id { get; set; }

        public T Value { get; set; }

        public Handle()
        {

        }

        public Handle(uint handleId)
        {
            Id = handleId;
        }

        public uint GetId()
        {
            return Id;
        }

        public void SetId(uint id)
        {
            Id = id;
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