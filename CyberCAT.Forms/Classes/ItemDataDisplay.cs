using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Forms.Classes
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class ItemDataDisplay : ItemData
    {
        // TODO: this should probably loaded from a file, just for testing now.
        private static Dictionary<Tuple<uint, byte>, string> CRC32bToName = new Dictionary<Tuple<uint, byte>, string>()
        {
            { new Tuple<uint, byte>(0xF5E188EC, 0x0B), "Items.money" },
            { new Tuple<uint, byte>(0x2B2D70CF, 0x1C), "Items.Preset_Yukimura_Skippy" },
            { new Tuple<uint, byte>(0xF2FCC058, 0x12), "Items.mq007_skippy" },
        };
        public string ItemName
        {
            get
            {
                if (CRC32bToName.TryGetValue(new Tuple<uint, byte>(ItemNameCRC32b, ItemNameLength), out var name))
                {
                    return name;
                }

                return "<Unknown>";
            }
        }
        public ItemDataDisplay(ItemData source)
        {
            ItemNameCRC32b = source.ItemNameCRC32b;
            ItemNameLength = source.ItemNameLength;
            TrailingBytes = source.TrailingBytes;
        }
    }
}
