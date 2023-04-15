using MMZeroElements.Utilities;
using Terraria.ID;
using Terraria.ModLoader;

namespace MMZeroElements.ElementUI.Icons
{
    public class DamageIcon : ModItem
    {
        public override void SetStaticDefaults()
        {
            Item.AddFire();
            Item.AddIce();
            Item.AddElec();
            Item.AddWood();
            Item.ResearchUnlockCount = 0;
        }

        public override void SetDefaults()
        {
            Item.width = 26;
            Item.height = 26;
            Item.rare = ItemRarityID.Expert;
        }
    }
}
