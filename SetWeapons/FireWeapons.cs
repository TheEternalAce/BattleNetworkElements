using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MMZeroElements.SetWeapons
{
    public class FireWeapons : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            int type = item.type;
            switch (type)
            {
                // Melee
                case ItemID.Cascade:
                case ItemID.DayBreak:
                case ItemID.EnchantedBoomerang:
                case ItemID.EnchantedSword:
                case ItemID.Flamarang:
                case ItemID.FlamingMace:
                case ItemID.DD2SquireBetsySword:
                case ItemID.MonkStaffT2:
                case ItemID.HelFire:
                case ItemID.MushroomSpear:
                case ItemID.BluePhaseblade:
                case ItemID.GreenPhaseblade:
                case ItemID.OrangePhaseblade:
                case ItemID.PurplePhaseblade:
                case ItemID.RedPhaseblade:
                case ItemID.WhitePhaseblade:
                case ItemID.YellowPhaseblade:
                case ItemID.BluePhasesaber:
                case ItemID.GreenPhasesaber:
                case ItemID.OrangePhasesaber:
                case ItemID.PurplePhasesaber:
                case ItemID.RedPhasesaber:
                case ItemID.WhitePhasesaber:
                case ItemID.YellowPhasesaber:
                case ItemID.ShadowFlameKnife:
                case ItemID.MonkStaffT3:
                case ItemID.SolarEruption:
                case ItemID.Sunfury:

                // Ranged/throwing
                case ItemID.DD2BetsyBow:
                case ItemID.Beenade:
                case ItemID.BoneGlove:
                case ItemID.EldMelter:
                case ItemID.Flamethrower:
                case ItemID.HellwingBow:
                case ItemID.JackOLanternLauncher:
                case ItemID.MolotovCocktail:
                case ItemID.MoltenFury:
                case ItemID.DD2PhoenixBow:
                case ItemID.PhoenixBlaster:
                case ItemID.PoisonedKnife:
                case ItemID.ShadowFlameBow:

                // Magic
                case ItemID.BeeGun:
                case ItemID.ApprenticeStaffT3:
                case ItemID.BookofSkulls:
                case ItemID.ClingerStaff:
                case ItemID.CursedFlame:
                case ItemID.DemonScythe:
                case ItemID.Flamelash:
                case ItemID.FlowerofFire:
                case ItemID.HeatRay:
                case ItemID.InfernoFork:
                case ItemID.LastPrism:
                case ItemID.LunarFlareBook:
                case ItemID.MagicMissile:
                case ItemID.MeteorStaff:
                case ItemID.NebulaBlaze:
                case ItemID.FairyQueenMagicItem:
                case ItemID.ShadowbeamStaff:
                case ItemID.ShadowFlameHexDoll:
                case ItemID.SpiritFlame:
                case ItemID.UnholyTrident:
                case ItemID.WandofSparking:

                // Summon
                case ItemID.ScytheWhip:
                case ItemID.DD2ExplosiveTrapT1Popper:
                case ItemID.DD2ExplosiveTrapT2Popper:
                case ItemID.DD2ExplosiveTrapT3Popper:
                case ItemID.FireWhip:
                case ItemID.DD2FlameburstTowerT1Popper:
                case ItemID.DD2FlameburstTowerT2Popper:
                case ItemID.DD2FlameburstTowerT3Popper:
                case ItemID.HornetStaff:
                case ItemID.HoundiusShootius:
                case ItemID.ImpStaff:
                case ItemID.OpticStaff:
                case ItemID.QueenSpiderStaff:
                case ItemID.SpiderStaff:
                case ItemID.VampireFrogStaff:

                // Ammo
                case ItemID.Flare:
                case ItemID.BlueFlare:
                //case ItemID.SpelunkerFlare:
                //case ItemID.CursedFlare:
                //case ItemID.RainbowFlare:
                //case ItemID.ShimmerFlare:
                case ItemID.MeteorShot:
                case ItemID.CursedBullet:
                case ItemID.VenomBullet:
                case ItemID.ExplodingBullet:
                case ItemID.FlamingArrow:
                case ItemID.JestersArrow:
                case ItemID.HellfireArrow:
                case ItemID.CursedArrow:
                case ItemID.VenomArrow:
                case ItemID.RocketI:
                case ItemID.RocketII:
                case ItemID.RocketIII:
                case ItemID.RocketIV:
                case ItemID.ClusterRocketI:
                case ItemID.ClusterRocketII:
                case ItemID.DryRocket:
                case ItemID.LavaRocket:
                case ItemID.MiniNukeI:
                case ItemID.MiniNukeII:
                case ItemID.CursedDart:
                case ItemID.ExplosiveJackOLantern:
                case ItemID.StyngerBolt:
                case ItemID.FallenStar:

                // Tool
                case ItemID.MoltenPickaxe:
                case ItemID.SolarFlarePickaxe:
                case ItemID.MeteorHamaxe:
                case ItemID.MoltenHamaxe:
                case ItemID.LunarHamaxeSolar:
                case ItemID.SolarFlareAxe:
                case ItemID.SolarFlareHammer:
                    WeaponElements.Fire.Add(type);
                    break;
            }
        }
    }
}
