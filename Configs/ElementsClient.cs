using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace BattleNetworkElements.Config
{
    public class ElementsClient : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;

        [DrawTicks]
        [OptionStrings(new string[] { "After hit", "Always", "Inventory open only", "Never" })]
        [DefaultValue("After hit")]
        [ReloadRequired]
        public string elementUIDisplayStyle;

        [Header("PlayerElementHeader")]
        [DefaultValue(true)]
        public bool assignPlayerElement;
        [DefaultValue(true)]
        public bool enablePlayerElement;
        [DefaultValue(true)]
        public bool nullElementIcon;
        [DefaultValue(true)]
        [ReloadRequired]
        public bool flymealWoodElement;

        [Header("OffsetHeader")]
        [Range(-4000, 4000)]
        public int uiOffsetX;
        [Range(-4000, 4000)]
        public int uiOffsetY;
    }
}
