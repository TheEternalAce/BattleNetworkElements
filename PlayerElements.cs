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

        public override void OnHitNPCWithItem(Item item, NPC target, NPC.HitInfo hit, int damageDone)
        {
            targetedNPC = target;
            latestItem = item;
            latestProj = null;
            ModContent.GetInstance<ElementInfoUI>().ShowMyUI();
        }

        public override void OnHitNPCWithProj(Projectile proj, NPC target, NPC.HitInfo hit, int damageDone)
        {
            targetedNPC = target;
            latestItem = null;
            latestProj = proj;
            ModContent.GetInstance<ElementInfoUI>().ShowMyUI();
        }

        public override void ModifyHitByNPC(NPC npc, ref Player.HurtModifiers modifiers)
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
            modifiers.FinalDamage *= multiplier;
            targetedNPC = npc;

            base.ModifyHitByNPC(npc, ref modifiers);
        }

        public override void ModifyHitByProjectile(Projectile proj, ref Player.HurtModifiers modifiers)
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
            modifiers.FinalDamage *= multiplier;

            base.ModifyHitByProjectile(proj, ref modifiers);
        }
    }
}
