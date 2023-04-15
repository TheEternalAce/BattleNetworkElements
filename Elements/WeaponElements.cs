using Microsoft.Xna.Framework;
using MMZeroElements.Utilities;
using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace MMZeroElements.Elements
{
    public class WeaponElements : GlobalItem
    {
        internal static List<int> Fire = new();
        internal static List<int> Ice = new();
        internal static List<int> Electric = new();
        internal static List<int> Wood = new();

        public override bool InstancePerEntity => true;

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            int type = item.type;
            if (Fire.Contains(type))
            {
                tooltips.Insert(tooltips.GetIndex("OneDropLogo"), new TooltipLine(Mod, "ElementFire", Language.GetTextValue(Paths.FireElement))
                {
                    OverrideColor = Color.Firebrick
                });
            }
            if (Ice.Contains(type))
            {
                if (MMZeroElements.Server.legacySystem)
                {
                    tooltips.Insert(tooltips.GetIndex("OneDropLogo"), new TooltipLine(Mod, "ElementIce", Language.GetTextValue(Paths.IceElement))
                    {
                        OverrideColor = Color.LightSkyBlue
                    });
                }
                else
                {
                    tooltips.Insert(tooltips.GetIndex("OneDropLogo"), new TooltipLine(Mod, "ElementAqua", Language.GetTextValue(Paths.AquaElement))
                    {
                        OverrideColor = Color.LightSkyBlue
                    });
                }
            }
            if (Electric.Contains(type))
            {
                tooltips.Insert(tooltips.GetIndex("OneDropLogo"), new TooltipLine(Mod, "ElementElectric", Language.GetTextValue(Paths.ElectricElement))
                {
                    OverrideColor = Color.Cyan
                });
            }
            if (Wood.Contains(type))
            {
                tooltips.Insert(tooltips.GetIndex("OneDropLogo"), new TooltipLine(Mod, "WoodElectric", Language.GetTextValue(Paths.WoodElement))
                {
                    OverrideColor = Color.Green
                });
            }
        }
    }
}
