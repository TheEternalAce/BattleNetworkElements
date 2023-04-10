using MMZeroElements.Utilities;
using Terraria.ID;
using Terraria.ModLoader;

namespace MMZeroElements.ElementUI.Icons
{
    public class FireIcon : ModItem
    {
        public override void SetStaticDefaults()
        {
            Item.AddFire();
            SacrificeTotal = 0;
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.rare = ItemRarityID.Red;
        }
    }
}
