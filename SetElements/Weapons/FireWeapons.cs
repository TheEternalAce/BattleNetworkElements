using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;

namespace MMZeroElements.SetElements.Weapons
{
    public class FireWeapons : GlobalItem
    {
        static List<int> items = new()
        {
            // Accessory/Armor
            ItemID.StarCloak,
            ItemID.BeeCloak,
            ItemID.HiveBackpack,
            ItemID.ChlorophyteHelmet,
            ItemID.ChlorophyteHeadgear,
            ItemID.ChlorophyteMask,
            ItemID.ChlorophytePlateMail,
            ItemID.ChlorophyteGreaves,

            // Melee
            ItemID.BladeofGrass,
            ItemID.Cascade,
            ItemID.DayBreak,
            ItemID.EnchantedBoomerang,
            ItemID.EnchantedSword,
            ItemID.Flamarang,
            ItemID.FlamingMace,
            ItemID.DD2SquireBetsySword,
            ItemID.MonkStaffT2,
            ItemID.HelFire,
            ItemID.MushroomSpear,
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
            ItemID.ThornChakram,

            // Ranged/throwing
            ItemID.DD2BetsyBow,
            ItemID.Beenade,
            ItemID.BoneGlove,
            ItemID.EldMelter,
            ItemID.Flamethrower,
            ItemID.HellwingBow,
            ItemID.JackOLanternLauncher,
            ItemID.MolotovCocktail,
            ItemID.MoltenFury,
            ItemID.DD2PhoenixBow,
            ItemID.PhoenixBlaster,
            ItemID.PoisonedKnife,
            ItemID.ShadowFlameBow,

            // Magic
            ItemID.BeeGun,
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
            ItemID.PoisonStaff,
            ItemID.ShadowbeamStaff,
            ItemID.ShadowFlameHexDoll,
            ItemID.SpiritFlame,
            ItemID.UnholyTrident,
            ItemID.VenomStaff,
            ItemID.WandofSparking,
            ItemID.WaspGun,

            // Summon
            ItemID.ScytheWhip,
            ItemID.DD2ExplosiveTrapT1Popper,
            ItemID.DD2ExplosiveTrapT2Popper,
            ItemID.DD2ExplosiveTrapT3Popper,
            ItemID.FireWhip,
            ItemID.DD2FlameburstTowerT1Popper,
            ItemID.DD2FlameburstTowerT2Popper,
            ItemID.DD2FlameburstTowerT3Popper,
            ItemID.HornetStaff,
            ItemID.HoundiusShootius,
            ItemID.ImpStaff,
            ItemID.OpticStaff,
            ItemID.QueenSpiderStaff,
            ItemID.SpiderStaff,
            ItemID.VampireFrogStaff,

            // Ammo
            ItemID.Flare,
            ItemID.BlueFlare,
            //case ItemID.SpelunkerFlare,
            //case ItemID.CursedFlare,
            //case ItemID.RainbowFlare,
            //case ItemID.ShimmerFlare,
            ItemID.MeteorShot,
            ItemID.CursedBullet,
            ItemID.VenomBullet,
            ItemID.ExplodingBullet,
            ItemID.FlamingArrow,
            ItemID.JestersArrow,
            ItemID.HellfireArrow,
            ItemID.CursedArrow,
            ItemID.VenomArrow,
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
            ItemID.StyngerBolt,
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
            ItemID.Abeemination,
            ItemID.GuideVoodooDoll,
            ItemID.MechanicalSkull,
            ItemID.MechanicalEye,
            ItemID.LihzahrdPowerCell,
            ItemID.CelestialSigil,
        };

        public override void Load()
        {
            WeaponElements.Fire.AddRange(items);
        }

        public override void Unload()
        {
            WeaponElements.Fire.Clear();
        }
    }
}
