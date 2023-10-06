using BattleNetworkElements.Elements;
using Terraria;

namespace BattleNetworkElements.Utilities
{
    public static class ElementProjectileHelper
    {
        public static BNGlobalProjectile Elements(this Projectile proj)
        {
            return proj.GetGlobalProjectile<BNGlobalProjectile>();
        }

        public static void AddFire(this Projectile proj)
        {
            proj.type.AddFireProjectile();
        }
        public static void AddFireProjectile(this int projType)
        {
            BNGlobalProjectile.Fire.Add(projType);
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
            return BNGlobalProjectile.Fire.Contains(type);
        }

        public static void AddAqua(this Projectile proj)
        {
            proj.type.AddAquaProjectile();
        }
        public static void AddAquaProjectile(this int projType)
        {
            BNGlobalProjectile.Aqua.Add(projType);
        }
        public static bool IsAqua(this Projectile proj)
        {
            return proj.Elements().isAqua;
        }
        public static bool IsDefaultAqua(this Projectile proj)
        {
            return proj.type.ProjIsAqua();
        }
        public static bool ProjIsAqua(this int type)
        {
            return BNGlobalProjectile.Aqua.Contains(type);
        }

        public static void AddElec(this Projectile proj)
        {
            proj.type.AddElecProjectile();
        }
        public static void AddElecProjectile(this int projType)
        {
            BNGlobalProjectile.Elec.Add(projType);
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
            return BNGlobalProjectile.Elec.Contains(type);
        }

        public static void AddWood(this Projectile proj)
        {
            proj.type.AddWoodProjectile();
        }
        public static void AddWoodProjectile(this int projType)
        {
            BNGlobalProjectile.Wood.Add(projType);
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
            return BNGlobalProjectile.Wood.Contains(type);
        }

        public static bool[] ElementBoolArray(this Projectile projectile)
        {
            bool[] elements = new bool[4];
            elements[0] = projectile.IsFire();
            elements[1] = projectile.IsAqua();
            elements[2] = projectile.IsElec();
            elements[3] = projectile.IsWood();
            return elements;
        }
    }
}
