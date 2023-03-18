using System.Collections.Generic;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace MMZeroElements
{
    public class ProjectileElements : GlobalProjectile
    {
        public static List<int> Fire = new();
        public static List<int> Ice = new();
        public static List<int> Electric = new();
        public static List<int> Metal = new();

        public bool tempFire = false;
        public bool tempIce = false;
        public bool tempElectric = false;
        public bool tempMetal = false;

        public override bool InstancePerEntity => true;

        public override void OnSpawn(Projectile projectile, IEntitySource source)
        {
            if (source is EntitySource_Parent parentSource)
            {
                if (parentSource.Entity is NPC npc)
                {
                    int sourceEnemy = npc.type;
                    if (NPCElements.Fire.Contains(sourceEnemy))
                    {
                        tempFire = true;
                    }
                    if (NPCElements.Ice.Contains(sourceEnemy))
                    {
                        tempIce = true;
                    }
                    if (NPCElements.Electric.Contains(sourceEnemy))
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
