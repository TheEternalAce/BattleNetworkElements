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

        public static void AddIce(this NPC npc)
        {
            npc.type.AddIceNPC();
        }
        public static void AddIceNPC(this int npcType)
        {
            NPCElements.Ice.Add(npcType);
        }

        public static void AddElectric(this NPC npc)
        {
            npc.type.AddElectricNPC();
        }
        public static void AddElectricNPC(this int npcType)
        {
            NPCElements.Electric.Add(npcType);
        }
    }
}
