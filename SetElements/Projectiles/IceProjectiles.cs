using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;

namespace MMZeroElements.SetElements.Projectiles
{
    public class IceProjectiles : GlobalProjectile
    {
        static List<int> projectiles = new()
        {
            // Arrow
            ProjectileID.FrostburnArrow,
            ProjectileID.UnholyArrow,
            ProjectileID.HolyArrow,
            ProjectileID.IchorArrow,
            ProjectileID.ShimmerArrow,
            // Bullet
            ProjectileID.IchorBullet,
            // Rocket
            ProjectileID.WetRocket,
            ProjectileID.HoneyRocket,
            // Misc Ammo
            ProjectileID.PoisonDart,
            ProjectileID.IchorDart,
            ProjectileID.Seed,
            ProjectileID.Ale,
            ProjectileID.CandyCorn,

            // Accessory
            ProjectileID.StardustGuardian,
            ProjectileID.InsanityShadowFriendly,

            // Melee
            ProjectileID.Amarok,
            ProjectileID.BloodButcherer,
            ProjectileID.Flairon,
            ProjectileID.FlaironBubble,
            ProjectileID.FrostBoltSword,
            ProjectileID.FruitcakeChakram,
            ProjectileID.IceBolt,
            ProjectileID.IceBoomerang,
            ProjectileID.Muramasa,
            ProjectileID.NorthPoleSpear,
            ProjectileID.NorthPoleSnowflake,
            ProjectileID.NorthPoleWeapon,
            ProjectileID.Shroomerang,
            ProjectileID.Swordfish,

            // Ranged
            ProjectileID.BloodArrow,
            ProjectileID.FrostArrow,
            ProjectileID.PainterPaintball,
            ProjectileID.SnowBallFriendly,
            ProjectileID.StarAnise,
            ProjectileID.ToxicBubble,

            // Magic
            ProjectileID.WaterStream,
            ProjectileID.Blizzard,
            ProjectileID.SharpTears,
            ProjectileID.Bubble,
            ProjectileID.BloodCloudMoving,
            ProjectileID.BloodCloudRaining,
            ProjectileID.BloodRain,
            ProjectileID.BallofFrost,
            ProjectileID.FrostBoltStaff,
            ProjectileID.GoldenShowerFriendly,
            ProjectileID.IceBlock,
            ProjectileID.SoulDrain,
            ProjectileID.NebulaArcanum,
            ProjectileID.NebulaArcanumExplosionShot,
            ProjectileID.NebulaArcanumExplosionShotShard,
            ProjectileID.NebulaArcanumSubshot,
            ProjectileID.RainCloudMoving,
            ProjectileID.RainCloudRaining,
            ProjectileID.RainFriendly,
            ProjectileID.Typhoon,
            ProjectileID.LostSoulFriendly,
            ProjectileID.ToxicFlask,
            ProjectileID.ToxicCloud,
            ProjectileID.ToxicCloud2,
            ProjectileID.ToxicCloud3,
            //ProjectileID.Frostspark,
            ProjectileID.WaterBolt,

            // Summon
            ProjectileID.AbigailCounter,
            ProjectileID.AbigailMinion,
            ProjectileID.CoolWhip,
            ProjectileID.CoolWhipProj,
            ProjectileID.FlinxMinion,
            ProjectileID.BatOfLight,
            ProjectileID.BabySlime,
            ProjectileID.FrostHydra,
            ProjectileID.FrostBlastFriendly,
            ProjectileID.StardustCellMinion,
            ProjectileID.StardustCellMinionShot,
            ProjectileID.StardustDragon1,
            ProjectileID.StardustDragon2,
            ProjectileID.StardustDragon3,
            ProjectileID.StardustDragon4,
            ProjectileID.Tempest,
            ProjectileID.MiniSharkron,
            ProjectileID.ThornWhip,

            // NPC proj
            ProjectileID.SpikedSlimeSpike,
            ProjectileID.IceSpike,
            ProjectileID.JungleSpike,
            ProjectileID.IcewaterSpit,
            ProjectileID.RainNimbus,
            ProjectileID.FrostBeam,
            ProjectileID.BloodShot,
            ProjectileID.BloodNautilusTears,
            ProjectileID.BloodNautilusShot,
            ProjectileID.Shadowflames,
            ProjectileID.DeerclopsIceSpike,
            ProjectileID.DeerclopsRangedProjectile,
            ProjectileID.InsanityShadowHostile,
            ProjectileID.QueenSlimeGelAttack,
            ProjectileID.QueenSlimeMinionBlueSpike,
            ProjectileID.QueenSlimeMinionPinkBall,
            ProjectileID.QueenSlimeSmash,
            ProjectileID.Sharknado,
            ProjectileID.SharknadoBolt,
            ProjectileID.Cthulunado,
        };

        public override void Load()
        {
            ProjectileElements.Ice.AddRange(projectiles);
        }

        public override void Unload()
        {
            ProjectileElements.Ice.Clear();
        }
    }
}
