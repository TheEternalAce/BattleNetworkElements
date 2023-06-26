using BattleNetworkElements.Elements;
using Terraria;

namespace BattleNetworkElements.Utilities
{
    public static class ElementNPCHelper
    {
        public static void AddFire(this NPC npc)
        {
            npc.type.AddFireNPC();
        }
        public static void AddFireNPC(this int npcType)
        {
            BNGlobalNPC.Fire.Add(npcType);
        }
        public static bool IsFire(this NPC npc)
        {
            return npc.type.NPCIsFire();
        }
        public static bool NPCIsFire(this int npcType)
        {
            return BNGlobalNPC.Fire.Contains(npcType);
        }

        public static void AddAqua(this NPC npc)
        {
            npc.type.AddAquaNPC();
        }
        public static void AddAquaNPC(this int npcType)
        {
            BNGlobalNPC.Aqua.Add(npcType);
        }
        public static bool IsAqua(this NPC npc)
        {
            return npc.type.NPCIsAqua();
        }
        public static bool NPCIsAqua(this int npcType)
        {
            return BNGlobalNPC.Aqua.Contains(npcType);
        }

        public static void AddElec(this NPC npc)
        {
            npc.type.AddElecNPC();
        }
        public static void AddElecNPC(this int npcType)
        {
            BNGlobalNPC.Electric.Add(npcType);
        }
        public static bool IsElec(this NPC npc)
        {
            return npc.type.NPCIsElec();
        }
        public static bool NPCIsElec(this int npcType)
        {
            return BNGlobalNPC.Electric.Contains(npcType);
        }

        public static void AddWood(this NPC npc)
        {
            npc.type.AddWoodNPC();
        }
        public static void AddWoodNPC(this int npcType)
        {
            BNGlobalNPC.Wood.Add(npcType);
        }
        public static bool IsWood(this NPC npc)
        {
            return npc.type.NPCIsWood();
        }
        public static bool NPCIsWood(this int npcType)
        {
            return BNGlobalNPC.Wood.Contains(npcType);
        }

        /// <summary>
        /// Sets NPC multipliers based on given Element
        /// <para>0 = Fire, 1 = Aqua, 2 = Electric, 3 = Wood</para>
        /// <para>This method should be called in the SetDefaults() override</para>
        /// </summary>
        public static void SetElementMultipliersByElement(this NPC npc, int element)
        {
            float[] multipliers = new[] { 1f, 1f, 1f, 1f };
            switch (element)
            {
                case Element.Fire:
                    multipliers = new[] { 0.8f, 2.0f, 1.0f, 0.5f };
                    break;
                case Element.Aqua:
                    multipliers = new[] { 0.5f, 0.8f, 2.0f, 1.0f };
                    break;
                case Element.Elec:
                    multipliers = new[] { 1.0f, 0.5f, 0.8f, 2.0f };
                    break;
                case Element.Wood:
                    multipliers = new[] { 2.0f, 1.0f, 0.5f, 0.8f };
                    break;
            }
            npc.ElementMultipliers() = multipliers;
        }

        public static ref float[] ElementMultipliers(this NPC npc)
        {
            return ref npc.Elements().elementMultipliers;
        }
        public static ref float FireMultiplier(this NPC npc)
        {
            return ref npc.Elements().elementMultipliers[Element.Fire];
        }
        public static ref float AquaMultiplier(this NPC npc)
        {
            return ref npc.Elements().elementMultipliers[Element.Aqua];
        }
        public static ref float ElecMultiplier(this NPC npc)
        {
            return ref npc.Elements().elementMultipliers[Element.Elec];
        }
        public static ref float WoodMultiplier(this NPC npc)
        {
            return ref npc.Elements().elementMultipliers[Element.Wood];
        }

        public static BNGlobalNPC Elements(this NPC npc)
        {
            return npc.GetGlobalNPC<BNGlobalNPC>();
        }
    }
}
