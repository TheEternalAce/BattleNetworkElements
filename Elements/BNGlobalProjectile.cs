using BattleNetworkElements.Utilities;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace BattleNetworkElements.Elements
{
    public class BNGlobalProjectile : GlobalProjectile
    {
        internal static List<int> Fire = new();
        internal static List<int> Aqua = new();
        internal static List<int> Elec = new();
        internal static List<int> Wood = new();

        public bool isFire = false;
        public bool isAqua = false;
        public bool isElec = false;
        public bool isWood = false;

        public override bool InstancePerEntity => true;

        public override void OnSpawn(Projectile projectile, IEntitySource source)
        {
            base.OnSpawn(projectile, source);
            if (projectile.IsDefaultFire())
            {
                isFire = true;
            }
            if (projectile.IsDefaultAqua())
            {
                isAqua = true;
            }
            if (projectile.IsDefaultElec())
            {
                isElec = true;
            }
            if (projectile.IsDefaultWood())
            {
                isWood = true;
            }
            //DebugLog(projectile);
        }

        private void DebugLog(Projectile proj)
        {
            string text = proj.Name + " | ";
            if (isFire)
            {
                text += "Fire";
            }
            if (isAqua)
            {
                text += ", Aqua";
            }
            if (isElec)
            {
                text += ", Elec";
            }
            if (isWood)
            {
                text += ", Wood";
            }
            text += "\nDefault: ";
            if (proj.IsFire())
            {
                text += "Fire";
            }
            if (proj.IsAqua())
            {
                text += ", Aqua";
            }
            if (proj.IsElec())
            {
                text += ", Elec";
            }
            if (proj.IsWood())
            {
                text += ", Wood";
            }
            Console.WriteLine(text);
        }
    }
}
