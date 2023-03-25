﻿using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MMZeroElements.SetElements.NPCs
{
    internal class ElectricNPCs : GlobalNPC
    {
        static List<int> npcs = new()
        {
            NPCID.BlueJellyfish,
            NPCID.Harpy,
            NPCID.PinkJellyfish,
            NPCID.GreenJellyfish,
            NPCID.WyvernHead,
            NPCID.WyvernBody,
            NPCID.WyvernLegs,
            NPCID.WyvernBody2,
            NPCID.WyvernBody3,
            NPCID.WyvernTail,
            NPCID.Tumbleweed,
            NPCID.SandShark,
            NPCID.SandElemental,
            NPCID.DesertLamiaDark,
            NPCID.DesertLamiaLight,
            NPCID.DesertScorpionWalk,
            NPCID.DesertScorpionWall,
            NPCID.DesertGhoul,
            NPCID.DesertGhoulCorruption,
            NPCID.DesertGhoulCrimson,
            NPCID.DesertGhoulHallow,

            NPCID.EyeofCthulhu,
            NPCID.SkeletronHead,
            NPCID.SkeletronHand,
            NPCID.PrimeLaser,
            NPCID.HallowBoss,
        };

        public override void Load()
        {
            NPCElements.Electric.AddRange(npcs);
        }

        public override void Unload()
        {
            NPCElements.Electric.Clear();
        }

        public override void SetDefaults(NPC npc)
        {
            foreach (int type in npcs)
            {
                if (npc.type == type)
                {
                    npc.SetElementMultipliersByElement(Element.Electric);
                }
            }
        }
    }
}