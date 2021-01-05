using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Interfaces
{
    public interface IHandle
    {
        uint GetId();
        GenericUnknownStruct.BaseClassEntry GetValue();
        void SetValue(object value);
    }
}