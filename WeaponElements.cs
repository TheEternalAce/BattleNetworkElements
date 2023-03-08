using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MMZeroElements.Utilities;
using ReLogic.Content;
using System.Collections.Generic;
using Terraria;
using Terraria.GameContent;
using Terraria.ID;
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

        public static Asset<Texture2D> FireIcon = ModContent.Request<Texture2D>("MMZeroElements/FireIcon");
        public static Asset<Texture2D> IceIcon = ModContent.Request<Texture2D>("MMZeroElements/IceIcon");
        public static Asset<Texture2D> ElectricIcon = ModContent.Request<Texture2D>("MMZeroElements/ElectricIcon");
        public static Asset<Texture2D> MetalIcon = ModContent.Request<Texture2D>("MMZeroElements/MetalIcon");

        public override bool InstancePerEntity => true;

        public override bool PreDrawTooltipLine(Item item, DrawableTooltipLine line, ref int yOffset)
        {
            Rectangle rect = new Rectangle(0, 0, 30, 30);
            Vector2 scale = new(2f / 3f, 2f / 3f);
            Vector2 origin = new(0f, 0f);
            if (line.Name == "ElementFire")
            {
                Main.spriteBatch.Draw(FireIcon.Value, new Vector2(line.X, line.Y), rect, Color.White, 0f, origin, scale, 0, 0f);
                Utils.DrawBorderStringFourWay(Main.spriteBatch, FontAssets.MouseText.Value, line.Text, line.X, line.Y, line.OverrideColor ?? line.Color, Color.Black, line.Origin);
                return false;
            }
            if (line.Name == "ElementIce")
            {
                Main.spriteBatch.Draw(IceIcon.Value, new Vector2(line.X, line.Y), rect, Color.White, 0f, origin, scale, 0, 0f);
                Utils.DrawBorderStringFourWay(Main.spriteBatch, FontAssets.MouseText.Value, line.Text, line.X, line.Y, line.OverrideColor ?? line.Color, Color.Black, line.Origin);
                return false;
            }
            if (line.Name == "ElementElectric")
            {
                Main.spriteBatch.Draw(ElectricIcon.Value, new Vector2(line.X, line.Y), rect, Color.White, 0f, origin, scale, 0, 0f);
                Utils.DrawBorderStringFourWay(Main.spriteBatch, FontAssets.MouseText.Value, line.Text, line.X, line.Y, line.OverrideColor ?? line.Color, Color.Black, line.Origin);
                return false;
            }
            if (line.Name == "ElementMetal")
            {
                Main.spriteBatch.Draw(MetalIcon.Value, new Vector2(line.X, line.Y), rect, Color.White, 0f, origin, scale, 0, 0f);
                Utils.DrawBorderStringFourWay(Main.spriteBatch, FontAssets.MouseText.Value, line.Text, line.X, line.Y, line.OverrideColor ?? line.Color, Color.Black, line.Origin);
                return false;
            }
            return base.PreDrawTooltipLine(item, line, ref yOffset);
        }

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            int type = item.type;
            if (Fire.Contains(type))
            {
                tooltips.Insert(tooltips.GetIndex("OneDropLogo"), new TooltipLine(Mod, "ElementFire", "    " + Language.GetTextValue(Paths.FireElement))
                {
                    OverrideColor = Color.Firebrick
                });
            }
            if (Ice.Contains(type))
            {
                tooltips.Insert(tooltips.GetIndex("OneDropLogo"), new TooltipLine(Mod, "ElementIce", "    " + Language.GetTextValue(Paths.IceElement))
                {
                    OverrideColor = Color.LightSkyBlue
                });
            }
            if (Electric.Contains(type))
            {
                tooltips.Insert(tooltips.GetIndex("OneDropLogo"), new TooltipLine(Mod, "ElementElectric", "    " + Language.GetTextValue(Paths.ElectricElement))
                {
                    OverrideColor = Color.Cyan
                });
            }
            if (Metal.Contains(type))
            {
                tooltips.Insert(tooltips.GetIndex("OneDropLogo"), new TooltipLine(Mod, "ElementMetal", "    " + Language.GetTextValue(Paths.MetalElement))
                {
                    OverrideColor = Color.Gray
                });
            }
        }

        public void AddProjectilesToElements(Item item)
        {
            int type = item.type;
            if (item.shoot != ProjectileID.None && item.ammo != AmmoID.Rocket && item.useAmmo == AmmoID.None)
            {
                if (Fire.Contains(type) && !ProjectileElements.Fire.Contains(type))
                {
                    ProjectileElements.Fire.Add(item.shoot);
                }
                if (Ice.Contains(type) && !ProjectileElements.Ice.Contains(type))
                {
                    ProjectileElements.Ice.Add(item.shoot);
                }
                if (Electric.Contains(type) && !ProjectileElements.Electric.Contains(type))
                {
                    ProjectileElements.Electric.Add(item.shoot);
                }
                if (Metal.Contains(type) && !ProjectileElements.Metal.Contains(type))
                {
                    ProjectileElements.Metal.Add(item.shoot);
                }
            }
        }

        public override void SetDefaults(Item item)
        {
            AddProjectilesToElements(item);
        }
    }
}
