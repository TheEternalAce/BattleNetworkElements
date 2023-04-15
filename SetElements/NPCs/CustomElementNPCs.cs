using MMZeroElements.Elements;
using MMZeroElements.Utilities;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MMZeroElements.SetElements.NPCs
{
    internal class CustomElementNPCs : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            int type = npc.type;
            switch (type)
            {
                case NPCID.GreenSlime:
                case NPCID.BlueSlime:
                case NPCID.SlimeSpiked:
                case NPCID.RedSlime:
                case NPCID.PurpleSlime:
                case NPCID.YellowSlime:
                case NPCID.BlackSlime:
                case NPCID.MotherSlime:
                case NPCID.BabySlime:
                case NPCID.KingSlime:
                    NPCElements.IceAqua.Add(type);
                    npc.SetElementMultiplier(2.0f, 0.8f, 0.5f, 1.0f);
                    break;

                case NPCID.CultistBoss:
                case NPCID.CultistArcherBlue:
                case NPCID.CultistArcherWhite:
                case NPCID.CultistDevote:
                case NPCID.CultistBossClone:
                case NPCID.CultistDragonHead:
                case NPCID.CultistDragonBody1:
                case NPCID.CultistDragonBody2:
                case NPCID.CultistDragonBody3:
                case NPCID.CultistDragonTail:
                case NPCID.CultistTablet:
                case NPCID.AncientCultistSquidhead:
                case NPCID.AncientDoom:
                case NPCID.AncientLight:
                case NPCID.MoonLordCore:
                case NPCID.MoonLordFreeEye:
                case NPCID.MoonLordHand:
                case NPCID.MoonLordHead:
                case NPCID.MoonLordLeechBlob:
                    NPCElements.Fire.Add(type);
                    NPCElements.IceAqua.Add(type);
                    NPCElements.Electric.Add(type);
                    npc.SetElementMultiplier(0.8f, 0.8f, 0.8f, 0.8f);
                    break;
            }
        }
    }
}
