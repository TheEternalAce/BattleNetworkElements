using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;

namespace MMZeroElements.SetElements.Projectiles
{
    public class ElectricProjectiles : GlobalProjectile
    {
        static List<int> projectiles = new()
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
            ProjectileID.DD2LightningBugZap,
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
