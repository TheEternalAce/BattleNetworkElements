using MMZeroElements.Elements;
using Terraria.ID;
using Terraria.ModLoader;

namespace MMZeroElements.SetElements.Projectiles
{
    internal class WoodProjectiles : GlobalProjectile
    {
        internal static int[] poison =
        {
            // Arrow
            ProjectileID.VenomArrow,
            // Bullet
            ProjectileID.VenomBullet,
            // Misc Ammo
            ProjectileID.Stynger,
            ProjectileID.StyngerShrapnel,

            // Accessory
            ProjectileID.GiantBee,
            ProjectileID.CrystalLeaf,
            ProjectileID.CrystalLeafShot,

            // Melee
            //ProjectileID.BladeOfGrass,
            ProjectileID.MushroomSpear,
            ProjectileID.Mushroom,
            ProjectileID.ThornChakram,

            // Ranged
            ProjectileID.Beenade,
            ProjectileID.PoisonedKnife,

            // Magic
            ProjectileID.Bee,
            ProjectileID.PoisonFang,
            ProjectileID.VenomFang,
            ProjectileID.Wasp,

            // Summon
            ProjectileID.Hornet,
            ProjectileID.HornetStinger,
            ProjectileID.SpiderHiver,
            ProjectileID.SpiderEgg,
            ProjectileID.VenomSpider,
            ProjectileID.JumperSpider,
            ProjectileID.DangerousSpider,
            ProjectileID.VampireFrog,

            // NPC proj
            ProjectileID.Stinger,
            ProjectileID.HornetStinger,
            ProjectileID.QueenBeeStinger,
            ProjectileID.SeedPlantera,
            ProjectileID.PoisonSeedPlantera,
            ProjectileID.ThornBall,
            ProjectileID.RollingCactus,
            ProjectileID.RollingCactusSpike,
        };

        public override void Load()
        {
            ProjectileElements.Wood.AddRange(poison);
        }

        public override void Unload()
        {
            ProjectileElements.Wood.Clear();
        }
    }
}
