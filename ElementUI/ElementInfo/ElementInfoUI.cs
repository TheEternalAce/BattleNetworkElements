using BattleNetworkElements.Elements;
using BattleNetworkElements.Utilities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using System.Collections.Generic;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent.UI.Elements;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;

namespace BattleNetworkElements.ElementUI.ElementInfo
{
    internal class ElementInfoState : UIState
    {
        private UIPanel panel;
        private UIText text;
        float panelWidth = 250;
        float panelHeight = 210;

        Asset<Texture2D> buttonDeleteTexture;
        UIHoverImageButton closeButton;

        public override void OnInitialize()
        {
            panel = new();
            panel.SetPadding(0);
            SetRectangle(panel, 0, 0, panelWidth, panelHeight);

            string startInfo = SetInfo();
            text = new UIText(startInfo); // text to read disk contents
            SetRectangle(text, 15, 15, panelWidth - 30f, panelHeight - 30f);
            panel.Append(text);

            buttonDeleteTexture = ModContent.Request<Texture2D>("Terraria/Images/UI/ButtonDelete");
            closeButton = new UIHoverImageButton(buttonDeleteTexture, Language.GetTextValue("LegacyInterface.52")); // Localized text for "Close"
            SetRectangle(closeButton, panelWidth - 32f, panelHeight - 32f, 22f, 22f);
            closeButton.OnLeftClick += new MouseEvent(CloseButtonClicked);
            panel.Append(closeButton);

            Append(panel);
        }

        private void SetRectangle(UIElement uiElement, float left, float top, float width, float height)
        {
            uiElement.Left.Set(left, 0f);
            uiElement.Top.Set(top, 0f);
            uiElement.Width.Set(width, 0f);
            uiElement.Height.Set(height, 0f);
        }

        private void CloseButtonClicked(UIMouseEvent evt, UIElement listeningElement)
        {
            ModContent.GetInstance<ElementInfoUI>().HideMyUI();
        }

        string fireIcon = "[i:BattleNetworkElements/FireIcon]";
        string aquaIcon = "[i:BattleNetworkElements/AquaIcon]";
        string elecIcon = "[i:BattleNetworkElements/ElecIcon]";
        string woodIcon = "[i:BattleNetworkElements/WoodIcon]";
        string elementDamageIcon = "[i:BattleNetworkElements/DamageIcon]";

        string SetInfo()
        {
            string info = "Null NPC\n" +
                fireIcon + " - 0.0x " +
                aquaIcon + " - 0.0x\n" +
                elecIcon + " - 0.0x " +
                woodIcon + " - 0.0x\n" +
                "------------------\n" +
                "Null Item\n" +
                "Null Projectile";
            return info;
        }

        string SetInfo(BNPlayer bnPlayer)
        {
            string info;
            var item = bnPlayer.item;
            var npc = bnPlayer.targetedNPC;
            var projectile = bnPlayer.projectile;

            if (npc == null)
            {
                info = SetInfo();
            }
            else
            {
                if (npc.type == NPCID.None || npc.type == NPCID.None2 || npc.type == NPCID.None3)
                {
                    info = SetInfo();
                }
                else
                {
                    BNGlobalNPC elementNPC = npc.GetGlobalNPC<BNGlobalNPC>();
                    info = npc.FullName + "\n" +
                        fireIcon + " - " + elementNPC.elementMultipliers[Element.Fire] + "x " +
                        (npc.IsFire() ? elementDamageIcon : "") + " " +
                        aquaIcon + " - " + elementNPC.elementMultipliers[Element.Aqua] + "x " +
                        (npc.IsAqua() ? elementDamageIcon : "") + "\n" +
                        elecIcon + " - " + elementNPC.elementMultipliers[Element.Elec] + "x " +
                        (npc.IsElec() ? elementDamageIcon : "") + " " +
                        woodIcon + " - " + elementNPC.elementMultipliers[Element.Wood] + "x " +
                        (npc.IsWood() ? elementDamageIcon : "") + "\n" +
                        "------------------\n";
                }
                if (item.name != "" && item.name != null)
                {
                    info += item + " " + ElementInfo(item);
                }
                else
                {
                    info += "Null Item";
                }
                info += "\n";
                if (projectile.name != "" && projectile.name != null)
                {
                    info += projectile + " " + ElementInfo(projectile);
                }
                else
                {
                    info += "Null Projectile";
                }
            }
            return info;
        }

        string ElementInfo(BNPlayer.ElementInfo info)
        {
            string str = "";
            if (info.elements != null)
            {
                if (info.elements[0])
                {
                    str += fireIcon;
                }
                if (info.elements[1])
                {
                    str += aquaIcon;
                }
                if (info.elements[2])
                {
                    str += elecIcon;
                }
                if (info.elements[3])
                {
                    str += woodIcon;
                }
            }
            return str;
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            string uiStyle = BattleNetworkElements.Client.elementUIDisplayStyle;
            if (uiStyle == "Never")
            {
                return;
            }

            float xOffset = 400 - BattleNetworkElements.Client.uiOffsetX;
            float yOffset = 270 + BattleNetworkElements.Client.uiOffsetY;
            if (Main.playerInventory)
            {
                xOffset += 300;
                yOffset = Main.screenHeight - 100;
            }
            SetRectangle(panel, Main.screenWidth - xOffset * Main.UIScale,
                Main.screenHeight - yOffset * Main.UIScale,
                panelWidth, panelHeight);

            if (panel.HasChild(closeButton) && uiStyle != "After hit")
            {
                if (uiStyle == "Inventory open only" || uiStyle == "Always")
                {
                    panel.RemoveChild(closeButton);
                }
            }
            else if (!panel.HasChild(closeButton) && uiStyle == "After hit")
            {
                panel.Append(closeButton);
            }
            if (closeButton.ContainsPoint(Main.MouseScreen))
            {
                Main.LocalPlayer.mouseInterface = true;
            }
            Player player = Main.LocalPlayer;

            BNPlayer elementPlayer = player.GetModPlayer<BNPlayer>();
            text.SetText(SetInfo(elementPlayer));
        }
    }

    class ElementInfoUI : ModSystem
    {
        internal ElementInfoState ElementInfoState;
        private UserInterface _elementInfoUI;

        // These two methods will set the state of our custom UI, causing it to show or hide
        public void ShowMyUI()
        {
            if (BattleNetworkElements.Client.elementUIDisplayStyle == "Never")
            {
                return;
            }
            _elementInfoUI?.SetState(ElementInfoState);
        }

        public void HideMyUI()
        {
            if (BattleNetworkElements.Client.elementUIDisplayStyle == "Always")
            {
                return;
            }
            if (BattleNetworkElements.Client.elementUIDisplayStyle != "Inventory open only")
            {
                SoundEngine.PlaySound(SoundID.MenuClose);
            }
            _elementInfoUI?.SetState(null);
        }

        public override void Load()
        {
            if (!Main.dedServ)
            {
                ElementInfoState = new();
                _elementInfoUI = new();
                //if (BattleNetworkElements.Client.elementUIDisplayStyle == "Always")
                //{
                //    _elementInfoUI?.SetState(ElementInfoState);
                //}
                ElementInfoState.Activate();
            }
        }

        public override void UpdateUI(GameTime gameTime)
        {
            if (_elementInfoUI != null)
                _elementInfoUI?.Update(gameTime);
        }

        public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
        {
            if (BattleNetworkElements.Client.elementUIDisplayStyle == "Always" && _elementInfoUI.CurrentState == null)
            {
                _elementInfoUI?.SetState(ElementInfoState);
            }
            int mouseTextIndex = layers.FindIndex(layer => layer.Name.Equals("Vanilla: Mouse Text"));
            if (mouseTextIndex != -1)
            {
                layers.Insert(mouseTextIndex, new LegacyGameInterfaceLayer(
                    "BattleNetworkElements: Elements Info",
                    delegate
                    {
                        _elementInfoUI.Draw(Main.spriteBatch, new GameTime());
                        return true;
                    },
                    InterfaceScaleType.UI)
                );
            }
        }
    }
}
