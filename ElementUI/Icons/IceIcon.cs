using MMZeroElements.Utilities;
using Terraria.ID;
using Terraria.ModLoader;

namespace MMZeroElements.ElementUI.Icons
{
    public class IceIcon : ModItem
    {
        public override void SetStaticDefaults()
        {
            Item.AddIceDefault();
            Item.ResearchUnlockCount = 0;
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.rare = ItemRarityID.Blue;
        }
    }
}
