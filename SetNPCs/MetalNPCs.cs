using MMZeroElements.Utilities;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MMZeroElements.SetNPCs
{
    internal class MetalNPCs : GlobalNPC
    {
        public override void SetDefaults(NPC npc)
        {
            int type = npc.type;
            switch (type)
            {
                case NPCID.DungeonSpirit:
                case NPCID.ChaosElemental:
                case NPCID.Pixie:
                case NPCID.RaggedCaster:
                case NPCID.RaggedCasterOpenCoat:
                case NPCID.AngryBones:
                case NPCID.AnomuraFungus:
                case NPCID.Antlion:
                case NPCID.WalkingAntlion:
                case NPCID.GiantWalkingAntlion:
                case NPCID.LarvaeAntlion:
                case NPCID.FlyingAntlion:
                case NPCID.GiantFlyingAntlion:
                case NPCID.CochinealBeetle:
                case NPCID.Crab:
                case NPCID.Crawdad:
                case NPCID.Crawdad2:
                case NPCID.CyanBeetle:
                case NPCID.EaterofSouls:
                case NPCID.GiantShelly:
                case NPCID.GiantShelly2:
                case NPCID.GraniteFlyer:
                case NPCID.GraniteGolem:
                case NPCID.GreekSkeleton:
                case NPCID.LacBeetle:
                case NPCID.SeaSnail:
                case NPCID.Skeleton:
                case NPCID.SpikeBall:
                case NPCID.SporeSkeleton:
                case NPCID.UndeadMiner:
                case NPCID.UndeadViking:
                case NPCID.ArmoredSkeleton:
                case NPCID.ArmoredViking:
                case NPCID.BlueArmoredBones:
                case NPCID.BlueArmoredBonesMace:
                case NPCID.BlueArmoredBonesNoPants:
                case NPCID.BlueArmoredBonesSword:
                case NPCID.BoneLee:
                case NPCID.MartianProbe:
                case NPCID.Mimic:
                case NPCID.PresentMimic:
                case NPCID.Paladin:
                case NPCID.PossessedArmor:
                case NPCID.RockGolem:
                case NPCID.RustyArmoredBonesAxe:
                case NPCID.RustyArmoredBonesFlail:
                case NPCID.RustyArmoredBonesSword:
                case NPCID.RustyArmoredBonesSwordNoArmor:
                case NPCID.SkeletonArcher:
                case NPCID.SkeletonCommando:
                case NPCID.SkeletonSniper:
                case NPCID.TacticalSkeleton:
                case NPCID.SandsharkHallow:
                case NPCID.GoblinThief:
                case NPCID.GoblinWarrior:
                case NPCID.BigMimicCorruption:
                case NPCID.BigMimicCrimson:
                case NPCID.BigMimicJungle:
                case NPCID.CrimsonAxe:
                case NPCID.CursedHammer:
                case NPCID.EnchantedSword:
                case NPCID.BigMimicHallow:

                case NPCID.PrimeSaw:
                case NPCID.TheDestroyer:
                case NPCID.TheDestroyerBody:
                case NPCID.TheDestroyerTail:
                    NPCElements.Metal.Add(type);
                    npc.SetElementMultipliersByElement(Element.Metal);
                    break;
            }
        }
    }
}
