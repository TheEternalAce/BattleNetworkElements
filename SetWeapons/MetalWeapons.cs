using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MMZeroElements.SetWeapons
{
    public class MetalWeapons : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            int type = item.type;
            switch (type)
            {
                // Pre-boss
                case ItemID.WoodenSword:
                case ItemID.WoodYoyo:
                case ItemID.WoodenBoomerang:
                case ItemID.PearlwoodSword:
                case ItemID.RichMahoganySword:

                case ItemID.CopperBroadsword:
                case ItemID.CopperShortsword:
                case ItemID.AmethystStaff:
                case ItemID.CopperPickaxe:
                case ItemID.CopperAxe:
                case ItemID.CopperHammer:

                case ItemID.TinBroadsword:
                case ItemID.TinShortsword:
                case ItemID.TopazStaff:
                case ItemID.TinPickaxe:
                case ItemID.TinAxe:
                case ItemID.TinHammer:

                case ItemID.Umbrella:
                case ItemID.Spear:
                case ItemID.Mace:
                case ItemID.Shuriken:
                case ItemID.ThrowingKnife:
                case ItemID.Grenade:
                case ItemID.StickyGrenade:
                case ItemID.BouncyGrenade:

                case ItemID.IronBroadsword:
                case ItemID.IronShortsword:
                case ItemID.IronPickaxe:
                case ItemID.IronAxe:
                case ItemID.IronHammer:

                case ItemID.LeadBroadsword:
                case ItemID.LeadShortsword:
                case ItemID.LeadPickaxe:
                case ItemID.LeadAxe:
                case ItemID.LeadHammer:

                case ItemID.BladedGlove:
                case ItemID.BloodyMachete:
                case ItemID.ChainKnife:
                case ItemID.Javelin:

                case ItemID.SilverBroadsword:
                case ItemID.SilverShortsword:
                case ItemID.SapphireStaff:
                case ItemID.SilverPickaxe:
                case ItemID.SilverAxe:
                case ItemID.SilverHammer:

                case ItemID.TungstenBroadsword:
                case ItemID.TungstenShortsword:
                case ItemID.EmeraldStaff:
                case ItemID.TungstenPickaxe:
                case ItemID.TungstenAxe:
                case ItemID.TungstenHammer:

                case ItemID.GoldBroadsword:
                case ItemID.GoldShortsword:
                case ItemID.RubyStaff:
                case ItemID.GoldPickaxe:
                case ItemID.GoldAxe:
                case ItemID.GoldHammer:

                case ItemID.Sickle:
                case ItemID.StylistKilLaKillScissorsIWish:
                case ItemID.PartyGirlGrenade:
                case ItemID.BlandWhip:

                case ItemID.PlatinumBroadsword:
                case ItemID.PlatinumShortsword:
                case ItemID.DiamondStaff:
                case ItemID.PlatinumPickaxe:
                case ItemID.PlatinumAxe:
                case ItemID.PlatinumHammer:

                // Post BoC/EoW
                case ItemID.Gladius:
                case ItemID.BoneSword:
                case ItemID.Katana:
                case ItemID.DyeTradersScimitar:
                case ItemID.Starfury:
                case ItemID.Terragrim:
                case ItemID.FalconBlade:
                case ItemID.Rally:
                case ItemID.SpikyBall:
                case ItemID.Harpoon:
                case ItemID.DD2BallistraTowerT1Popper:

                case ItemID.BloodButcherer:
                case ItemID.TheMeatball:
                case ItemID.CrimsonYoyo:
                case ItemID.TheRottedFork:
                case ItemID.DeathbringerPickaxe:
                case ItemID.BloodLustCluster:
                case ItemID.FleshGrinder:

                case ItemID.LightsBane:
                case ItemID.BallOHurt:
                case ItemID.CorruptYoyo:
                case ItemID.NightmarePickaxe:
                case ItemID.WarAxeoftheNight:
                case ItemID.TheBreaker:

                // Post Skeletron
                case ItemID.TragicUmbrella:
                case ItemID.DarkLance:
                case ItemID.Code1:
                case ItemID.Valor:
                case ItemID.CombatWrench:
                case ItemID.BlueMoon:
                case ItemID.Muramasa:
                case ItemID.NightsEdge:
                case ItemID.BoneWhip:

                // Hardmode
                case ItemID.BreakerBlade:
                case ItemID.TaxCollectorsStickOfDoom:
                case ItemID.FormatC:
                case ItemID.Gradient:
                case ItemID.Chik:
                case ItemID.JoustingLance:
                case ItemID.FlyingKnife:
                case ItemID.ChainGuillotines:
                case ItemID.BouncingShield:
                case ItemID.DaoofPow:
                case ItemID.Anchor:
                case ItemID.CrystalSerpent:
                case ItemID.CrystalVileShard:
                case ItemID.CrystalStorm:

                case ItemID.CobaltSword:
                case ItemID.CobaltNaginata:
                case ItemID.CobaltPickaxe:
                case ItemID.CobaltWaraxe:

                case ItemID.PalladiumSword:
                case ItemID.PalladiumPike:
                case ItemID.PalladiumPickaxe:
                case ItemID.PalladiumWaraxe:

                case ItemID.Code2:
                case ItemID.Cutlass:
                case ItemID.BeamSword:
                case ItemID.Smolstar:
                case ItemID.PirateStaff:
                case ItemID.PygmyStaff:

                case ItemID.MythrilSword:
                case ItemID.MythrilHalberd:
                case ItemID.MythrilPickaxe:
                case ItemID.MythrilWaraxe:

                case ItemID.OrichalcumSword:
                case ItemID.OrichalcumHalberd:
                case ItemID.OrichalcumPickaxe:
                case ItemID.OrichalcumWaraxe:

                case ItemID.Arkhalis:
                case ItemID.FetidBaghnakhs:
                case ItemID.Yelets:
                case ItemID.RedsYoyo:

                case ItemID.AdamantiteSword:
                case ItemID.AdamantiteGlaive:
                case ItemID.AdamantitePickaxe:
                case ItemID.AdamantiteWaraxe:

                case ItemID.TitaniumSword:
                case ItemID.TitaniumTrident:
                case ItemID.TitaniumPickaxe:
                case ItemID.TitaniumWaraxe:

                // Post Mechs
                case ItemID.ObsidianSwordfish:
                case ItemID.Excalibur:
                case ItemID.Gungnir:
                case ItemID.LightDisc:
                case ItemID.HallowJoustingLance:
                case ItemID.DD2SquireDemonSword:
                case ItemID.MonkStaffT1:
                case ItemID.RainbowRod:
                case ItemID.DD2BallistraTowerT2Popper:
                case ItemID.SwordWhip:

                case ItemID.PickaxeAxe:
                case ItemID.Drax:

                // Post Plantera
                case ItemID.SpectrePickaxe:
                case ItemID.SpectreHamaxe:

                case ItemID.ChlorophyteSaber:
                case ItemID.ChlorophyteClaymore:
                case ItemID.ChlorophytePartisan:
                case ItemID.ChlorophytePickaxe:
                case ItemID.ChlorophyteGreataxe:
                case ItemID.ChlorophyteWarhammer:
                case ItemID.ChlorophyteJackhammer:

                case ItemID.TrueExcalibur:
                case ItemID.TrueNightsEdge:
                case ItemID.Seedler:
                case ItemID.DeathSickle:
                case ItemID.Keybrand:
                case ItemID.Kraken:
                case ItemID.ShadowJoustingLance:
                case ItemID.PaladinsHammer:
                case ItemID.PsychoKnife:
                case ItemID.TheEyeOfCthulhu:
                case ItemID.TerraBlade:
                case ItemID.PiranhaGun:
                case ItemID.MaceWhip:
                case ItemID.RainbowWhip:

                // Post Golem
                case ItemID.PossessedHatchet:
                case ItemID.GolemFist:
                case ItemID.PiercingStarlight:
                case ItemID.Terrarian:
                case ItemID.StarWrath:
                case ItemID.Meowmere:
                case ItemID.Zenith:
                case ItemID.RainbowCrystalStaff:
                case ItemID.DD2BallistraTowerT3Popper:

                // Ammo
                case ItemID.WoodenArrow:
                case ItemID.ChlorophyteArrow:
                case ItemID.BoneArrow:
                case ItemID.MusketBall:
                case ItemID.SilverBullet:
                case ItemID.CrystalBullet:
                case ItemID.ChlorophyteBullet:
                case ItemID.HighVelocityBullet:
                case ItemID.GoldenBullet:
                case ItemID.PartyBullet:
                case ItemID.EndlessMusketPouch:
                case ItemID.EndlessQuiver:
                case ItemID.Stake:
                case ItemID.CrystalDart:
                case ItemID.Nail:
                case ItemID.SandBlock:
                case ItemID.EbonsandBlock:
                case ItemID.CrimsandBlock:
                case ItemID.PearlsandBlock:
                case ItemID.CopperCoin:
                case ItemID.SilverCoin:
                case ItemID.GoldCoin:
                case ItemID.PlatinumCoin:

                // Tool
                case ItemID.ShroomiteDiggingClaw:
                case ItemID.Picksaw:
                case ItemID.CnadyCanePickaxe:
                case ItemID.FossilPickaxe:
                case ItemID.BonePickaxe:
                case ItemID.LucyTheAxe:
                case ItemID.TheAxe:
                case ItemID.Rockfish:
                case ItemID.Pwnhammer:
                //case 4317: // Haemorrhaxe
                case ItemID.GravediggerShovel:
                    WeaponElements.Metal.Add(type);
                    break;
            }
        }
    }
}
