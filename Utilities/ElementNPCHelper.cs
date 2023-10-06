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
