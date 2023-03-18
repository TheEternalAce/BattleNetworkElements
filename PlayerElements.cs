using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ModLoader;

namespace MMZeroElements
{
    public class PlayerElements : ModPlayer
    {
        public float[] elementMultiplier = { 1.0f, 1.0f, 1.0f, 1.0f };
        public NPC targetedNPC = null;

        public override void OnHitNPC(Item item, NPC target, int damage, float knockback, bool crit)
        {
            targetedNPC = target;
        }

        public override void OnHitNPCWithProj(Projectile proj, NPC target, int damage, float knockback, bool crit)
        {
            targetedNPC = target;
        }

        public override void ModifyHitByNPC(NPC npc, ref int damage, ref bool crit)
        {
            float modifier = 1.0f;
            Color color = Color.Blue;
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
            int ct = CombatText.NewText(Player.getRect(), color, modifier + "x");
            Main.combatText[ct].position.Y -= 45;
            damage = (int)Math.Ceiling(damage * modifier);
            targetedNPC = npc;

            base.ModifyHitByNPC(npc, ref damage, ref crit);
        }

        public override void ModifyHitByProjectile(Projectile proj, ref int damage, ref bool crit)
        {
            ProjectileElements elementProj = proj.GetGlobalProjectile<ProjectileElements>();
            float modifier = 1.0f;
            Color color = Color.Blue;
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
            int ct = CombatText.NewText(Player.getRect(), color, modifier + "x");
            Main.combatText[ct].position.Y -= 45;
            damage = (int)Math.Ceiling(damage * modifier);

            base.ModifyHitByProjectile(proj, ref damage, ref crit);
        }

        public override void ModifyHitPvp(Item item, Player target, ref int damage, ref bool crit)
        {
            float modifier = 1.0f;
            Color color = Color.Blue;
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
            int ct = CombatText.NewText(Player.getRect(), color, modifier + "x");
            Main.combatText[ct].position.Y -= 45;
            damage = (int)Math.Ceiling(damage * modifier);

            base.ModifyHitPvp(item, target, ref damage, ref crit);
        }

        public override void ModifyHitPvpWithProj(Projectile proj, Player target, ref int damage, ref bool crit)
        {
            ProjectileElements elementProj = proj.GetGlobalProjectile<ProjectileElements>();
            float modifier = 1.0f;
            Color color = Color.Blue;
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
            int ct = CombatText.NewText(Player.getRect(), color, modifier + "x");
            Main.combatText[ct].position.Y -= 45;
            damage = (int)Math.Ceiling(damage * modifier);

            base.ModifyHitPvpWithProj(proj, target, ref damage, ref crit);
        }
    }
}
