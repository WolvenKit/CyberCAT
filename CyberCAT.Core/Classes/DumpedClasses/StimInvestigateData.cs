using CyberCAT.Core.Classes.Mapping;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("stimInvestigateData")]
    public class StimInvestigateData : GenericUnknownStruct.BaseClassEntry
    {
        [RealName("investigationSpots")]
        public Vector4[] InvestigationSpots { get; set; }
        
        [RealName("investigateController")]
        public bool InvestigateController { get; set; }
        
        [RealName("controllerEntity")]
        public EntEntity ControllerEntity { get; set; }
        
        [RealName("mainDeviceEntity")]
        public EntEntity MainDeviceEntity { get; set; }
        
        [RealName("distrationPoint")]
        public Vector4 DistrationPoint { get; set; }
        
        [RealName("attackInstigator")]
        public EntEntity AttackInstigator { get; set; }
        
        [RealName("attackInstigatorPosition")]
        public Vector4 AttackInstigatorPosition { get; set; }
        
        [RealName("revealsInstigatorPosition")]
        public bool RevealsInstigatorPosition { get; set; }
        
        [RealName("illegalAction")]
        public bool IllegalAction { get; set; }
        
        [RealName("fearPhase")]
        public int FearPhase { get; set; }
        
        [RealName("skipReactionDelay")]
        public bool SkipReactionDelay { get; set; }
        
        [RealName("skipInitialAnimation")]
        public bool SkipInitialAnimation { get; set; }
    }
}
