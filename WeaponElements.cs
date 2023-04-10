using Microsoft.Xna.Framework;
using MMZeroElements.Utilities;
using System.Collections.Generic;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace MMZeroElements
{
    public class WeaponElements : GlobalItem
    {
        public static List<int> Fire = new();
        public static List<int> Ice = new();
        public static List<int> Electric = new();
        internal static List<int> Wood = new();

        public override bool InstancePerEntity => true;

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            int type = item.type;
            if (Fire.Contains(type))
            {
                tooltips.Insert(tooltips.GetIndex("OneDropLogo"), new TooltipLine(Mod, "ElementFire", Language.GetTextValue(LanguagePaths.FireElement))
                {
                    OverrideColor = Color.Firebrick
                });
            }
            if (Ice.Contains(type))
            {
                tooltips.Insert(tooltips.GetIndex("OneDropLogo"), new TooltipLine(Mod, "ElementIce", Language.GetTextValue(LanguagePaths.IceElement))
                {
                    OverrideColor = Color.LightSkyBlue
                });
            }
            if (Electric.Contains(type))
            {
                tooltips.Insert(tooltips.GetIndex("OneDropLogo"), new TooltipLine(Mod, "ElementElectric", Language.GetTextValue(LanguagePaths.ElectricElement))
                {
                    OverrideColor = Color.Cyan
                });
            }
            if (Wood.Contains(type))
            {
                tooltips.Insert(tooltips.GetIndex("OneDropLogo"), new TooltipLine(Mod, "WoodElectric", Language.GetTextValue(LanguagePaths.WoodElement))
                {
                    OverrideColor = Color.Cyan
                });
            }
        }
    }
}
