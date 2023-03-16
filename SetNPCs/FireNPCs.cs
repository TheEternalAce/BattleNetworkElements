using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MMZeroElements.SetNPCs
{
    internal class FireNPCs : GlobalNPC
    {
        static List<int> FireEnemies = new()
        {
            NPCID.BlazingWheel,
            NPCID.BoneSerpentHead,
            NPCID.BoneSerpentBody,
            NPCID.BoneSerpentTail,
            NPCID.Clinger,
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

            NPCID.WallofFlesh,
            NPCID.WallofFleshEye,
            NPCID.PrimeCannon,
            NPCID.SkeletronPrime,
            NPCID.Spazmatism,
            NPCID.Golem,
            NPCID.GolemFistLeft,
            NPCID.GolemFistRight,
            NPCID.GolemHead,
            NPCID.GolemHeadFree,
        };

        public override void Load()
        {
            NPCElements.Fire.AddRange(FireEnemies);
        }

        public override void Unload()
        {
            NPCElements.Fire.Clear();
        }

        public override void SetDefaults(NPC npc)
        {
            if (NPCElements.Fire.Contains(npc.type))
            {
                npc.SetElementMultipliersByElement(Element.Fire);
            }
        }
    }
}
