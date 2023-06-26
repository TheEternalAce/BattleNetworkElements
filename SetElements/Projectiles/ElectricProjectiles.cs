using BattleNetworkElements.Elements;
using Terraria.ID;
using Terraria.ModLoader;

namespace BattleNetworkElements.SetElements.Projectiles
{
    internal class ElectricProjectiles : GlobalProjectile
    {
        internal static int[] projectiles =
        {
            // Arrow
            ProjectileID.MoonlordArrow,
            ProjectileID.MoonlordArrowTrail,
            // Bullet
            ProjectileID.MoonlordBullet,
            ProjectileID.NanoBullet,

            // Melee
            ProjectileID.ThunderSpear,
            ProjectileID.ThunderSpearShot,
            ProjectileID.ValkyrieYoyo,
            ProjectileID.InfluxWaver,

            // Ranged
            ProjectileID.PaperAirplaneA,
            ProjectileID.PaperAirplaneB,
            ProjectileID.BoneDagger,
            ProjectileID.BoneJavelin,
            ProjectileID.PulseBolt,
            ProjectileID.Phantasm,
            ProjectileID.PhantasmArrow,
            ProjectileID.VortexBeater,
            ProjectileID.VortexBeaterRocket,
            ProjectileID.Electrosphere,
            ProjectileID.ElectrosphereMissile,

            // Magic
            ProjectileID.ThunderStaffShot,
            ProjectileID.WeatherPainShot,
            ProjectileID.ZapinatorLaser,
            ProjectileID.GreenLaser,
            ProjectileID.PurpleLaser,
            ProjectileID.SkyFracture,
            ProjectileID.EighthNote,
            ProjectileID.QuarterNote,
            ProjectileID.TiedEighthNote,
            ProjectileID.BookStaffShot,
            ProjectileID.DD2ApprenticeStorm,
            ProjectileID.MagnetSphereBall,
            ProjectileID.MagnetSphereBolt,
            ProjectileID.LaserMachinegun,
            ProjectileID.LaserMachinegunLaser,
            ProjectileID.ChargedBlasterCannon,
            ProjectileID.ChargedBlasterOrb,
            ProjectileID.ChargedBlasterLaser,
            ProjectileID.SparkleGuitar,

            // Summon
            ProjectileID.BabyBird,
            ProjectileID.DD2LightningAuraT1,
            ProjectileID.DD2LightningAuraT2,
            ProjectileID.DD2LightningAuraT3,
            ProjectileID.Raven,
            ProjectileID.StormTigerAttack,
            ProjectileID.StormTigerGem,
            ProjectileID.StormTigerTier1,
            ProjectileID.StormTigerTier2,
            ProjectileID.StormTigerTier3,
            ProjectileID.EmpressBlade,
            ProjectileID.UFOMinion,
            ProjectileID.UFOLaser,
            ProjectileID.MoonlordTurret,
            ProjectileID.MoonlordTurretLaser,

            // NPC proj
            ProjectileID.HarpyFeather,
            ProjectileID.Skull,
            ProjectileID.SandnadoHostile,
            ProjectileID.DeathLaser,
            ProjectileID.MartianTurretBolt,
            ProjectileID.MartianWalkerLaser,
            ProjectileID.SaucerDeathray,
            ProjectileID.SaucerLaser,
            ProjectileID.SaucerMissile,
            ProjectileID.SaucerScrap,
            ProjectileID.CultistBossLightningOrb,
            ProjectileID.CultistBossLightningOrbArc,
            ProjectileID.DD2LightningBugZap,
            ProjectileID.VortexLaser,
            ProjectileID.VortexLightning,
            ProjectileID.VortexVortexPortal,
            ProjectileID.VortexVortexLightning,
            ProjectileID.VortexAcid,
        };

        public override void Load()
        {
            BNGlobalProjectile.Elec.AddRange(projectiles);
        }

        public override void Unload()
        {
            BNGlobalProjectile.Elec.Clear();
        }
    }
}
