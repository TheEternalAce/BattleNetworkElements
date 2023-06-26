using BattleNetworkElements.Utilities;
using Terraria.ID;
using Terraria.ModLoader;

namespace BattleNetworkElements.ElementUI.Icons
{
    public class AquaIcon : ModItem
    {
        public override void SetStaticDefaults()
        {
            Item.AddAqua();
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
