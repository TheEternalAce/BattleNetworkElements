using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MMZeroElements.SetNPCs
{
    internal class MetalNPCs : GlobalNPC
    {
        static List<int> MetalEnemies = new()
        {
            NPCID.DungeonSpirit,
            NPCID.ChaosElemental,
            NPCID.Pixie,
            NPCID.RaggedCaster,
            NPCID.RaggedCasterOpenCoat,
            NPCID.AngryBones,
            NPCID.AnomuraFungus,
            NPCID.Antlion,
            NPCID.WalkingAntlion,
            NPCID.GiantWalkingAntlion,
            NPCID.LarvaeAntlion,
            NPCID.FlyingAntlion,
            NPCID.GiantFlyingAntlion,
            NPCID.CochinealBeetle,
            NPCID.Crab,
            NPCID.Crawdad,
            NPCID.Crawdad2,
            NPCID.CyanBeetle,
            NPCID.EaterofSouls,
            NPCID.GiantShelly,
            NPCID.GiantShelly2,
            NPCID.GraniteFlyer,
            NPCID.GraniteGolem,
            NPCID.GreekSkeleton,
            NPCID.LacBeetle,
            NPCID.SeaSnail,
            NPCID.Skeleton,
            NPCID.SpikeBall,
            NPCID.SporeSkeleton,
            NPCID.UndeadMiner,
            NPCID.UndeadViking,
            NPCID.ArmoredSkeleton,
            NPCID.ArmoredViking,
            NPCID.BlueArmoredBones,
            NPCID.BlueArmoredBonesMace,
            NPCID.BlueArmoredBonesNoPants,
            NPCID.BlueArmoredBonesSword,
            NPCID.BoneLee,
            NPCID.MartianProbe,
            NPCID.Mimic,
            NPCID.PresentMimic,
            NPCID.Paladin,
            NPCID.PossessedArmor,
            NPCID.RockGolem,
            NPCID.RustyArmoredBonesAxe,
            NPCID.RustyArmoredBonesFlail,
            NPCID.RustyArmoredBonesSword,
            NPCID.RustyArmoredBonesSwordNoArmor,
            NPCID.SkeletonArcher,
            NPCID.SkeletonCommando,
            NPCID.SkeletonSniper,
            NPCID.TacticalSkeleton,
            NPCID.SandsharkHallow,
            NPCID.GoblinThief,
            NPCID.GoblinWarrior,
            NPCID.BigMimicCorruption,
            NPCID.BigMimicCrimson,
            NPCID.BigMimicJungle,
            NPCID.CrimsonAxe,
            NPCID.CursedHammer,
            NPCID.EnchantedSword,
            NPCID.BigMimicHallow,

            NPCID.PrimeSaw,
            NPCID.TheDestroyer,
            NPCID.TheDestroyerBody,
            NPCID.TheDestroyerTail,
        };

        public override void Load()
        {
            NPCElements.Metal.AddRange(MetalEnemies);
        }

        public override void Unload()
        {
            NPCElements.Metal.Clear();
        }

        public override void SetDefaults(NPC npc)
        {
            if (NPCElements.Metal.Contains(npc.type))
            {
                npc.SetElementMultipliersByElement(Element.Metal);
            }
        }
    }
}
