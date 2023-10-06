using BattleNetworkElements.Utilities;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BattleNetworkElements
{
    public class ElementReassigner : ModItem
    {
        public override void SetStaticDefaults()
        {
            Item.ResearchUnlockCount = 30;
        }

        public override void SetDefaults()
        {
            Item.width = 34;
            Item.height = 34;
            Item.maxStack = 9999;
            Item.consumable = true;

            Item.useTime = 15;
            Item.useAnimation = 15;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.UseSound = SoundID.NPCHit53;

            Item.rare = ItemRarityID.Expert;
            Item.value = 20000;
        }

        public override bool? UseItem(Player player)
        {
            var bn = player.Elements();
            int element = -1;
            if (Main.rand.NextBool(3))
            {
                element = 5;
            }
            bn.AssignElements(element);
            return true;
        }
    }
}
