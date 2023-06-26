using BattleNetworkElements.Elements;
using Terraria.ID;
using Terraria.ModLoader;

namespace BattleNetworkElements.SetElements.Weapons
{
    internal class FireWeapons : GlobalItem
    {
        internal static int[] items =
        {
            // Accessory/Armor
            ItemID.StarCloak,

            // Melee
            ItemID.Cascade,
            ItemID.DayBreak,
            ItemID.EnchantedBoomerang,
            ItemID.EnchantedSword,
            ItemID.Flamarang,
            ItemID.FlamingMace,
            ItemID.FieryGreatsword,
            ItemID.DD2SquireBetsySword,
            ItemID.MonkStaffT2,
            ItemID.HelFire,
            ItemID.BluePhaseblade,
            ItemID.GreenPhaseblade,
            ItemID.OrangePhaseblade,
            ItemID.PurplePhaseblade,
            ItemID.RedPhaseblade,
            ItemID.WhitePhaseblade,
            ItemID.YellowPhaseblade,
            ItemID.BluePhasesaber,
            ItemID.GreenPhasesaber,
            ItemID.OrangePhasesaber,
            ItemID.PurplePhasesaber,
            ItemID.RedPhasesaber,
            ItemID.WhitePhasesaber,
            ItemID.YellowPhasesaber,
            ItemID.ShadowFlameKnife,
            ItemID.MonkStaffT3,
            ItemID.SolarEruption,
            ItemID.Sunfury,
            ItemID.Starfury,
            ItemID.StarWrath,

            // Ranged/throwing
            ItemID.DD2BetsyBow,
            ItemID.BoneGlove,
            ItemID.ElfMelter,
            ItemID.Flamethrower,
            ItemID.HellwingBow,
            ItemID.JackOLanternLauncher,
            ItemID.MolotovCocktail,
            ItemID.MoltenFury,
            ItemID.DD2PhoenixBow,
            ItemID.PhoenixBlaster,
            ItemID.ShadowFlameBow,

            // Magic
            ItemID.ApprenticeStaffT3,
            ItemID.BookofSkulls,
            ItemID.ClingerStaff,
            ItemID.CursedFlame,
            ItemID.DemonScythe,
            ItemID.Flamelash,
            ItemID.FlowerofFire,
            ItemID.HeatRay,
            ItemID.InfernoFork,
            ItemID.LastPrism,
            ItemID.LunarFlareBook,
            ItemID.MagicMissile,
            ItemID.MeteorStaff,
            ItemID.NebulaBlaze,
            ItemID.FairyQueenMagicItem,
            ItemID.ShadowbeamStaff,
            ItemID.ShadowFlameHexDoll,
            ItemID.SpiritFlame,
            ItemID.UnholyTrident,
            ItemID.WandofSparking,

            // Summon
            ItemID.ScytheWhip,
            ItemID.DD2ExplosiveTrapT1Popper,
            ItemID.DD2ExplosiveTrapT2Popper,
            ItemID.DD2ExplosiveTrapT3Popper,
            ItemID.FireWhip,
            ItemID.DD2FlameburstTowerT1Popper,
            ItemID.DD2FlameburstTowerT2Popper,
            ItemID.DD2FlameburstTowerT3Popper,
            ItemID.HoundiusShootius,
            ItemID.ImpStaff,
            ItemID.OpticStaff,

            // Ammo
            ItemID.Flare,
            ItemID.BlueFlare,
            ItemID.SpelunkerFlare,
            ItemID.CursedFlare,
            ItemID.RainbowFlare,
            ItemID.ShimmerFlare,
            ItemID.MeteorShot,
            ItemID.CursedBullet,
            ItemID.ExplodingBullet,
            ItemID.FlamingArrow,
            ItemID.JestersArrow,
            ItemID.HellfireArrow,
            ItemID.CursedArrow,
            ItemID.RocketI,
            ItemID.RocketII,
            ItemID.RocketIII,
            ItemID.RocketIV,
            ItemID.ClusterRocketI,
            ItemID.ClusterRocketII,
            ItemID.DryRocket,
            ItemID.LavaRocket,
            ItemID.MiniNukeI,
            ItemID.MiniNukeII,
            ItemID.CursedDart,
            ItemID.ExplosiveJackOLantern,
            ItemID.FallenStar,

            // Tool
            ItemID.MoltenPickaxe,
            ItemID.SolarFlarePickaxe,
            ItemID.MeteorHamaxe,
            ItemID.MoltenHamaxe,
            ItemID.LunarHamaxeSolar,
            ItemID.SolarFlareAxe,
            ItemID.SolarFlareHammer,

            // Summons
            ItemID.WormFood,
            ItemID.GuideVoodooDoll,
            ItemID.MechanicalSkull,
            ItemID.MechanicalEye,
            ItemID.LihzahrdPowerCell,
            ItemID.CelestialSigil,
        };

        public override void Load()
        {
            BNGlobalItem.Fire.AddRange(items);
        }

        public override void Unload()
        {
            BNGlobalItem.Fire.Clear();
        }
    }
}
