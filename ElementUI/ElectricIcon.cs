using MMZeroElements.Utilities;
using Terraria.ID;
using Terraria.ModLoader;

namespace MMZeroElements.ElementUI
{
    public class ElectricIcon : ModItem
    {
        public override void SetStaticDefaults()
        {
            Item.AddFire();
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.rare = ItemRarityID.Cyan;
        }
    }
}
