﻿using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace MMZeroElements.Config
{
    [BackgroundColor(164, 153, 190)]
    [Label("$Mods.MMZeroElements.Config.ServerLabel")]
    public class ElementsServer : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;

        [Label("$Mods.MMZeroElements.Config.LegacySystem")]
        [Tooltip("$Mods.MMZeroElements.ConfigDesc.LegacySystem")]
        [DefaultValue(false)]
        [ReloadRequired]
        public bool legacySystem;
    }
}
