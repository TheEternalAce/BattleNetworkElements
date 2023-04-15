using MMZeroElements.Elements;
using MMZeroElements.Utilities;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MMZeroElements.SetElements.NPCs
{
    internal class FireNPCs : GlobalNPC
    {
        static int[] npcs =
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
            NPCID.Retinazer,
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
            if (npcs.Contains(npc.type))
            {
                npc.SetElementMultipliersByElement(Element.Fire);
            }
        }
    }
}
