using MMZeroElements.Elements;
using Terraria;

namespace MMZeroElements.Utilities
{
    public static class ElementNPCHelper
    {
        public static void AddFire(this NPC npc)
        {
            npc.type.AddFireNPC();
        }
        public static void AddFireNPC(this int npcType)
        {
            NPCElements.Fire.Add(npcType);
        }
        public static bool IsFire(this NPC npc)
        {
            return npc.type.NPCIsFire();
        }
        public static bool NPCIsFire(this int npcType)
        {
            return NPCElements.Fire.Contains(npcType);
        }

        public static void AddIce(this NPC npc)
        {
            npc.type.AddIceNPC();
        }
        public static void AddIceNPC(this int npcType)
        {
            NPCElements.IceAqua.Add(npcType);
        }
        public static bool IsIce(this NPC npc)
        {
            return npc.type.NPCIsIce();
        }
        public static bool NPCIsIce(this int npcType)
        {
            return NPCElements.IceAqua.Contains(npcType);
        }

        public static void AddElec(this NPC npc)
        {
            npc.type.AddElecNPC();
        }
        public static void AddElecNPC(this int npcType)
        {
            NPCElements.Electric.Add(npcType);
        }
        public static bool IsElec(this NPC npc)
        {
            return npc.type.NPCIsElec();
        }
        public static bool NPCIsElec(this int npcType)
        {
            return NPCElements.Electric.Contains(npcType);
        }

        public static void AddWood(this NPC npc)
        {
            npc.type.AddWoodNPC();
        }
        public static void AddWoodNPC(this int npcType)
        {
            NPCElements.Wood.Add(npcType);
        }
        public static bool IsWood(this NPC npc)
        {
            return npc.type.NPCIsWood();
        }
        public static bool NPCIsWood(this int npcType)
        {
            return NPCElements.Wood.Contains(npcType);
        }

        /// <summary>
        /// Sets NPC multipliers based on given Element
        /// <para>0 = Fire, 1 = Ice/Aqua, 2 = Electric, 3 = Wood</para>
        /// <para>This method should be called in the SetDefaults() override</para>
        /// </summary>
        public static void SetElementMultipliersByElement(this NPC npc, int element)
        {
            bool legacy = MMZeroElements.Server.legacySystem;
            switch (element)
            {
                case Element.Fire:
                    npc.SetElementMultiplier(Element.Fire, 0.8f);
                    npc.SetElementMultiplier(Element.IceAqua, 0.5f);
                    npc.SetElementMultiplier(Element.Elec, 2.0f);
                    if (legacy)
                    {
                        npc.SetElementMultiplier(0.8f, 0.5f, 2.0f);
                    }
                    else
                    {
                        npc.SetElementMultiplier(0.8f, 2.0f, 1.0f, 0.5f);
                    }
                    break;
                case Element.IceAqua:
                    if (legacy)
                    {
                        npc.SetElementMultiplier(2.0f, 0.8f, 0.5f);
                    }
                    else
                    {
                        npc.SetElementMultiplier(0.5f, 0.8f, 2.0f, 1.0f);
                    }
                    break;
                case Element.Elec:
                    if (legacy)
                    {
                        npc.SetElementMultiplier(0.5f, 2.0f, 0.8f);
                    }
                    else
                    {
                        npc.SetElementMultiplier(1.0f, 0.5f, 0.8f, 2.0f);
                    }
                    break;
                case Element.Wood:
                    npc.SetElementMultiplier(2.0f, 1.0f, 0.5f, 0.8f);
                    break;
            }
        }

        public static void SetElementMultiplier(this NPC npc, int element, float multiplier)
        {
            npc.GetGlobalNPC<NPCElements>().elementMultipliers[element] = multiplier;
        }

        public static void SetElementMultiplier(this NPC npc, params float[] multipliers)
        {
            for (int i = 0; i < multipliers.Length; i++)
            {
                npc.SetElementMultiplier(i, multipliers[i]);
            }
        }

        public static NPCElements Elements(this NPC npc)
        {
            return npc.GetGlobalNPC<NPCElements>();
        }
    }
}
