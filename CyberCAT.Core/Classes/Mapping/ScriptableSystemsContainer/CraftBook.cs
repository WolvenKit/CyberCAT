
namespace CyberCAT.Core.Classes.Mapping.ScriptableSystemsContainer
{
    [RealName("CraftBook")]
    public class CraftBook : IScriptable
    {
        [RealName("knownRecipes")]
        public ItemRecipe[] KnownRecipes { get; set; }
    }
}
