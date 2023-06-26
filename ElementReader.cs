using BattleNetworkElements.Utilities;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BattleNetworkElements
{
    public class ElementReader : ModItem
    {
        public override void SetStaticDefaults()
        {
            Item.ResearchUnlockCount = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.rare = ItemRarityID.Blue;
            Item.value = 20000;
        }

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            Player player = Main.LocalPlayer;
            float[] playerElements = player.ElementMultipliers();
            string elementInfo = player.name + "'s Elemental Multipliers\n" +
                "[i:BattleNetworkElements/FireIcon] Fire: " + playerElements[Element.Fire] + "\n" +
            "[i:BattleNetworkElements/AquaIcon] Aqua: " + playerElements[Element.Aqua] + "\n" +
            "[i:BattleNetworkElements/ElecIcon] Elec: " + playerElements[Element.Elec] + "\n" +
            "[i:BattleNetworkElements/WoodIcon] Wood: " + playerElements[Element.Wood];
            tooltips.Insert(tooltips.GetIndex("OneDropLogo"), new(Mod, "ElementInfo", elementInfo));
        }
    }
}
