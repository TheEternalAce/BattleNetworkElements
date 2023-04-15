using MMZeroElements.ElementUI.ElementInfo;
using MMZeroElements.Utilities;
using Terraria;
using Terraria.ModLoader;

namespace MMZeroElements.Elements
{
    public class PlayerElements : ModPlayer
    {
        public float[] elementMultipliers = { 1.0f, 1.0f, 1.0f, 1.0f };
        public static readonly float[] defaultMultipliers = { 1.0f, 1.0f, 1.0f, 1.0f };
        public NPC targetedNPC = null;
        public Item latestItem = null;
        public Projectile latestProj = null;

        public override void ResetEffects()
        {
            elementMultipliers = defaultMultipliers;
            if (MMZeroElements.Client.elementUIDisplayStyle == "Inventory open only")
            {
                if (Main.playerInventory)
                {
                    ModContent.GetInstance<ElementInfoUI>().ShowMyUI();
                }
                else
                {
                    ModContent.GetInstance<ElementInfoUI>().HideMyUI();
                }
            }
        }

        public override void OnHitNPCWithItem(Item item, NPC target, NPC.HitInfo hit, int damageDone)
        {
            targetedNPC = target;
            latestItem = item;
            latestProj = null;
            if (MMZeroElements.Client.elementUIDisplayStyle != "Inventory open only")
            {
                ModContent.GetInstance<ElementInfoUI>().ShowMyUI();
            }
        }

        public override void OnHitNPCWithProj(Projectile proj, NPC target, NPC.HitInfo hit, int damageDone)
        {
            targetedNPC = target;
            latestItem = null;
            latestProj = proj;
            if (MMZeroElements.Client.elementUIDisplayStyle != "Inventory open only")
            {
                ModContent.GetInstance<ElementInfoUI>().ShowMyUI();
            }
        }

        public override void ModifyHitByNPC(NPC npc, ref Player.HurtModifiers modifiers)
        {
            targetedNPC = npc;
            if (MMZeroElements.Client.elementUIDisplayStyle != "Inventory open only")
            {
                ModContent.GetInstance<ElementInfoUI>().ShowMyUI();
            }
            modifiers.FinalDamage *= ElementHelper.MultiplyDamage(npc, Player);
        }

        public override void ModifyHitByProjectile(Projectile proj, ref Player.HurtModifiers modifiers)
        {
            latestProj = proj;
            if (MMZeroElements.Client.elementUIDisplayStyle != "Inventory open only")
            {
                ModContent.GetInstance<ElementInfoUI>().ShowMyUI();
            }
            modifiers.FinalDamage *= ElementHelper.MultiplyDamage(proj, Player);
        }
    }
}
