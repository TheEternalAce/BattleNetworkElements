using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MMZeroElements.SetWeapons
{
    public class IceWeapons : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            int type = item.type;
            switch (type)
            {
                // Melee
                case ItemID.Amarok:
                case ItemID.BorealWoodSword:
                case ItemID.CandyCaneSword:
                case ItemID.EbonwoodSword:
                case ItemID.Flairon:
                case ItemID.Frostbrand:
                case ItemID.FruitcakeChakram:
                case ItemID.IceBlade:
                case ItemID.IceBoomerang:
                case ItemID.NorthPole:
                case ItemID.ShadewoodSword:
                case ItemID.Shroomerang:
                case ItemID.Swordfish:
                case ItemID.ZombieArm:

                // Ranged/Throwing
                case ItemID.AleThrowingGlove:
                case ItemID.BloodRainBow:
                case ItemID.IceBow:
                case ItemID.PainterPaintballGun:
                case ItemID.Snowball:
                case ItemID.SnowballCannon:
                case ItemID.StarAnise:
                case ItemID.Toxikarp:
                case ItemID.Tsunami:

                // Magic
                case ItemID.AquaScepter:
                case ItemID.BlizzardStaff:
                case ItemID.SharpTears:
                case ItemID.BubbleGun:
                case ItemID.CrimsonRod:
                case ItemID.FlowerofFrost:
                case ItemID.FrostStaff:
                case ItemID.GoldenShower:
                case ItemID.IceRod:
                case ItemID.SoulDrain:
                case ItemID.NebulaArcanum:
                case ItemID.NimbusRod:
                case ItemID.PoisonStaff:
                case ItemID.RazorbladeTyphoon:
                case ItemID.SpectreStaff:
                case ItemID.ToxicFlask:
                case ItemID.VenomStaff:
                //case ItemID.WandofFrosting:
                case ItemID.WaterBolt:

                // Summon
                case ItemID.AbigailsFlower:
                case ItemID.CoolWhip:
                case ItemID.FlinxStaff:
                case ItemID.SanguineStaff:
                case ItemID.SlimeStaff:
                case ItemID.StaffoftheFrostHydra:
                case ItemID.StardustCellStaff:
                case ItemID.StardustDragonStaff:
                case ItemID.TempestStaff:
                case ItemID.ThornWhip:

                // Ammo
                case ItemID.IchorBullet:
                case ItemID.FrostburnArrow:
                case ItemID.UnholyArrow:
                case ItemID.HolyArrow:
                case ItemID.IchorArrow:
                //case ItemID.ShimmerArrow:
                case ItemID.WetRocket:
                case ItemID.HoneyRocket:
                case ItemID.PoisonDart:
                case ItemID.IchorDart:
                case ItemID.Seed:
                case ItemID.Gel:
                case ItemID.Ale:
                case ItemID.CandyCorn:

                // Tool
                case ItemID.ReaverShark:
                case ItemID.SawtoothShark:
                case ItemID.NebulaPickaxe:
                case ItemID.LunarHamaxeNebula:
                case ItemID.NebulaAxe:
                case ItemID.NebulaHammer:
                case ItemID.StardustPickaxe:
                case ItemID.LunarHamaxeStardust:
                case ItemID.StardustAxe:
                case ItemID.StardustHammer:
                case ItemID.Hammush:
                    WeaponElements.Ice.Add(type);
                    break;
            }
        }
    }
}
