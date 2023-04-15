using MMZeroElements.Elements;
using Terraria;

namespace MMZeroElements.Utilities
{
    public static class ElementProjectileHelper
    {
        public static void AddFire(this Projectile proj)
        {
            proj.type.AddFireProjectile();
        }
        public static void AddFireProjectile(this int projType)
        {
            ProjectileElements.Fire.Add(projType);
        }
        public static bool IsFire(this Projectile proj)
        {
            return proj.type.ProjIsFire();
        }
        public static bool ProjIsFire(this int type)
        {
            return ProjectileElements.Fire.Contains(type);
        }

        public static void AddIce(this Projectile proj)
        {
            proj.type.AddIceProjectile();
        }
        public static void AddIceProjectile(this int projType)
        {
            ProjectileElements.Ice.Add(projType);
        }
        public static bool IsIce(this Projectile proj)
        {
            return proj.type.ProjIsIce();
        }
        public static bool ProjIsIce(this int type)
        {
            return ProjectileElements.Ice.Contains(type);
        }

        public static void AddElec(this Projectile proj)
        {
            proj.type.AddElecProjectile();
        }
        public static void AddElecProjectile(this int projType)
        {
            ProjectileElements.Electric.Add(projType);
        }
        public static bool IsElec(this Projectile proj)
        {
            return proj.type.ProjIsElec();
        }
        public static bool ProjIsElec(this int type)
        {
            return ProjectileElements.Electric.Contains(type);
        }

        public static void AddWood(this Projectile proj)
        {
            proj.type.AddWoodProjectile();
        }
        public static void AddWoodProjectile(this int projType)
        {
            ProjectileElements.Wood.Add(projType);
        }
        public static bool IsWood(this Projectile proj)
        {
            return proj.type.ProjIsWood();
        }
        public static bool ProjIsWood(this int type)
        {
            return ProjectileElements.Wood.Contains(type);
        }
    }
}
