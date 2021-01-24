using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping
{
    public interface IHandle
    {
        uint Id { get; set; }
        uint GetId();
        void SetId(uint handleId);
        GenericUnknownStruct.BaseClassEntry GetValue();
        void SetValue(object value);
    }
}