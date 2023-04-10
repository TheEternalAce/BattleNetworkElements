using System;
using Terraria;

namespace MMZeroElements
{
    public static class ElementSystem
    {
        /// <summary>
        /// Sets NPC multipliers in the following order: Fire, Ice, Electric, Metal
        /// <para>This method should be called in the SetDefaults() override</para>
        /// </summary>
        public static void SetCustomElementMultipliers(this NPC npc, params float[] multipliers)
        {
            if (multipliers.Length > 4)
            {
                throw new ArgumentException("Too many arguments, please use only four (4) decimal values");
            }
            else if (multipliers.Length < 4)
            {
                throw new ArgumentException("Too few arguments, please provide only four (4) decimal values");
            }
            for (int i = 0; i < multipliers.Length; i++)
            {
                npc.GetGlobalNPC<NPCElements>().elementMultipliers[i] = multipliers[i];
            }
        }

        /// <summary>
        /// Sets NPC multipliers based on given Element
        /// <para>0 = Fire, 1 = Ice, 2 = Electric, 3 = Metal</para>
        /// <para>This method should be called in the SetDefaults() override</para>
        /// </summary>
        public static void SetElementMultipliersByElement(this NPC npc, int element)
        {
            switch (element)
            {
                case Element.Fire:
                    npc.SetElementMultiplier(Element.Fire, 0.8f);
                    npc.SetElementMultiplier(Element.Ice, 0.5f);
                    npc.SetElementMultiplier(Element.Electric, 2.0f);
                    break;
                case Element.Ice:
                    npc.SetElementMultiplier(Element.Fire, 2.0f);
                    npc.SetElementMultiplier(Element.Ice, 0.8f);
                    npc.SetElementMultiplier(Element.Electric, 0.5f);
                    break;
                case Element.Electric:
                    npc.SetElementMultiplier(Element.Fire, 0.5f);
                    npc.SetElementMultiplier(Element.Electric, 0.8f);
                    npc.SetElementMultiplier(Element.Ice, 2.0f);
                    break;
            }
        }

        public static void SetElementMultiplier(this NPC npc, int element, float multiplier)
        {
            npc.GetGlobalNPC<NPCElements>().elementMultipliers[element] = multiplier;
        }

        public static void SetElementMultiplier(this NPC npc, float[] multipliers)
        {
            npc.GetGlobalNPC<NPCElements>().elementMultipliers = multipliers;
        }
    }

    public static class Element
    {
        public const int Null = -1;
        public const int Fire = 0;
        public const int Ice = 1; // /Aqua
        public const int Electric = 2;
        public const int Wood = 3;
    }
}
