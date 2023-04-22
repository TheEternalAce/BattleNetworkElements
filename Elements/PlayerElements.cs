using MMZeroElements.ElementUI.ElementInfo;
using MMZeroElements.Utilities;
using Terraria;
using Terraria.ModLoader;

namespace MMZeroElements.Elements
{
    public class PlayerElements : ModPlayer
    {
        public float[] elementMultipliers = { 1.0f, 1.0f, 1.0f, 1.0f };
        static readonly float[] defaultMultipliers = { 1.0f, 1.0f, 1.0f, 1.0f };
        public NPC targetedNPC { get; private set; } = null;
        public Item latestItem { get; private set; } = null;
        public Projectile latestProj { get; private set; } = null;

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

        void UpdateInfo(NPC npc, Item item, Projectile projectile)
        {
            targetedNPC = npc;
            if (projectile?.owner == Player.whoAmI)
            {
                latestProj = projectile;
            }
            latestItem = item;
            if (MMZeroElements.Client.elementUIDisplayStyle != "Inventory open only")
            {
                ModContent.GetInstance<ElementInfoUI>().ShowMyUI();
            }
        }

        public override void OnHitNPCWithItem(Item item, NPC target, NPC.HitInfo hit, int damageDone)
        {
            UpdateInfo(target, item, null);
        }

        public override void OnHitNPCWithProj(Projectile proj, NPC target, NPC.HitInfo hit, int damageDone)
        {
            UpdateInfo(target, null, proj);
        }

        public override void ModifyHitByNPC(NPC npc, ref Player.HurtModifiers modifiers)
        {
            UpdateInfo(npc, latestItem, latestProj);

            modifiers.FinalDamage *= ElementHelper.MultiplyDamage(npc, Player);
        }

        public override void ModifyHitByProjectile(Projectile proj, ref Player.HurtModifiers modifiers)
        {
            UpdateInfo(targetedNPC, latestItem, proj);

            modifiers.FinalDamage *= ElementHelper.MultiplyDamage(proj, Player);
        }
    }
}
