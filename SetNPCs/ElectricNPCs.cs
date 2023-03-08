using MMZeroElements.Utilities;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MMZeroElements.SetNPCs
{
    internal class ElectricNPCs : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            int type = npc.type;
            switch (type)
            {
                case NPCID.BlueJellyfish:
                case NPCID.Harpy:
                case NPCID.PinkJellyfish:
                case NPCID.GreenJellyfish:
                case NPCID.WyvernHead:
                case NPCID.WyvernBody:
                case NPCID.WyvernLegs:
                case NPCID.WyvernBody2:
                case NPCID.WyvernBody3:
                case NPCID.WyvernTail:
                case NPCID.Tumbleweed:
                case NPCID.SandShark:
                case NPCID.SandElemental:
                case NPCID.DesertLamiaDark:
                case NPCID.DesertLamiaLight:
                case NPCID.DesertScorpionWalk:
                case NPCID.DesertScorpionWall:
                case NPCID.DesertGhoul:
                case NPCID.DesertGhoulCorruption:
                case NPCID.DesertGhoulCrimson:
                case NPCID.DesertGhoulHallow:

                case NPCID.EyeofCthulhu:
                case NPCID.SkeletronHead:
                case NPCID.SkeletronHand:
                case NPCID.PrimeLaser:
                case NPCID.HallowBoss:
                    NPCElements.Electric.Add(type);
                    npc.SetElementMultipliersByElement(Element.Electric);
                    break;
            }
        }
    }
}
