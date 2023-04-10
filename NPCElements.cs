using Microsoft.Xna.Framework;
using MMZeroElements.Utilities;
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
        internal static List<int> Wood = new();
        /// <summary>
        /// Elemental multipliers for a given NPC in the following order: Fire, Ice, Electric, Metal
        /// </summary>
        public float[] elementMultipliers = { 1.0f, 1.0f, 1.0f, 1.0f };

        public override bool InstancePerEntity => true;

        public override void ModifyHitByItem(NPC npc, Player player, Item item, ref int damage, ref float knockback, ref bool crit)
        {
            float multiplier = 1.0f;
            Color color = Color.Blue;
            if (item.IsFire())
            {
                multiplier *= elementMultipliers[Element.Fire];
            }
            if (item.IsIce())
            {
                multiplier *= elementMultipliers[Element.Ice];
            }
            if (item.IsElec())
            {
                multiplier *= elementMultipliers[Element.Electric];
            }
            //if (item.IsWood())
            //{
            //    multiplier *= elementMultipliers[Element.Wood];
            //}
            int ct = CombatText.NewText(npc.getRect(), color, multiplier + "x");
            Main.combatText[ct].position.Y -= 45;
            damage = (int)(damage * multiplier);

            base.ModifyHitByItem(npc, player, item, ref damage, ref knockback, ref crit);
        }

        public override void ModifyHitByProjectile(NPC npc, Projectile projectile, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
        {
            float multiplier = 1.0f;
            Color color = Color.Blue;
            if (projectile.IsFire())
            {
                multiplier *= elementMultipliers[Element.Fire];
            }
            if (projectile.IsIce())
            {
                multiplier *= elementMultipliers[Element.Ice];
            }
            if (projectile.IsElec())
            {
                multiplier *= elementMultipliers[Element.Electric];
            }
            //if (projectile.IsWood())
            //{
            //    multiplier *= elementMultipliers[Element.Wood];
            //}
            int ct = CombatText.NewText(npc.getRect(), color, multiplier + "x");
            Main.combatText[ct].position.Y -= 45;
            damage = (int)(damage * multiplier);

            base.ModifyHitByProjectile(npc, projectile, ref damage, ref knockback, ref crit, ref hitDirection);
        }

        public override void ModifyHitNPC(NPC npc, NPC target, ref int damage, ref float knockback, ref bool crit)
        {
            float multiplier = 1.0f;
            Color color = Color.Blue;
            NPCElements targetElements = target.GetGlobalNPC<NPCElements>();
            if (npc.IsFire())
            {
                multiplier *= targetElements.elementMultipliers[Element.Fire];
            }
            if (npc.IsIce())
            {
                multiplier *= targetElements.elementMultipliers[Element.Ice];
            }
            if (npc.IsElec())
            {
                multiplier *= targetElements.elementMultipliers[Element.Electric];
            }
            //if (npc.IsWood())
            //{
            //    multiplier *= targetElements.elementMultipliers[Element.Wood];
            //}
            int ct = CombatText.NewText(npc.getRect(), color, multiplier + "x");
            Main.combatText[ct].position.Y -= 45;
            damage = (int)(damage * multiplier);

            base.ModifyHitNPC(npc, target, ref damage, ref knockback, ref crit);
        }
    }
}
