using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MMZeroElements.SetWeapons
{
    public class ElectricWeapons : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            int type = item.type;
            switch (type)
            {
                // Pre-boss
                case ItemID.PalmWoodSword:
                case ItemID.ThunderSpear:
                case ItemID.ThunderStaff:
                case ItemID.BabyBirdStaff:
                case ItemID.PaperAirplaneA:
                case ItemID.PaperAirplaneB:

                case ItemID.BoneDagger:
                case ItemID.BoneJavelin:

                // Post Skeletron
                case ItemID.WeatherPain:
                case ItemID.ZapinatorGray:
                case ItemID.SpaceGun:
                case ItemID.DD2LightningAuraT1Popper:

                // Hardmode
                case ItemID.LaserRifle:
                case ItemID.SkyFracture:
                case ItemID.MagicalHarp:
                case ItemID.DaedalusStormbow:
                case ItemID.ZapinatorOrange:

                case ItemID.ValkyrieYoyo:
                case ItemID.BookStaff:
                case ItemID.MagnetSphere:
                case ItemID.DD2LightningAuraT2Popper:

                // Post Plantera
                case ItemID.PulseBow:
                case ItemID.RavenStaff:
                case ItemID.StormTigerStaff:
                case ItemID.DeadlySphereStaff:

                // Post Golem
                case ItemID.InfluxWaver:
                case ItemID.LaserMachinegun:
                case ItemID.ChargedBlasterCannon:
                case ItemID.SparkleGuitar:
                case ItemID.Phantasm:
                case ItemID.VortexBeater:
                case ItemID.ElectrosphereLauncher:
                case ItemID.DD2LightningAuraT3Popper:
                case ItemID.EmpressBlade:
                case ItemID.XenoStaff:
                case ItemID.MoonlordTurretStaff:

                // Ammo
                case ItemID.NanoBullet:
                case ItemID.MoonlordBullet:
                case ItemID.MoonlordArrow:

                // Tool
                case ItemID.VortexPickaxe:
                case ItemID.LunarHamaxeVortex:
                case ItemID.VortexAxe:
                case ItemID.VortexHammer:
                    WeaponElements.Electric.Add(type);
                    break;
            }
        }
    }
}
