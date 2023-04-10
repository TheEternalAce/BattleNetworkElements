﻿using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace MMZeroElements.Config
{
    [Label("UI Config")]
    public class ElementsClient : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;

        [Label("Element UI Display")]
        [Tooltip("When should the elements info ui be displayed.\n" +
            "After hit: Displays elements after hitting an enemy or being hit.\n" +
            "Always: Always display elements.\n" +
            "Inventory open only: Displays elements only when the inventory is open.\n" +
            "Never: Never displays elements.")]
        [DrawTicks]
        [OptionStrings(new string[] { "After hit", "Always", "Inventory open only", "Never" })]
        [DefaultValue("After hit")]
        public string elementUIDisplayStyle;
    }
}