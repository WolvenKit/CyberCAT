using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Interfaces
{
    public interface IHandle
    {
        uint GetId();
        void SetId(uint id);
        GenericUnknownStruct.BaseClassEntry GetValue();
        void SetValue(object value);
    }
}