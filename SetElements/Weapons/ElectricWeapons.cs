using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;

namespace MMZeroElements.SetElements.Weapons
{
    public class ElectricWeapons : GlobalItem
    {
        static List<int> items = new()
        {
            // Pre-boss
            ItemID.PalmWoodSword,
            ItemID.ThunderSpear,
            ItemID.ThunderStaff,
            ItemID.BabyBirdStaff,
            ItemID.PaperAirplaneA,
            ItemID.PaperAirplaneB,

            ItemID.BoneDagger,
            ItemID.BoneJavelin,

            // Post Skeletron
            ItemID.WeatherPain,
            ItemID.ZapinatorGray,
            ItemID.SpaceGun,
            ItemID.DD2LightningAuraT1Popper,

            // Hardmode
            ItemID.LaserRifle,
            ItemID.SkyFracture,
            ItemID.MagicalHarp,
            ItemID.DaedalusStormbow,
            ItemID.ZapinatorOrange,

            ItemID.ValkyrieYoyo,
            ItemID.BookStaff,
            ItemID.MagnetSphere,
            ItemID.DD2LightningAuraT2Popper,

            // Post Plantera
            ItemID.PulseBow,
            ItemID.RavenStaff,
            ItemID.StormTigerStaff,
            ItemID.DeadlySphereStaff,

            // Post Golem
            ItemID.InfluxWaver,
            ItemID.LaserMachinegun,
            ItemID.ChargedBlasterCannon,
            ItemID.SparkleGuitar,
            ItemID.Phantasm,
            ItemID.VortexBeater,
            ItemID.ElectrosphereLauncher,
            ItemID.DD2LightningAuraT3Popper,
            ItemID.EmpressBlade,
            ItemID.XenoStaff,
            ItemID.MoonlordTurretStaff,

            // Ammo
            ItemID.NanoBullet,
            ItemID.MoonlordBullet,
            ItemID.MoonlordArrow,

            // Tool
            ItemID.VortexPickaxe,
            ItemID.LunarHamaxeVortex,
            ItemID.VortexAxe,
            ItemID.VortexHammer,

            // Summons
            ItemID.SuspiciousLookingEye,
            ItemID.ClothierVoodooDoll,
            ItemID.MechanicalSkull,
            ItemID.EmpressButterfly,
            ItemID.CelestialSigil,
        };

        public override void Load()
        {
            WeaponElements.Electric.AddRange(items);
        }

        public override void Unload()
        {
            WeaponElements.Electric.Clear();
        }
    }
}
