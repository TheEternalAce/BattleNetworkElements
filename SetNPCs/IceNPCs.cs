using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MMZeroElements.SetNPCs
{
    internal class IceNPCs : GlobalNPC
    {
        static List<int> IceEnemies = new()
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
            NPCID.IceBat,
            NPCID.IceSlime,
            NPCID.SpikedIceSlime,
            NPCID.IceElemental,
            NPCID.IceMimic,
            NPCID.IceTortoise,
            NPCID.IcyMerman,
            NPCID.AngryNimbus,
            NPCID.IceGolem,
            NPCID.BloodCrawler,
            NPCID.JungleBat,
            NPCID.JungleSlime,
            NPCID.SpikedJungleSlime,
            NPCID.ManEater,
            NPCID.Snatcher,
            NPCID.WallCreeper,
            NPCID.WallCreeperWall,
            NPCID.AngryTrapper,
            NPCID.BlackRecluse,
            NPCID.BloodFeeder,
            NPCID.BloodJelly,
            NPCID.FloatyGross,
            NPCID.FlyingSnake,
            NPCID.GiantFlyingFox,
            NPCID.IchorSticker,
            NPCID.JungleCreeper,
            NPCID.Slimeling,
            NPCID.Slimer,
            NPCID.ToxicSludge,
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
            NPCID.SandsharkCorrupt,
            NPCID.SandsharkCrimson,
            NPCID.CursedSkull,
            NPCID.GiantCursedSkull,
            NPCID.Ghost,
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
            NPCID.CorruptSlime,
            NPCID.Corruptor,
            NPCID.Crimslime,

            NPCID.KingSlime,
            NPCID.EaterofWorldsHead,
            NPCID.EaterofWorldsBody,
            NPCID.EaterofWorldsTail,
            NPCID.BrainofCthulhu,
            NPCID.Creeper,
            NPCID.QueenBee,
            NPCID.Deerclops,
            NPCID.DeerclopsLeg,
            NPCID.QueenSlimeBoss,
            NPCID.QueenSlimeMinionBlue,
            NPCID.QueenSlimeMinionPink,
            NPCID.QueenSlimeMinionPurple,
            NPCID.PrimeVice,
            NPCID.Plantera,
            NPCID.PlanterasHook,
            NPCID.PlanterasTentacle,
            NPCID.DukeFishron,
            NPCID.Sharkron,
            NPCID.Sharkron2,
        };

        public override void Load()
        {
            NPCElements.Ice.AddRange(IceEnemies);
        }

        public override void Unload()
        {
            NPCElements.Ice.Clear();
        }

        public override void SetDefaults(NPC npc)
        {
            if (NPCElements.Ice.Contains(npc.type))
            {
                npc.SetElementMultipliersByElement(Element.Ice);
            }
        }
    }
}
