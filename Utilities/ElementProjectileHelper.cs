using MMZeroElements.Elements;
using Terraria;

namespace MMZeroElements.Utilities
{
    public static class ElementProjectileHelper
    {
        public static ProjectileElements Elements(this Projectile proj)
        {
            return proj.GetGlobalProjectile<ProjectileElements>();
        }

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
            return proj.Elements().isFire;
        }
        public static bool IsDefaultFire(this Projectile proj)
        {
            return proj.type.ProjIsFire();
        }
        public static bool ProjIsFire(this int type)
        {
            return ProjectileElements.Fire.Contains(type);
        }

        public static void AddIceAqua(this Projectile proj)
        {
            proj.type.AddIceAquaProjectile();
        }
        public static void AddIceAquaProjectile(this int projType)
        {
            ProjectileElements.IceAqua.Add(projType);
        }
        public static bool IsIceAqua(this Projectile proj)
        {
            return proj.Elements().isIceAqua;
        }
        public static bool IsDefaultIceAqua(this Projectile proj)
        {
            return proj.type.ProjIsIceAqua();
        }
        public static bool ProjIsIceAqua(this int type)
        {
            return ProjectileElements.IceAqua.Contains(type);
        }

        public static void AddElec(this Projectile proj)
        {
            proj.type.AddElecProjectile();
        }
        public static void AddElecProjectile(this int projType)
        {
            ProjectileElements.Elec.Add(projType);
        }
        public static bool IsElec(this Projectile proj)
        {
            return proj.Elements().isElec;
        }
        public static bool IsDefaultElec(this Projectile proj)
        {
            return proj.type.ProjIsElec();
        }
        public static bool ProjIsElec(this int type)
        {
            return ProjectileElements.Elec.Contains(type);
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
            return proj.Elements().isWood;
        }
        public static bool IsDefaultWood(this Projectile proj)
        {
            return proj.type.ProjIsWood();
        }
        public static bool ProjIsWood(this int type)
        {
            return ProjectileElements.Wood.Contains(type);
        }
    }
}
