using System.Collections.Generic;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
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

        public override void SetDefaults(Projectile proj)
        {
            int type = proj.type;
            switch (type)
            {
                // Rocket
                case ProjectileID.RocketI:
                case ProjectileID.RocketII:
                case ProjectileID.RocketIII:
                case ProjectileID.RocketIV:
                case ProjectileID.ClusterRocketI:
                case ProjectileID.ClusterRocketII:
                case ProjectileID.DryRocket:
                case ProjectileID.LavaRocket:
                case ProjectileID.MiniNukeRocketI:
                case ProjectileID.MiniNukeRocketII:

                case ProjectileID.RocketSnowmanI:
                case ProjectileID.RocketSnowmanII:
                case ProjectileID.RocketSnowmanIII:
                case ProjectileID.RocketSnowmanIV:
                case ProjectileID.ClusterSnowmanRocketI:
                case ProjectileID.ClusterSnowmanRocketII:
                case ProjectileID.DrySnowmanRocket:
                case ProjectileID.LavaSnowmanRocket:
                case ProjectileID.MiniNukeSnowmanRocketI:
                case ProjectileID.MiniNukeSnowmanRocketII:

                case ProjectileID.GrenadeI:
                case ProjectileID.GrenadeII:
                case ProjectileID.GrenadeIII:
                case ProjectileID.GrenadeIV:
                case ProjectileID.ClusterGrenadeI:
                case ProjectileID.ClusterGrenadeII:
                case ProjectileID.DryGrenade:
                case ProjectileID.LavaGrenade:
                case ProjectileID.MiniNukeGrenadeI:
                case ProjectileID.MiniNukeGrenadeII:

                case ProjectileID.ProximityMineI:
                case ProjectileID.ProximityMineII:
                case ProjectileID.ProximityMineIII:
                case ProjectileID.ProximityMineIV:
                case ProjectileID.ClusterMineI:
                case ProjectileID.ClusterMineII:
                case ProjectileID.DryMine:
                case ProjectileID.LavaMine:
                case ProjectileID.MiniNukeMineI:
                case ProjectileID.MiniNukeMineII:

                case ProjectileID.RocketFireworkRed:
                case ProjectileID.RocketFireworkGreen:
                case ProjectileID.RocketFireworkBlue:
                case ProjectileID.RocketFireworkYellow:

                case ProjectileID.Celeb2Rocket:
                case ProjectileID.Celeb2RocketExplosive:
                case ProjectileID.Celeb2RocketLarge:
                case ProjectileID.Celeb2RocketExplosiveLarge:

                // Magic
                case ProjectileID.Spark:

                // Melee
                //case ProjectileID.BladeofGrassLeaf:
                case ProjectileID.ThornChakram:
                    Fire.Add(type);
                    break;

                // Rocket
                case ProjectileID.WetRocket:
                case ProjectileID.HoneyRocket:
                case ProjectileID.WetSnowmanRocket:
                case ProjectileID.HoneySnowmanRocket:
                case ProjectileID.WetGrenade:
                case ProjectileID.HoneyGrenade:
                case ProjectileID.WetMine:
                case ProjectileID.HoneyMine:

                // Other ammo
                case ProjectileID.PoisonDart:
                case ProjectileID.IchorDart:

                // Melee
                case ProjectileID.IceBolt:

                // Other projectile
                case ProjectileID.PoisonDartBlowgun:
                case ProjectileID.PoisonDartTrap:
                    Ice.Add(type);
                    break;

                // Rocket
                case ProjectileID.ElectrosphereMissile:
                case ProjectileID.Electrosphere:

                // Magic
                case ProjectileID.ThunderSpear:
                case ProjectileID.ThunderSpearShot:
                case ProjectileID.ThunderStaffShot:
                    Electric.Add(type);
                    break;

                // Melee
                case ProjectileID.TheRottedFork:
                case ProjectileID.TheMeatball:
                case ProjectileID.BallOHurt:
                    Metal.Add(type);
                    break;
            }
        }

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
                    if (NPCElements.Metal.Contains(sourceEnemy))
                    {
                        tempMetal = true;
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
                    if (Metal.Contains(sourceProjType))
                    {
                        tempMetal = true;
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
            //if (MetalProj.Contains(type))
            //{
            //    ChatHelper.BroadcastChatMessage(NetworkText.FromLiteral("Metal Projectile: " + projectile.Name), Color.White);
            //}
        }
    }
}
