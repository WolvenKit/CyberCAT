namespace CyberCAT.Core.Classes.Interfaces
{
    public interface ITweakDbResolver
    {
        string GetName(TweakDbId tdbid);
        string GetGameName(TweakDbId tdbid);
        string GetGameDescription(TweakDbId tdbid);
        ulong GetHash(string itemName);
    }
}
