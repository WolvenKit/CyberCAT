using CyberCAT.Core.Classes.Mapping.Global;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("SHitNPC")]
    public class SHitNPC : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("entityID")]
        public EntEntityID EntityID { get; set; }
        
        [RealName("calls")]
        [RealType("Int32")]
        public int Calls { get; set; }
    }
}
