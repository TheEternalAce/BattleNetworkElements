using MMZeroElements.Utilities;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MMZeroElements.SetNPCs
{
    internal class FireNPCs : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            int type = npc.type;
            switch (type)
            {
                case NPCID.BlazingWheel:
                case NPCID.BoneSerpentHead:
                case NPCID.BoneSerpentBody:
                case NPCID.BoneSerpentTail:
                case NPCID.Clinger:
                case NPCID.Demon:
                case NPCID.DiabolistRed:
                case NPCID.DiabolistWhite:
                case NPCID.FireImp:
                case NPCID.Hellbat:
                case NPCID.HoppinJack:
                case NPCID.Lavabat:
                case NPCID.LavaSlime:
                case NPCID.Necromancer:
                case NPCID.NecromancerArmored:
                case NPCID.RedDevil:
                case NPCID.DemonTaxCollector:
                case NPCID.VoodooDemon:

                case NPCID.MeteorHead:
                case NPCID.Tim:
                case NPCID.ChaosBall:
                case NPCID.ChaosBallTim:
                case NPCID.HellArmoredBones:
                case NPCID.HellArmoredBonesMace:
                case NPCID.HellArmoredBonesSpikeShield:
                case NPCID.HellArmoredBonesSword:
                case NPCID.RuneWizard:
                case NPCID.GoblinSummoner:
                case NPCID.ShadowFlameApparition:

                case NPCID.WallofFlesh:
                case NPCID.WallofFleshEye:
                case NPCID.PrimeCannon:
                case NPCID.SkeletronPrime:
                case NPCID.Spazmatism:
                case NPCID.Golem:
                case NPCID.GolemFistLeft:
                case NPCID.GolemFistRight:
                case NPCID.GolemHead:
                case NPCID.GolemHeadFree:
                    NPCElements.Fire.Add(type);
                    npc.SetElementMultipliersByElement(Element.Fire);
                    break;
            }
        }
    }
}
