using MMZeroElements.Utilities;
using System.Collections.Generic;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace MMZeroElements.Elements
{
    public class ProjectileElements : GlobalProjectile
    {
        internal static List<int> Fire = new();
        internal static List<int> Ice = new();
        internal static List<int> Electric = new();
        internal static List<int> Wood = new();

        public bool tempFire = false;
        public bool tempIce = false;
        public bool tempElectric = false;
        public bool tempWood = false;

        public override bool InstancePerEntity => true;

        public override void OnSpawn(Projectile projectile, IEntitySource source)
        {
            if (source is EntitySource_Parent parentSource)
            {
                if (parentSource.Entity is NPC npc)
                {
                    if (npc.IsFire())
                    {
                        tempFire = true;
                    }
                    if (npc.IsIce())
                    {
                        tempIce = true;
                    }
                    if (npc.IsElec())
                    {
                        tempElectric = true;
                    }
                }
                else if (parentSource.Entity is Projectile proj)
                {
                    int sourceProjType = proj.type;
                    if (Fire.Contains(sourceProjType))
                    {
                        tempFire = true;
                    }
                    if (Ice.Contains(sourceProjType))
                    {
                        tempIce = true;
                    }
                    if (Electric.Contains(sourceProjType))
                    {
                        tempElectric = true;
                    }
                }
            }
            //if (FireProj.Contains(type))
            //{
            //    ChatHelper.BroadcastChatMessage(NetworkText.FromLiteral("Fire Projectile: " + projectile.Name), Color.White);
            //}
            //if (IceProj.Contains(type))
            //{
            //    ChatHelper.BroadcastChatMessage(NetworkText.FromLiteral("Ice Projectile: " + projectile.Name), Color.White);
            //}
            //if (ElectricProj.Contains(type))
            //{
            //    ChatHelper.BroadcastChatMessage(NetworkText.FromLiteral("Electric Projectile: " + projectile.Name), Color.White);
            //}
        }
    }
}
