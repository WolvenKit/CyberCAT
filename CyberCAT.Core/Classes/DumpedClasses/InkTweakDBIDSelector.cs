using CyberCAT.Core.Classes.Mapping;

namespace CyberCAT.Core.Classes.DumpedClasses
{
    [RealName("inkTweakDBIDSelector")]
    public class InkTweakDBIDSelector : IScriptable
    {
        [RealName("baseTweakID")]
        [RealType("TweakDBID")]
        public TweakDbId BaseTweakID { get; set; }
    }
}
