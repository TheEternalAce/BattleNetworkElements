using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MMZeroElements.SetElements.NPCs
{
    internal class FireNPCs : GlobalNPC
    {
        static List<int> npcs = new()
        {
            NPCID.BlazingWheel,
            NPCID.BoneSerpentHead,
            NPCID.BoneSerpentBody,
            NPCID.BoneSerpentTail,
            NPCID.Demon,
            NPCID.DiabolistRed,
            NPCID.DiabolistWhite,
            NPCID.FireImp,
            NPCID.Hellbat,
            NPCID.HoppinJack,
            NPCID.Lavabat,
            NPCID.LavaSlime,
            NPCID.Necromancer,
            NPCID.NecromancerArmored,
            NPCID.RedDevil,
            NPCID.DemonTaxCollector,
            NPCID.VoodooDemon,
            NPCID.MeteorHead,
            NPCID.Tim,
            NPCID.ChaosBall,
            NPCID.ChaosBallTim,
            NPCID.HellArmoredBones,
            NPCID.HellArmoredBonesMace,
            NPCID.HellArmoredBonesSpikeShield,
            NPCID.HellArmoredBonesSword,
            NPCID.RuneWizard,
            NPCID.GoblinSummoner,
            NPCID.ShadowFlameApparition,

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

            // Corruption
            NPCID.Slimeling,
            NPCID.Slimer,
            NPCID.SandsharkCorrupt,
            NPCID.CorruptSlime,
            NPCID.Corruptor,
            NPCID.Clinger,
            NPCID.EaterofSouls,

            // Boss
            NPCID.EaterofWorldsHead,
            NPCID.EaterofWorldsBody,
            NPCID.EaterofWorldsTail,
            NPCID.QueenBee,
            NPCID.WallofFlesh,
            NPCID.WallofFleshEye,
            NPCID.PrimeCannon,
            NPCID.SkeletronPrime,
            NPCID.Spazmatism,
            NPCID.Plantera,
            NPCID.PlanterasHook,
            NPCID.PlanterasTentacle,
            NPCID.Golem,
            NPCID.GolemFistLeft,
            NPCID.GolemFistRight,
            NPCID.GolemHead,
            NPCID.GolemHeadFree,
        };

        public override void Load()
        {
            NPCElements.Fire.AddRange(npcs);
        }

        public override void Unload()
        {
            NPCElements.Fire.Clear();
        }

        public override void SetDefaults(NPC npc)
        {
            foreach (int type in npcs)
            {
                if (npc.type == type)
                {
                    npc.SetElementMultipliersByElement(Element.Fire);
                }
            }
        }
    }
}
