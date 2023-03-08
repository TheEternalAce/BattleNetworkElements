using MMZeroElements.Utilities;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MMZeroElements.SetNPCs
{
    internal class IceNPCs : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            int type = npc.type;
            switch (type)
            {
                case NPCID.DarkCaster:
                case NPCID.IceBat:
                case NPCID.IceSlime:
                case NPCID.SpikedIceSlime:
                case NPCID.IceElemental:
                case NPCID.IceMimic:
                case NPCID.IceTortoise:
                case NPCID.IcyMerman:
                case NPCID.AngryNimbus:
                case NPCID.IceGolem:
                case NPCID.BloodCrawler:
                case NPCID.JungleBat:
                case NPCID.JungleSlime:
                case NPCID.SpikedJungleSlime:
                case NPCID.ManEater:
                case NPCID.Snatcher:
                case NPCID.WallCreeper:
                case NPCID.WallCreeperWall:
                case NPCID.AngryTrapper:
                case NPCID.BlackRecluse:
                case NPCID.BloodFeeder:
                case NPCID.BloodJelly:
                case NPCID.FloatyGross:
                case NPCID.FlyingSnake:
                case NPCID.GiantFlyingFox:
                case NPCID.IchorSticker:
                case NPCID.JungleCreeper:
                case NPCID.Slimeling:
                case NPCID.Slimer:
                case NPCID.ToxicSludge:
                case NPCID.BloodEelHead:
                case NPCID.BloodEelBody:
                case NPCID.BloodEelTail:
                case NPCID.BloodSquid:
                case NPCID.BloodZombie:
                case NPCID.BloodNautilus:
                case NPCID.Drippler:
                case NPCID.GoblinShark:
                case NPCID.EyeballFlyingFish:
                case NPCID.ZombieMerman:
                case NPCID.SandsharkCorrupt:
                case NPCID.SandsharkCrimson:
                case NPCID.CursedSkull:
                case NPCID.GiantCursedSkull:
                case NPCID.Ghost:
                case NPCID.Hornet:
                case NPCID.HornetFatty:
                case NPCID.HornetHoney:
                case NPCID.HornetLeafy:
                case NPCID.HornetSpikey:
                case NPCID.HornetStingy:
                case NPCID.MossHornet:
                case NPCID.BigHornetFatty:
                case NPCID.BigHornetHoney:
                case NPCID.BigHornetLeafy:
                case NPCID.BigHornetSpikey:
                case NPCID.BigHornetStingy:
                case NPCID.BigMossHornet:
                case NPCID.LittleHornetFatty:
                case NPCID.LittleHornetHoney:
                case NPCID.LittleHornetLeafy:
                case NPCID.LittleHornetSpikey:
                case NPCID.LittleHornetStingy:
                case NPCID.LittleMossHornet:
                case NPCID.Bee:
                case NPCID.CorruptSlime:
                case NPCID.Corruptor:
                case NPCID.Crimslime:

                case NPCID.KingSlime:
                case NPCID.EaterofWorldsHead:
                case NPCID.EaterofWorldsBody:
                case NPCID.EaterofWorldsTail:
                case NPCID.BrainofCthulhu:
                case NPCID.Creeper:
                case NPCID.QueenBee:
                case NPCID.Deerclops:
                case NPCID.DeerclopsLeg:
                case NPCID.QueenSlimeBoss:
                case NPCID.QueenSlimeMinionBlue:
                case NPCID.QueenSlimeMinionPink:
                case NPCID.QueenSlimeMinionPurple:
                case NPCID.PrimeVice:
                case NPCID.Plantera:
                case NPCID.PlanterasHook:
                case NPCID.PlanterasTentacle:
                case NPCID.DukeFishron:
                case NPCID.Sharkron:
                case NPCID.Sharkron2:
                    NPCElements.Ice.Add(type);
                    npc.SetElementMultipliersByElement(Element.Ice);
                    break;
            }
        }
    }
}
