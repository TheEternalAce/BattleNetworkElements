using MMZeroElements.Utilities;
using Terraria.ID;
using Terraria.ModLoader;

namespace MMZeroElements.ElementUI.Icons
{
    public class WoodIcon : ModItem
    {
        public override void SetStaticDefaults()
        {
            Item.AddWoodDefault();
            Item.ResearchUnlockCount = 0;
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.rare = ItemRarityID.Green;
        }
    }
}
