using Microsoft.Xna.Framework;
using Terraria;

namespace MMZeroElements.Utilities
{
    public static class ElementHelper
    {
        public static float MultiplyDamage(object offender, object victim)
        {
            float multiplier = 1.0f;
            float[] victimElements = { 1f, 1f, 1f, 1f };
            Rectangle victimRect = new();
            if (victim is Player player)
            {
                victimElements = player.Elements().elementMultipliers;
                victimRect = player.getRect();
            }
            else if (victim is NPC npc)
            {
                victimElements = npc.Elements().elementMultipliers;
                victimRect = npc.getRect();
            }

            if (offender is Item item)
            {
                multiplier = MultiplyElements(item, victimElements);
            }
            else if (offender is Projectile proj)
            {
                multiplier = MultiplyElements(proj, victimElements);
            }
            else if (offender is NPC npc)
            {
                multiplier = MultiplyElements(npc, victimElements);
            }

            if (multiplier != 1f)
            {
                int ct = CombatText.NewText(victimRect, Color.Blue, multiplier + "x");
                Main.combatText[ct].position.Y -= 45;
            }

            return multiplier;
        }

        static float MultiplyElements(NPC npc, float[] victimElements)
        {
            float multiplier = 1f;
            if (npc.IsFire())
            {
                multiplier *= victimElements[Element.Fire];
            }
            if (npc.IsIce())
            {
                multiplier *= victimElements[Element.IceAqua];
            }
            if (npc.IsElec())
            {
                multiplier *= victimElements[Element.Elec];
            }
            if (npc.IsWood())
            {
                multiplier *= victimElements[Element.Wood];
            }
            return multiplier;
        }

        static float MultiplyElements(Item item, float[] victimElements)
        {
            float multiplier = 1f;
            if (item.IsFire())
            {
                multiplier *= victimElements[Element.Fire];
            }
            if (item.IsIce())
            {
                multiplier *= victimElements[Element.IceAqua];
            }
            if (item.IsElec())
            {
                multiplier *= victimElements[Element.Elec];
            }
            if (item.IsWood())
            {
                multiplier *= victimElements[Element.Wood];
            }
            return multiplier;
        }

        static float MultiplyElements(Projectile proj, float[] victimElements)
        {
            float multiplier = 1f;
            if (proj.IsFire())
            {
                multiplier *= victimElements[Element.Fire];
            }
            if (proj.IsIceAqua())
            {
                multiplier *= victimElements[Element.IceAqua];
            }
            if (proj.IsElec())
            {
                multiplier *= victimElements[Element.Elec];
            }
            if (proj.IsWood())
            {
                multiplier *= victimElements[Element.Wood];
            }
            return multiplier;
        }
    }
}
