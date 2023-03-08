using System;
using MMZeroElements.Utilities;
using Terraria;
using Terraria.ModLoader;

namespace MMZeroElements
{
    public class PlayerElements : ModPlayer
    {
        public float[] elementMultiplier = { 1.0f, 1.0f, 1.0f, 1.0f };
        public override void ModifyHitByNPC(NPC npc, ref int damage, ref bool crit)
        {
            float modifier = 1.0f;
            if (NPCElements.Fire.Contains(npc.type))
            {
                modifier *= elementMultiplier[Element.Fire];
            }
            if (NPCElements.Ice.Contains(npc.type))
            {
                modifier *= elementMultiplier[Element.Ice];
            }
            if (NPCElements.Electric.Contains(npc.type))
            {
                modifier *= elementMultiplier[Element.Electric];
            }
            if (NPCElements.Metal.Contains(npc.type))
            {
                modifier *= elementMultiplier[Element.Metal];
            }
            damage = (int)Math.Ceiling(damage * modifier);

            base.ModifyHitByNPC(npc, ref damage, ref crit);
        }

        public override void ModifyHitByProjectile(Projectile proj, ref int damage, ref bool crit)
        {
            ProjectileElements elementProj = proj.GetGlobalProjectile<ProjectileElements>();
            float modifier = 1.0f;
            if (ProjectileElements.Fire.Contains(proj.type) || elementProj.tempFire)
            {
                modifier *= elementMultiplier[Element.Fire];
            }
            if (ProjectileElements.Ice.Contains(proj.type) || elementProj.tempIce)
            {
                modifier *= elementMultiplier[Element.Ice];
            }
            if (ProjectileElements.Electric.Contains(proj.type) || elementProj.tempElectric)
            {
                modifier *= elementMultiplier[Element.Electric];
            }
            if (ProjectileElements.Metal.Contains(proj.type) || elementProj.tempMetal)
            {
                modifier *= elementMultiplier[Element.Metal];
            }
            damage = (int)Math.Ceiling(damage * modifier);

            base.ModifyHitByProjectile(proj, ref damage, ref crit);
        }

        public override void ModifyHitPvp(Item item, Player target, ref int damage, ref bool crit)
        {
            float modifier = 1.0f;
            if (WeaponElements.Fire.Contains(item.type))
            {
                modifier *= elementMultiplier[Element.Fire];
            }
            if (WeaponElements.Ice.Contains(item.type))
            {
                modifier *= elementMultiplier[Element.Ice];
            }
            if (WeaponElements.Electric.Contains(item.type))
            {
                modifier *= elementMultiplier[Element.Electric];
            }
            if (WeaponElements.Metal.Contains(item.type))
            {
                modifier *= elementMultiplier[Element.Metal];
            }
            damage = (int)Math.Ceiling(damage * modifier);

            base.ModifyHitPvp(item, target, ref damage, ref crit);
        }

        public override void ModifyHitPvpWithProj(Projectile proj, Player target, ref int damage, ref bool crit)
        {
            ProjectileElements elementProj = proj.GetGlobalProjectile<ProjectileElements>();
            float modifier = 1.0f;
            if (ProjectileElements.Fire.Contains(proj.type) || elementProj.tempFire)
            {
                modifier *= elementMultiplier[Element.Fire];
            }
            if (ProjectileElements.Ice.Contains(proj.type) || elementProj.tempIce)
            {
                modifier *= elementMultiplier[Element.Ice];
            }
            if (ProjectileElements.Electric.Contains(proj.type) || elementProj.tempElectric)
            {
                modifier *= elementMultiplier[Element.Electric];
            }
            if (ProjectileElements.Metal.Contains(proj.type) || elementProj.tempMetal)
            {
                modifier *= elementMultiplier[Element.Metal];
            }
            damage = (int)Math.Ceiling(damage * modifier);

            base.ModifyHitPvpWithProj(proj, target, ref damage, ref crit);
        }
    }
}
