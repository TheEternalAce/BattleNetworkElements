using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MMZeroElements.SetElements.NPCs
{
    internal class CustomElementNPCs : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            int type = npc.type;
            switch (type)
            {
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
                    NPCElements.Fire.Add(type);
                    NPCElements.Metal.Add(type);
                    npc.SetCustomElementMultipliers(0.8f, 1.5f, 1.0f, 0.6f);
                    break;

                case NPCID.CultistBoss:
                case NPCID.CultistArcherBlue:
                case NPCID.CultistArcherWhite:
                case NPCID.CultistDevote:
                case NPCID.CultistBossClone:
                case NPCID.CultistDragonHead:
                case NPCID.CultistDragonBody1:
                case NPCID.CultistDragonBody2:
                case NPCID.CultistDragonBody3:
                case NPCID.CultistDragonTail:
                case NPCID.CultistTablet:
                case NPCID.AncientCultistSquidhead:
                case NPCID.AncientDoom:
                case NPCID.AncientLight:
                case NPCID.MoonLordCore:
                case NPCID.MoonLordFreeEye:
                case NPCID.MoonLordHand:
                case NPCID.MoonLordHead:
                case NPCID.MoonLordLeechBlob:
                    NPCElements.Fire.Add(type);
                    NPCElements.Ice.Add(type);
                    NPCElements.Electric.Add(type);
                    NPCElements.Metal.Add(type);
                    npc.SetCustomElementMultipliers(1, 1, 1, 1);
                    break;
            }
        }
    }
}
