using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MMZeroElements.Utilities;
using ReLogic.Content;
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
        public static List<int> Metal = new();
        internal static List<int> Wood = new();

        public static Asset<Texture2D> FireIcon = ModContent.Request<Texture2D>("MMZeroElements/ElementIcons/FireIcon");
        public static Asset<Texture2D> IceIcon = ModContent.Request<Texture2D>("MMZeroElements/ElementIcons/IceIcon");
        public static Asset<Texture2D> ElectricIcon = ModContent.Request<Texture2D>("MMZeroElements/ElementIcons/ElectricIcon");

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
                tooltips.Insert(tooltips.GetIndex("OneDropLogo"), new TooltipLine(Mod, "ElementIce", Language.GetTextValue(Paths.IceElement))
                {
                    OverrideColor = Color.LightSkyBlue
                });
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
                    OverrideColor = Color.Cyan
                });
            }
        }
    }
}
