using MMZeroElements.Elements;
using MMZeroElements.Utilities;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MMZeroElements.SetElements.NPCs
{
    internal class IceAquaNPCs : GlobalNPC
    {
        static int[] npcs =
        {
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

            // Boss
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
            NPCElements.IceAqua.AddRange(npcs);
        }

        public override void Unload()
        {
            NPCElements.IceAqua.Clear();
        }

        public override void SetDefaults(NPC npc)
        {
            if (npcs.Contains(npc.type))
            {
                npc.SetElementMultipliersByElement(Element.IceAqua);
            }
        }
    }
}
