using Terraria;

namespace MMZeroElements.Utilities
{
    public static class ProjectileHelper
    {
        public static void AddFire(this Projectile proj)
        {
            proj.type.AddFireProjectile();
        }
        public static void AddFireProjectile(this int projType)
        {
            ProjectileElements.Fire.Add(projType);
        }

        public static void AddIce(this Projectile proj)
        {
            proj.type.AddIceProjectile();
        }
        public static void AddIceProjectile(this int projType)
        {
            ProjectileElements.Ice.Add(projType);
        }

        public static void AddElectric(this Projectile proj)
        {
            proj.type.AddElectricProjectile();
        }
        public static void AddElectricProjectile(this int projType)
        {
            ProjectileElements.Electric.Add(projType);
        }
    }
}
