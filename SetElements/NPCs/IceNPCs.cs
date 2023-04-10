using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MMZeroElements.SetElements.NPCs
{
    internal class IceNPCs : GlobalNPC
    {
        static List<int> npcs = new()
        {
            NPCID.GreenSlime,
            NPCID.SlimeSpiked,
            NPCID.BlueSlime,
            NPCID.RedSlime,
            NPCID.PurpleSlime,
            NPCID.YellowSlime,
            NPCID.BlackSlime,
            NPCID.MotherSlime,
            NPCID.BabySlime,
            NPCID.DarkCaster,
            NPCID.ChaosBall,
            NPCID.IceBat,
            NPCID.IceSlime,
            NPCID.SpikedIceSlime,
            NPCID.IceElemental,
            NPCID.IceMimic,
            NPCID.IceTortoise,
            NPCID.IcyMerman,
            NPCID.AngryNimbus,
            NPCID.IceGolem,
            NPCID.BloodEelHead,
            NPCID.BloodEelBody,
            NPCID.BloodEelTail,
            NPCID.BloodSquid,
            NPCID.BloodZombie,
            NPCID.BloodNautilus,
            NPCID.Drippler,
            NPCID.GoblinShark,
            NPCID.EyeballFlyingFish,
            NPCID.ZombieMerman,
            NPCID.CursedSkull,
            NPCID.GiantCursedSkull,
            NPCID.Ghost,

            // Crimson
            NPCID.BloodCrawler,
            NPCID.BloodFeeder,
            NPCID.BloodJelly,
            NPCID.FloatyGross,
            NPCID.IchorSticker,
            NPCID.SandsharkCrimson,
            NPCID.Crimslime,

            NPCID.KingSlime,
            NPCID.BrainofCthulhu,
            NPCID.Creeper,
            NPCID.Deerclops,
            NPCID.QueenSlimeBoss,
            NPCID.QueenSlimeMinionBlue,
            NPCID.QueenSlimeMinionPink,
            NPCID.QueenSlimeMinionPurple,
            NPCID.PrimeVice,
            NPCID.DukeFishron,
            NPCID.DetonatingBubble,
            NPCID.Sharkron,
            NPCID.Sharkron2,
        };

        public override void Load()
        {
            NPCElements.Ice.AddRange(npcs);
        }

        public override void Unload()
        {
            NPCElements.Ice.Clear();
        }

        public override void SetDefaults(NPC npc)
        {
            foreach (int type in npcs)
            {
                if (npc.type == type)
                {
                    npc.SetElementMultipliersByElement(Element.Ice);
                }
            }
        }
    }
}
