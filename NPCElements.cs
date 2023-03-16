using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace MMZeroElements
{
    public class NPCElements : GlobalNPC
    {
        public static List<int> Fire = new();
        public static List<int> Ice = new();
        public static List<int> Electric = new();
        public static List<int> Metal = new();
        /// <summary>
        /// Elemental multipliers for a given NPC in the following order: Fire, Ice, Electric, Metal
        /// </summary>
        public double[] elementMultipliers = { 1.0, 1.0, 1.0, 1.0 };

        public override bool InstancePerEntity => true;

        public override void ModifyHitByItem(NPC npc, Player player, Item item, ref int damage, ref float knockback, ref bool crit)
        {
            double modifier = 1.0;
            Color color = Color.Blue;
            if (WeaponElements.Fire.Contains(item.type))
            {
                modifier *= elementMultipliers[Element.Fire];
            }
            if (WeaponElements.Ice.Contains(item.type))
            {
                modifier *= elementMultipliers[Element.Ice];
            }
            if (WeaponElements.Electric.Contains(item.type))
            {
                modifier *= elementMultipliers[Element.Electric];
            }
            if (WeaponElements.Metal.Contains(item.type))
            {
                modifier *= elementMultipliers[Element.Metal];
            }
            int ct = CombatText.NewText(npc.getRect(), color, (float)modifier + "x");
            Main.combatText[ct].position.Y -= 45;
            damage = (int)Math.Ceiling(damage * modifier);

            base.ModifyHitByItem(npc, player, item, ref damage, ref knockback, ref crit);
        }

        public override void ModifyHitByProjectile(NPC npc, Projectile projectile, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
        {
            ProjectileElements elementProj = projectile.GetGlobalProjectile<ProjectileElements>();
            double modifier = 1.0;
            Color color = Color.Blue;
            if (ProjectileElements.Fire.Contains(projectile.type) || elementProj.tempFire)
            {
                modifier *= elementMultipliers[Element.Fire];
            }
            if (ProjectileElements.Ice.Contains(projectile.type) || elementProj.tempIce)
            {
                modifier *= elementMultipliers[Element.Ice];
            }
            if (ProjectileElements.Electric.Contains(projectile.type) || elementProj.tempElectric)
            {
                modifier *= elementMultipliers[Element.Electric];
            }
            if (ProjectileElements.Metal.Contains(projectile.type) || elementProj.tempMetal)
            {
                modifier *= elementMultipliers[Element.Metal];
            }
            int ct = CombatText.NewText(npc.getRect(), color, (float)modifier + "x");
            Main.combatText[ct].position.Y -= 45;
            damage = (int)Math.Ceiling(damage * modifier);

            base.ModifyHitByProjectile(npc, projectile, ref damage, ref knockback, ref crit, ref hitDirection);
        }
    }
}
