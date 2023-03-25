﻿using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;

namespace MMZeroElements.SetElements.Projectiles
{
    public class FireProjectiles : GlobalProjectile
    {
        static List<int> projectiles = new()
        {
            // Arrow
            ProjectileID.FireArrow,
            ProjectileID.JestersArrow,
            ProjectileID.HellfireArrow,
            ProjectileID.CursedArrow,
            ProjectileID.VenomArrow,
            // Bullet
            ProjectileID.MeteorShot,
            ProjectileID.CursedBullet,
            ProjectileID.VenomBullet,
            ProjectileID.ExplosiveBullet,
            // Rocket
            ProjectileID.RocketI,
            ProjectileID.RocketII,
            ProjectileID.RocketIII,
            ProjectileID.RocketIV,
            ProjectileID.ClusterRocketI,
            ProjectileID.ClusterRocketII,
            ProjectileID.DryRocket,
            ProjectileID.LavaRocket,
            ProjectileID.MiniNukeRocketI,
            ProjectileID.MiniNukeRocketII,
            ProjectileID.RocketSnowmanI,
            ProjectileID.RocketSnowmanII,
            ProjectileID.RocketSnowmanIII,
            ProjectileID.RocketSnowmanIV,
            ProjectileID.ClusterSnowmanRocketI,
            ProjectileID.ClusterSnowmanRocketII,
            ProjectileID.DrySnowmanRocket,
            ProjectileID.LavaSnowmanRocket,
            ProjectileID.MiniNukeSnowmanRocketI,
            ProjectileID.MiniNukeSnowmanRocketII,
            ProjectileID.GrenadeI,
            ProjectileID.GrenadeII,
            ProjectileID.GrenadeIII,
            ProjectileID.GrenadeIV,
            ProjectileID.ClusterGrenadeI,
            ProjectileID.ClusterGrenadeII,
            ProjectileID.DryGrenade,
            ProjectileID.LavaGrenade,
            ProjectileID.MiniNukeGrenadeI,
            ProjectileID.MiniNukeGrenadeII,
            ProjectileID.ProximityMineI,
            ProjectileID.ProximityMineII,
            ProjectileID.ProximityMineIII,
            ProjectileID.ProximityMineIV,
            ProjectileID.ClusterMineI,
            ProjectileID.ClusterMineII,
            ProjectileID.DryMine,
            ProjectileID.LavaMine,
            ProjectileID.MiniNukeMineI,
            ProjectileID.MiniNukeMineII,
            ProjectileID.RocketFireworkRed,
            ProjectileID.RocketFireworkGreen,
            ProjectileID.RocketFireworkBlue,
            ProjectileID.RocketFireworkYellow,
            ProjectileID.Celeb2Rocket,
            ProjectileID.Celeb2RocketExplosive,
            ProjectileID.Celeb2RocketLarge,
            ProjectileID.Celeb2RocketExplosiveLarge,
            // Misc Ammo
            ProjectileID.Flare,
            ProjectileID.BlueFlare,
            ProjectileID.CursedDart,
            ProjectileID.JackOLantern,
            ProjectileID.Stynger,
            ProjectileID.StyngerShrapnel,
            ProjectileID.StarCannonStar,
            ProjectileID.EbonsandBallGun,

            // Accessory
            ProjectileID.StarCloakStar,
            ProjectileID.GiantBee,
            ProjectileID.CrystalLeaf,
            ProjectileID.CrystalLeafShot,

            // Melee
            //ProjectileID.BladeofGrass,
            ProjectileID.Cascade,
            ProjectileID.Daybreak,
            ProjectileID.DaybreakExplosion,
            ProjectileID.EnchantedBoomerang,
            ProjectileID.EnchantedBeam,
            ProjectileID.Flamarang,
            ProjectileID.FlamingMace,
            ProjectileID.MonkStaffT2,
            ProjectileID.MonkStaffT2Ghast,
            ProjectileID.HelFire,
            ProjectileID.MushroomSpear,
            ProjectileID.Mushroom,
            ProjectileID.ShadowFlameKnife,
            ProjectileID.MonkStaffT3,
            ProjectileID.MonkStaffT3_Alt,
            ProjectileID.MonkStaffT3_AltShot,
            ProjectileID.SolarWhipSword,
            ProjectileID.SolarWhipSwordExplosion,
            ProjectileID.SolarFlareChainsaw,
            ProjectileID.SolarFlareDrill,
            ProjectileID.Sunfury,
            ProjectileID.Starfury,
            ProjectileID.StarWrath,
            ProjectileID.ThornChakram,
            //ProjectileID.VolcanoExplosion,

            // Ranged
            ProjectileID.DD2BetsyArrow,
            ProjectileID.Beenade,
            ProjectileID.BoneGloveProj,
            ProjectileID.Flames,
            ProjectileID.Hellwing,
            ProjectileID.MolotovCocktail,
            ProjectileID.MolotovFire,
            ProjectileID.MolotovFire2,
            ProjectileID.MolotovFire3,
            ProjectileID.DD2PhoenixBow,
            ProjectileID.DD2PhoenixBowShot,
            ProjectileID.PoisonedKnife,
            ProjectileID.ShadowFlameArrow,
            ProjectileID.NailFriendly,

            // Magic
            ProjectileID.Bee,
            ProjectileID.DD2BetsyFireball,
            ProjectileID.BookOfSkullsSkull,
            ProjectileID.ClingerStaff,
            ProjectileID.CursedFlameFriendly,
            ProjectileID.DemonScythe,
            ProjectileID.Flamelash,
            ProjectileID.BallofFire,
            ProjectileID.HeatRay,
            ProjectileID.InfernoFriendlyBolt,
            ProjectileID.InfernoFriendlyBlast,
            ProjectileID.LastPrism,
            ProjectileID.LastPrismLaser,
            ProjectileID.LunarFlare,
            ProjectileID.MagicMissile,
            ProjectileID.Meteor1,
            ProjectileID.Meteor2,
            ProjectileID.Meteor3,
            ProjectileID.NebulaBlaze1,
            ProjectileID.NebulaBlaze2,
            ProjectileID.FairyQueenMagicItemShot,
            ProjectileID.PoisonFang,
            ProjectileID.ShadowBeamFriendly,
            ProjectileID.ShadowFlame,
            ProjectileID.SpiritFlame,
            ProjectileID.UnholyTridentFriendly,
            ProjectileID.VenomFang,
            ProjectileID.Spark,
            ProjectileID.Wasp,

            // Summon
            ProjectileID.ScytheWhip,
            ProjectileID.ScytheWhipProj,
            ProjectileID.DD2ExplosiveTrapT1,
            ProjectileID.DD2ExplosiveTrapT1Explosion,
            ProjectileID.DD2ExplosiveTrapT2,
            ProjectileID.DD2ExplosiveTrapT2Explosion,
            ProjectileID.DD2ExplosiveTrapT3,
            ProjectileID.DD2ExplosiveTrapT3Explosion,
            ProjectileID.FireWhip,
            ProjectileID.FireWhipProj,
            ProjectileID.DD2FlameBurstTowerT1,
            ProjectileID.DD2FlameBurstTowerT1Shot,
            ProjectileID.DD2FlameBurstTowerT2,
            ProjectileID.DD2FlameBurstTowerT2Shot,
            ProjectileID.DD2FlameBurstTowerT3,
            ProjectileID.DD2FlameBurstTowerT3Shot,
            ProjectileID.Hornet,
            ProjectileID.HornetStinger,
            ProjectileID.FlyingImp,
            ProjectileID.ImpFireball,
            ProjectileID.HoundiusShootius,
            ProjectileID.HoundiusShootiusFireball,
            ProjectileID.Spazmamini,
            ProjectileID.Retanimini,
            ProjectileID.MiniRetinaLaser,
            ProjectileID.SpiderHiver,
            ProjectileID.SpiderEgg,
            ProjectileID.VenomSpider,
            ProjectileID.JumperSpider,
            ProjectileID.DangerousSpider,
            ProjectileID.VampireFrog,

            // NPC proj
            ProjectileID.Explosives,
            ProjectileID.Stinger,
            ProjectileID.HornetStinger,
            ProjectileID.QueenBeeStinger,
            ProjectileID.CursedFlameHostile,
            ProjectileID.DemonSickle,
            ProjectileID.CursedFlameHostile,
            ProjectileID.ShadowBeamHostile,
            ProjectileID.UnholyTridentHostile,
            ProjectileID.RocketSkeleton,
            ProjectileID.HappyBomb,
            ProjectileID.EyeLaser,
            ProjectileID.EyeFire,
            ProjectileID.PinkLaser,
            ProjectileID.RuneBlast,
            ProjectileID.EbonsandBallFalling,
            ProjectileID.Fireball,
            ProjectileID.EyeBeam,
            ProjectileID.SeedPlantera,
            ProjectileID.PoisonSeedPlantera,
            ProjectileID.ThornBall,
            ProjectileID.InfernoHostileBlast,
            ProjectileID.InfernoHostileBolt,
            ProjectileID.Shadowflames,
            ProjectileID.GreekFire1,
            ProjectileID.GreekFire2,
            ProjectileID.GreekFire3,
            ProjectileID.FlamingScythe,
            ProjectileID.SaucerScrap,
            ProjectileID.CultistBossFireBall,
            ProjectileID.CultistBossFireBallClone,
            ProjectileID.Nail,
            ProjectileID.DesertDjinnCurse,
            ProjectileID.GeyserTrap,
            ProjectileID.DD2BetsyFlameBreath,
            ProjectileID.RollingCactus,
            ProjectileID.RollingCactusSpike,
        };

        public override void Load()
        {
            ProjectileElements.Fire.AddRange(projectiles);
        }

        public override void Unload()
        {
            ProjectileElements.Fire.Clear();
        }
    }
}