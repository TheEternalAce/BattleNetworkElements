using Microsoft.Xna.Framework;
using MMZeroElements.ElementUI.ElementInfo;
using MMZeroElements.Utilities;
using Terraria;
using Terraria.ModLoader;

namespace MMZeroElements
{
    public class PlayerElements : ModPlayer
    {
        public float[] elementMultiplier = { 1.0f, 1.0f, 1.0f, 1.0f };
        public NPC targetedNPC = null;
        public Item latestItem = null;
        public Projectile latestProj = null;

        public override void ResetEffects()
        {
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

        public override void OnHitNPC(Item item, NPC target, int damage, float knockback, bool crit)
        {
            targetedNPC = target;
            latestItem = item;
            latestProj = null;
            if (MMZeroElements.Client.elementUIDisplayStyle != "Inventory open only")
            {
                ModContent.GetInstance<ElementInfoUI>().ShowMyUI();
            }
        }

        public override void OnHitNPCWithProj(Projectile proj, NPC target, int damage, float knockback, bool crit)
        {
            targetedNPC = target;
            latestItem = null;
            latestProj = proj;
            if (MMZeroElements.Client.elementUIDisplayStyle != "Inventory open only")
            {
                ModContent.GetInstance<ElementInfoUI>().ShowMyUI();
            }
        }

        public override void ModifyHitByNPC(NPC npc, ref int damage, ref bool crit)
        {
            float multiplier = 1.0f;
            Color color = Color.Blue;
            if (npc.IsFire())
            {
                multiplier *= elementMultiplier[Element.Fire];
            }
            if (npc.IsIce())
            {
                multiplier *= elementMultiplier[Element.Ice];
            }
            if (npc.IsElec())
            {
                multiplier *= elementMultiplier[Element.Electric];
            }
            //if (npc.IsWood())
            //{
            //    multiplier *= elementMultiplier[Element.Wood];
            //}
            int ct = CombatText.NewText(Player.getRect(), color, multiplier + "x");
            Main.combatText[ct].position.Y -= 45;
            damage = (int)(damage * multiplier);
            targetedNPC = npc;
            if (MMZeroElements.Client.elementUIDisplayStyle != "Inventory open only")
            {
                ModContent.GetInstance<ElementInfoUI>().ShowMyUI();
            }

            base.ModifyHitByNPC(npc, ref damage, ref crit);
        }

        public override void ModifyHitByProjectile(Projectile proj, ref int damage, ref bool crit)
        {
            ProjectileElements elementProj = proj.GetGlobalProjectile<ProjectileElements>();
            float multiplier = 1.0f;
            Color color = Color.Blue;
            if (proj.IsFire() || elementProj.tempFire)
            {
                multiplier *= elementMultiplier[Element.Fire];
            }
            if (proj.IsIce() || elementProj.tempIce)
            {
                multiplier *= elementMultiplier[Element.Ice];
            }
            if (proj.IsElec() || elementProj.tempElectric)
            {
                multiplier *= elementMultiplier[Element.Electric];
            }
            //if (proj.IsWood() || elementProj.tempWood)
            //{
            //    multiplier *= elementMultiplier[Element.Wood];
            //}
            int ct = CombatText.NewText(Player.getRect(), color, multiplier + "x");
            Main.combatText[ct].position.Y -= 45;
            damage = (int)(damage * multiplier);
            latestProj = proj;
            if (MMZeroElements.Client.elementUIDisplayStyle != "Inventory open only")
            {
                ModContent.GetInstance<ElementInfoUI>().ShowMyUI();
            }

            base.ModifyHitByProjectile(proj, ref damage, ref crit);
        }
    }
}
