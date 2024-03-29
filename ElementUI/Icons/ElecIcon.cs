﻿using BattleNetworkElements.Utilities;
using Terraria.ID;
using Terraria.ModLoader;

namespace BattleNetworkElements.ElementUI.Icons
{
    public class ElecIcon : ModItem
    {
        public override void SetStaticDefaults()
        {
            Item.AddElec();
            Item.ResearchUnlockCount = 0;
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.rare = ItemRarityID.Cyan;
        }
    }
}
