using BattleNetworkElements.Elements;
using BattleNetworkElements.Utilities;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BattleNetworkElements.SetElements.NPCs
{
    internal class AquaNPCs : GlobalNPC
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
            NPCID.PrimeVice,
            NPCID.DukeFishron,
            NPCID.DetonatingBubble,
            NPCID.Sharkron,
            NPCID.Sharkron2,
        };

        public override void Load()
        {
            BNGlobalNPC.Aqua.AddRange(npcs);
        }

        public override void Unload()
        {
            BNGlobalNPC.Aqua.Clear();
        }

        public override void SetDefaults(NPC npc)
        {
            if (npcs.Contains(npc.type))
            {
                npc.ElementMultipliers() = Element.AquaMultipliers;
            }
        }
    }
}
