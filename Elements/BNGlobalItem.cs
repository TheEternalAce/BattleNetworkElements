using BattleNetworkElements.Utilities;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace BattleNetworkElements.Elements
{
    public partial class BNGlobalItem : GlobalItem
    {
        public bool isFire = false;
        public bool isAqua = false;
        public bool isElec = false;
        public bool isWood = false;

        public override bool InstancePerEntity => true;

        public override void SetDefaults(Item entity)
        {
            if (entity.IsDefaultFire())
            {
                isFire = true;
            }
            if (entity.IsDefaultAqua())
            {
                isAqua = true;
            }
            if (entity.IsDefaultElec())
            {
                isElec = true;
            }
            if (entity.IsDefaultWood())
            {
                isWood = true;
            }
        }

        public override void Unload()
        {
            Fire.Clear();
            Aqua.Clear();
            Electric.Clear();
            Wood.Clear();
        }

        public override void UpdateInventory(Item item, Player player)
        {
            ResetElements(item);
        }

        public override void Update(Item item, ref float gravity, ref float maxFallSpeed)
        {
            ResetElements(item);
        }

        public void ResetElements(Item item)
        {
            isFire = false;
            isAqua = false;
            isElec = false;
            isWood = false;
            if (item.IsDefaultFire())
            {
                isFire = true;
            }
            if (item.IsDefaultAqua())
            {
                isAqua = true;
            }
            if (item.IsDefaultElec())
            {
                isElec = true;
            }
            if (item.IsDefaultWood())
            {
                isWood = true;
            }
        }

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            int type = item.type;
            if (type == ItemID.CellPhone || type == ItemID.PDA)
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
            if (item.IsFire())
            {
                tooltips.Insert(tooltips.GetIndex("OneDropLogo"), new(Mod, "ElementFire", Language.GetTextValue(Paths.FireElement))
                {
                    OverrideColor = Color.Firebrick
                });
            }
            if (item.IsAqua())
            {
                tooltips.Insert(tooltips.GetIndex("OneDropLogo"), new(Mod, "ElementAqua", Language.GetTextValue(Paths.AquaElement))
                {
                    OverrideColor = Color.LightSkyBlue
                });
            }
            if (item.IsElec())
            {
                tooltips.Insert(tooltips.GetIndex("OneDropLogo"), new(Mod, "ElementElectric", Language.GetTextValue(Paths.ElectricElement))
                {
                    OverrideColor = Color.Cyan
                });
            }
            if (item.IsWood())
            {
                tooltips.Insert(tooltips.GetIndex("OneDropLogo"), new(Mod, "ElementWood", Language.GetTextValue(Paths.WoodElement))
                {
                    OverrideColor = Color.Green
                });
            }
            if (BattleNetworkElements.Client.nullElementIcon)
            {
                if (item.damage > 0)
                {
                    if (!item.IsFire() && !item.IsAqua() && !item.IsElec() && !item.IsWood())
                    {
                        tooltips.Insert(tooltips.GetIndex("OneDropLogo"), new(Mod, "ElementNull", Language.GetTextValue(Paths.NullElement))
                        {
                            OverrideColor = Color.Gray
                        });
                    }
                }
            }
        }
    }
}
