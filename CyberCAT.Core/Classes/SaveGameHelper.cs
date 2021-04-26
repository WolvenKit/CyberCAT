namespace CyberCAT.Core.Classes
{
    public class SaveGameHelper
    {
        public static ulong GetItemIdHash(ulong tweakDbId, uint seed, ushort unk1 = 0)
        {
            ulong c = 0xC6A4A7935BD1E995;

            ulong tmp;

            if (unk1 == 0)
            {
                tmp = seed * c;
                tmp = tmp >> 0x2F ^ tmp;
            }
            else
            {
                tmp = unk1 * c;
                tmp = ((tmp >> 0x2f ^ tmp) * c ^ seed) * 0x35A98F4D286A90B9;
                tmp = tmp >> 0x2F ^ tmp;
            }

            return (tmp * c ^ tweakDbId) * c;
        }
    }
}