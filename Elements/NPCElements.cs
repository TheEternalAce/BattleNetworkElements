using MMZeroElements.Utilities;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace MMZeroElements.Elements
{
    public class NPCElements : GlobalNPC
    {
        internal static List<int> Fire = new();
        internal static List<int> IceAqua = new();
        internal static List<int> Electric = new();
        internal static List<int> Wood = new();
        /// <summary>
        /// Elemental multipliers for a given NPC in the following order: Fire, Ice, Electric, Metal
        /// </summary>
        public float[] elementMultipliers = { 1.0f, 1.0f, 1.0f, 1.0f };

        public override bool InstancePerEntity => true;

        public override void ModifyHitByItem(NPC npc, Player player, Item item, ref NPC.HitModifiers modifiers)
        {
            modifiers.FinalDamage *= ElementHelper.MultiplyDamage(item, npc);
        }

        public override void ModifyHitByProjectile(NPC npc, Projectile projectile, ref NPC.HitModifiers modifiers)
        {
            modifiers.FinalDamage *= ElementHelper.MultiplyDamage(projectile, npc);
        }

        public override void ModifyHitNPC(NPC npc, NPC target, ref NPC.HitModifiers modifiers)
        {
            modifiers.FinalDamage *= ElementHelper.MultiplyDamage(npc, target);
        }
    }
}
