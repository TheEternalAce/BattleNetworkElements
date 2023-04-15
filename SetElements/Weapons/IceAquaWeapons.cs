using MMZeroElements.Elements;
using Terraria.ID;
using Terraria.ModLoader;

namespace MMZeroElements.SetElements.Weapons
{
    internal class IceAquaWeapons : GlobalItem
    {
        internal static int[] items =
        {
            // Accessory/Armor
            ItemID.StardustHelmet,
            ItemID.StardustBreastplate,
            ItemID.StardustLeggings,
            ItemID.BoneHelm,

            // Melee
            ItemID.Amarok,
            ItemID.BloodButcherer,
            ItemID.BorealWoodSword,
            ItemID.CandyCaneSword,
            ItemID.EbonwoodSword,
            ItemID.Flairon,
            ItemID.Frostbrand,
            ItemID.FruitcakeChakram,
            ItemID.IceBlade,
            ItemID.IceBoomerang,
            ItemID.Muramasa,
            ItemID.NorthPole,
            ItemID.ShadewoodSword,
            ItemID.Shroomerang,
            ItemID.Swordfish,
            ItemID.ZombieArm,

            // Ranged/Throwing
            ItemID.AleThrowingGlove,
            ItemID.BloodRainBow,
            ItemID.IceBow,
            ItemID.PainterPaintballGun,
            ItemID.Snowball,
            ItemID.SnowballCannon,
            ItemID.StarAnise,
            ItemID.Toxikarp,
            ItemID.Tsunami,

            // Magic
            ItemID.AquaScepter,
            ItemID.BlizzardStaff,
            ItemID.SharpTears,
            ItemID.BubbleGun,
            ItemID.CrimsonRod,
            ItemID.FlowerofFrost,
            ItemID.FrostStaff,
            ItemID.GoldenShower,
            ItemID.IceRod,
            ItemID.SoulDrain,
            ItemID.NebulaArcanum,
            ItemID.NimbusRod,
            ItemID.RazorbladeTyphoon,
            ItemID.SpectreStaff,
            ItemID.ToxicFlask,
            ItemID.WandofFrosting,
            ItemID.WaterBolt,

            // Summon
            ItemID.AbigailsFlower,
            ItemID.CoolWhip,
            ItemID.FlinxStaff,
            ItemID.SanguineStaff,
            ItemID.SlimeStaff,
            ItemID.StaffoftheFrostHydra,
            ItemID.StardustCellStaff,
            ItemID.StardustDragonStaff,
            ItemID.TempestStaff,
            ItemID.ThornWhip,

            // Ammo
            ItemID.IchorBullet,
            ItemID.FrostburnArrow,
            ItemID.UnholyArrow,
            ItemID.HolyArrow,
            ItemID.IchorArrow,
            ItemID.ShimmerArrow,
            ItemID.WetRocket,
            ItemID.HoneyRocket,
            ItemID.PoisonDart,
            ItemID.IchorDart,
            ItemID.Seed,
            ItemID.Gel,
            ItemID.Ale,
            ItemID.CandyCorn,

            // Tool
            ItemID.ReaverShark,
            ItemID.SawtoothShark,
            ItemID.NebulaPickaxe,
            ItemID.LunarHamaxeNebula,
            ItemID.NebulaAxe,
            ItemID.NebulaHammer,
            ItemID.StardustPickaxe,
            ItemID.LunarHamaxeStardust,
            ItemID.StardustAxe,
            ItemID.StardustHammer,
            ItemID.Hammush,

            // Summons
            ItemID.SlimeCrown,
            ItemID.WormFood,
            ItemID.BloodySpine,
            ItemID.DeerThing,
            ItemID.QueenSlimeCrystal,
            ItemID.MechanicalSkull,
            ItemID.TruffleWorm,
            ItemID.CelestialSigil,
        };

        public override void Load()
        {
            WeaponElements.Ice.AddRange(items);
        }

        public override void Unload()
        {
            WeaponElements.Ice.Clear();
        }
    }
}
