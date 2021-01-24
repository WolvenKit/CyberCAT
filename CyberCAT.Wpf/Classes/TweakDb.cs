using System;
using System.Collections.Generic;
using System.Text;
using CyberCAT.Core.Classes;
using CyberCAT.Core.Classes.NodeRepresentations;

namespace CyberCAT.Wpf.Classes
{
    class TweakDb
    {
        public static readonly List<TweakDbId> ClothingAttachmentSlots = new List<TweakDbId>
        {
            TweakDbId.FromName("AttachmentSlots.OuterChestFabricEnhancer1"),
            TweakDbId.FromName("AttachmentSlots.OuterChestFabricEnhancer2"),
            TweakDbId.FromName("AttachmentSlots.OuterChestFabricEnhancer3"),
            TweakDbId.FromName("AttachmentSlots.OuterChestFabricEnhancer4"),
            TweakDbId.FromName("AttachmentSlots.InnerChestFabricEnhancer1"),
            TweakDbId.FromName("AttachmentSlots.InnerChestFabricEnhancer2"),
            TweakDbId.FromName("AttachmentSlots.InnerChestFabricEnhancer3"),
            TweakDbId.FromName("AttachmentSlots.InnerChestFabricEnhancer4"),
            TweakDbId.FromName("AttachmentSlots.LegsFabricEnhancer1"),
            TweakDbId.FromName("AttachmentSlots.LegsFabricEnhancer2"),
            TweakDbId.FromName("AttachmentSlots.LegsFabricEnhancer3"),
            TweakDbId.FromName("AttachmentSlots.LegsFabricEnhancer4"),
            TweakDbId.FromName("AttachmentSlots.FaceFabricEnhancer1"),
            TweakDbId.FromName("AttachmentSlots.FaceFabricEnhancer2"),
            TweakDbId.FromName("AttachmentSlots.FaceFabricEnhancer3"),
            TweakDbId.FromName("AttachmentSlots.FaceFabricEnhancer4"),
            TweakDbId.FromName("AttachmentSlots.FootFabricEnhancer1"),
            TweakDbId.FromName("AttachmentSlots.FootFabricEnhancer2"),
            TweakDbId.FromName("AttachmentSlots.FootFabricEnhancer3"),
            TweakDbId.FromName("AttachmentSlots.FootFabricEnhancer4"),
            TweakDbId.FromName("AttachmentSlots.HeadFabricEnhancer1"),
            TweakDbId.FromName("AttachmentSlots.HeadFabricEnhancer2"),
            TweakDbId.FromName("AttachmentSlots.HeadFabricEnhancer3"),
            TweakDbId.FromName("AttachmentSlots.HeadFabricEnhancer4"),
        };

        public static readonly List<TweakDbId> WeaponAttachmentSlots = new List<TweakDbId>
        {
            TweakDbId.FromName("AttachmentSlots.Magazine"),
            TweakDbId.FromName("AttachmentSlots.MagazineEmpty"),
            TweakDbId.FromName("AttachmentSlots.Barrel"),
            TweakDbId.FromName("AttachmentSlots.Receiver"),
            TweakDbId.FromName("AttachmentSlots.IconicWeaponModLegendary"),
            TweakDbId.FromName("AttachmentSlots.GenericWeaponMod1"),
            TweakDbId.FromName("AttachmentSlots.GenericWeaponMod2"),
            TweakDbId.FromName("AttachmentSlots.GenericWeaponMod3"),
            TweakDbId.FromName("AttachmentSlots.GenericWeaponMod4"),

            TweakDbId.FromName("AttachmentSlots.MeleeWeaponMod1"),
            TweakDbId.FromName("AttachmentSlots.MeleeWeaponMod2"),
            TweakDbId.FromName("AttachmentSlots.MeleeWeaponMod3"),
            TweakDbId.FromName("AttachmentSlots.IconicMeleeWeaponMod1"),

            TweakDbId.FromName("AttachmentSlots.TechWeaponMod1"),
            TweakDbId.FromName("AttachmentSlots.TechWeaponMod2"),
            TweakDbId.FromName("AttachmentSlots.TechWeaponMod3"),
            TweakDbId.FromName("AttachmentSlots.TechWeaponModRare"),
            TweakDbId.FromName("AttachmentSlots.TechWeaponModEpic"),
            TweakDbId.FromName("AttachmentSlots.TechWeaponModLegendary"),

            TweakDbId.FromName("AttachmentSlots.PowerWeaponMod1"),
            TweakDbId.FromName("AttachmentSlots.PowerWeaponMod2"),
            TweakDbId.FromName("AttachmentSlots.PowerWeaponMod3"),
            TweakDbId.FromName("AttachmentSlots.PowerWeaponModRare"),
            TweakDbId.FromName("AttachmentSlots.PowerWeaponModEpic"),
            TweakDbId.FromName("AttachmentSlots.PowerWeaponModLegendary"),

            TweakDbId.FromName("AttachmentSlots.SmartWeaponMod1"),
            TweakDbId.FromName("AttachmentSlots.SmartWeaponMod2"),
            TweakDbId.FromName("AttachmentSlots.SmartWeaponMod3"),
            TweakDbId.FromName("AttachmentSlots.SmartWeaponModRare"),
            TweakDbId.FromName("AttachmentSlots.SmartWeaponModEpic"),
            TweakDbId.FromName("AttachmentSlots.SmartWeaponModLegendary"),

        };

        public static readonly List<ItemData.ItemModData> ClothingMods = new List<ItemData.ItemModData>
        {
            new ItemData.ItemModData // Armadilo
            {
                ItemTdbId = TweakDbId.FromName("Items.SimpleFabricEnhancer01"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // Resist!
            {
                ItemTdbId = TweakDbId.FromName("Items.SimpleFabricEnhancer02"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // Fortuna
            {
                ItemTdbId = TweakDbId.FromName("Items.SimpleFabricEnhancer03"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // Bully
            {
                ItemTdbId = TweakDbId.FromName("Items.SimpleFabricEnhancer04"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // Backpacker
            {
                ItemTdbId = TweakDbId.FromName("Items.SimpleFabricEnhancer05"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // Footloose
            {
                ItemTdbId = TweakDbId.FromName("Items.SimpleFabricEnhancer06"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // Showtime
            {
                ItemTdbId = TweakDbId.FromName("Items.SimpleFabricEnhancer07"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // Osmosis
            {
                ItemTdbId = TweakDbId.FromName("Items.SimpleFabricEnhancer09"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // Plume
            {
                ItemTdbId = TweakDbId.FromName("Items.SimpleFabricEnhancer10"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // Zero drag
            {
                ItemTdbId = TweakDbId.FromName("Items.SimpleFabricEnhancer11"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // Tenacity
            {
                ItemTdbId = TweakDbId.FromName("Items.SimpleFabricEnhancer12"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // Vanguard
            {
                ItemTdbId = TweakDbId.FromName("Items.SimpleFabricEnhancer13"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // Boom Breaker
            {
                ItemTdbId = TweakDbId.FromName("Items.SimpleFabricEnhancer14"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // Coolit
            {
                ItemTdbId = TweakDbId.FromName("Items.PowerfulFabricEnhancer01"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // Antivenom
            {
                ItemTdbId = TweakDbId.FromName("Items.PowerfulFabricEnhancer02"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // Panacea
            {
                ItemTdbId = TweakDbId.FromName("Items.PowerfulFabricEnhancer03"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // SuperInsulator
            {
                ItemTdbId = TweakDbId.FromName("Items.PowerfulFabricEnhancer04"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // Soft-Sole
            {
                ItemTdbId = TweakDbId.FromName("Items.PowerfulFabricEnhancer05"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // Cut-It-Out
            {
                ItemTdbId = TweakDbId.FromName("Items.PowerfulFabricEnhancer06"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // Predator
            {
                ItemTdbId = TweakDbId.FromName("Items.PowerfulFabricEnhancer07"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // Dead-Eye
            {
                ItemTdbId = TweakDbId.FromName("Items.PowerfulFabricEnhancer08"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
        };

        public static readonly List<ItemData.ItemModData> WeaponMods = new List<ItemData.ItemModData>
        {
            new ItemData.ItemModData // Crunch
            {
                ItemTdbId = TweakDbId.FromName("Items.SimpleWeaponMod01"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // Penetrator
            {
                ItemTdbId = TweakDbId.FromName("Items.SimpleWeaponMod02"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // Pacifier
            {
                ItemTdbId = TweakDbId.FromName("Items.SimpleWeaponMod03"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // Combat Amplifier
            {
                ItemTdbId = TweakDbId.FromName("Items.SimpleWeaponMod04"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // Countermass
            {
                ItemTdbId = TweakDbId.FromName("Items.SimpleWeaponMod11"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // Pulverize
            {
                ItemTdbId = TweakDbId.FromName("Items.SimpleWeaponMod12"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // Weaken
            {
                ItemTdbId = TweakDbId.FromName("Items.SimpleWeaponMod13"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // Autoloader
            {
                ItemTdbId = TweakDbId.FromName("Items.SimpleWeaponMod16"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // Pax
            {
                ItemTdbId = TweakDbId.FromName("Items.SimpleWeaponMod17"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            /*
            // These mods exist in the game, but apparently only as recipes.
            // They apparently do not work. (yet?)
            new ItemData.ItemModData // Knockdown
            {
                ItemTdbId = TweakDbId.FromName("Items.PowerWeaponMod01"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // Pulpify
            {
                ItemTdbId = TweakDbId.FromName("Items.PowerWeaponMod02"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // Focus
            {
                ItemTdbId = TweakDbId.FromName("Items.PowerWeaponMod03"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // Overpenetrate
            {
                ItemTdbId = TweakDbId.FromName("Items.PowerWeaponMod04"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // Stabilizer
            {
                ItemTdbId = TweakDbId.FromName("Items.PowerWeaponMod05"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            new ItemData.ItemModData // Subsonic
            {
                ItemTdbId = TweakDbId.FromName("Items.PowerWeaponMod06"),
                TdbId2 = TweakDbId.None,
                Unknown2 = 0,
                Unknown3 = 0,
                Unknown4 = 2139095039,
                UnknownString = "None",
            },
            */
        };
    }
}
