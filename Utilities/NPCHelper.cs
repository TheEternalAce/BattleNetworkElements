using Terraria;

namespace MMZeroElements.Utilities
{
    public static class NPCHelper
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
            NPCElements.Ice.Add(npcType);
        }
        public static bool IsIce(this NPC npc)
        {
            return npc.type.NPCIsIce();
        }
        public static bool NPCIsIce(this int npcType)
        {
            return NPCElements.Ice.Contains(npcType);
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
    }
}
