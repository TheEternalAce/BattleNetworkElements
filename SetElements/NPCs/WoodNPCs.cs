using MMZeroElements.Elements;
using MMZeroElements.Utilities;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MMZeroElements.SetElements.NPCs
{
    internal class WoodNPCs : GlobalNPC
    {
        internal static int[] poison =
        {
            // Poison
            NPCID.JungleBat,
            NPCID.JungleSlime,
            NPCID.SpikedJungleSlime,
            NPCID.ManEater,
            NPCID.Snatcher,
            NPCID.WallCreeper,
            NPCID.WallCreeperWall,
            NPCID.AngryTrapper,
            NPCID.BlackRecluse,
            NPCID.FlyingSnake,
            NPCID.GiantFlyingFox,
            NPCID.JungleCreeper,
            NPCID.ToxicSludge,
            NPCID.Hornet,
            NPCID.HornetFatty,
            NPCID.HornetHoney,
            NPCID.HornetLeafy,
            NPCID.HornetSpikey,
            NPCID.HornetStingy,
            NPCID.MossHornet,
            NPCID.BigHornetFatty,
            NPCID.BigHornetHoney,
            NPCID.BigHornetLeafy,
            NPCID.BigHornetSpikey,
            NPCID.BigHornetStingy,
            NPCID.BigMossHornet,
            NPCID.LittleHornetFatty,
            NPCID.LittleHornetHoney,
            NPCID.LittleHornetLeafy,
            NPCID.LittleHornetSpikey,
            NPCID.LittleHornetStingy,
            NPCID.LittleMossHornet,
            NPCID.Bee,

            NPCID.QueenBee,
            NPCID.Plantera,
            NPCID.PlanterasHook,
            NPCID.PlanterasTentacle,
        };

        public override void Load()
        {
            NPCElements.Wood.AddRange(poison);
        }

        public override void Unload()
        {
            NPCElements.Wood.Clear();
        }

        public override void SetDefaults(NPC npc)
        {
            if (poison.Contains(npc.type))
            {
                npc.SetElementMultipliersByElement(Element.Wood);
            }
        }
    }
}
