using Terraria.ID;
using Terraria.ModLoader;

namespace BattleNetworkElements.ElementUI.Icons
{
    public class NullIcon : ModItem
    {
        public override void SetStaticDefaults()
        {
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
