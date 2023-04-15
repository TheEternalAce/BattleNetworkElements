using MMZeroElements.Elements;
using Terraria.ID;
using Terraria.ModLoader;

namespace MMZeroElements.SetElements.Weapons
{
    internal class WoodWeapons : GlobalItem
    {
        internal static int[] poison =
        {
            // Accessory/Armor
            ItemID.BeeCloak,
            ItemID.HiveBackpack,
            ItemID.ChlorophyteHelmet,
            ItemID.ChlorophyteHeadgear,
            ItemID.ChlorophyteMask,
            ItemID.ChlorophytePlateMail,
            ItemID.ChlorophyteGreaves,

            // Melee
            ItemID.BladeofGrass,
            ItemID.MushroomSpear,
            ItemID.ThornChakram,

            // Ranged/throwing
            ItemID.Beenade,
            ItemID.PoisonedKnife,

            // Magic
            ItemID.BeeGun,
            ItemID.PoisonStaff,
            ItemID.VenomStaff,
            ItemID.WaspGun,

            // Summon
            ItemID.HornetStaff,
            ItemID.QueenSpiderStaff,
            ItemID.SpiderStaff,
            ItemID.VampireFrogStaff,

            // Ammo
            ItemID.VenomBullet,
            ItemID.VenomArrow,
            ItemID.StyngerBolt,

            // Summons
            ItemID.Abeemination,
        };

        public override void Load()
        {
            WeaponElements.Wood.AddRange(poison);
        }

        public override void Unload()
        {
            WeaponElements.Wood.Clear();
        }
    }
}
