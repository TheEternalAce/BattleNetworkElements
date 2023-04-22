using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MMZeroElements.Elements;
using MMZeroElements.Utilities;
using ReLogic.Content;
using System.Collections.Generic;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent.UI.Elements;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;

namespace MMZeroElements.ElementUI.ElementInfo
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

        string fireIcon = "[i:MMZeroElements/FireIcon]";
        string aquaIcon = "[i:MMZeroElements/AquaIcon]";
        string elecIcon = "[i:MMZeroElements/ElecIcon]";
        string woodIcon = "[i:MMZeroElements/WoodIcon]";
        string elementDamageIcon = "[i:MMZeroElements/DamageIcon]";

        string SetInfo()
        {
            string info = "Null NPC\n" +
                "--Elements--\n" +
                fireIcon + " - 0.0x " +
                aquaIcon + " - 0.0x\n" +
                elecIcon + " - 0.0x " +
                woodIcon + " - 0.0x\n" +
                "----------";
            return info;
        }

        string SetInfo(NPC npc, Item item, Projectile proj)
        {
            string info;
            if (npc != null)
            {
                NPCElements elementNPC = npc.GetGlobalNPC<NPCElements>();
                info = npc.FullName + "\n" +
                    fireIcon + " - " + elementNPC.elementMultipliers[Element.Fire] + "x " +
                    (npc.IsFire() ? elementDamageIcon : "") + " " +
                    aquaIcon + " - " + elementNPC.elementMultipliers[Element.IceAqua] + "x " +
                    (npc.IsIce() ? elementDamageIcon : "") + "\n" +
                    elecIcon + " - " + elementNPC.elementMultipliers[Element.Elec] + "x " +
                    (npc.IsElec() ? elementDamageIcon : "") + " " +
                    woodIcon + " - " + elementNPC.elementMultipliers[Element.Wood] + "x " +
                    (npc.IsWood() ? elementDamageIcon : "") + "\n" +
                    "------------------\n";
            }
            else
            {
                return SetInfo();
            }
            if (item != null)
            {
                info += item.Name + "\nElements: ";
                ItemElementInfo(ref info, item);
                info += "\nDefault: ";
                ItemElementInfoDefault(ref info, item);
            }
            else if (proj != null)
            {
                info += proj.Name + "\nElements: ";
                ProjectileElementInfo(ref info, proj);
                info += "\nDefault: ";
                ProjectileElementInfoDefault(ref info, proj);
            }
            else
            {
                info += "Null Source";
            }
            return info;
        }

        void ItemElementInfo(ref string info, Item item)
        {
            if (item.IsFire() || item.IsIce() || item.IsElec() || item.IsWood())
            {
                if (item.IsFire())
                {
                    info += fireIcon;
                }
                if (item.IsIce())
                {
                    info += aquaIcon;
                }
                if (item.IsElec())
                {
                    info += elecIcon;
                }
                if (item.IsWood())
                {
                    info += woodIcon;
                }
            }
        }
        void ItemElementInfoDefault(ref string info, Item item)
        {
            if (item.IsDefaultFire() || item.IsDefaultIceAqua() || item.IsDefaultElec() || item.IsDefaultWood())
            {
                if (item.IsDefaultFire())
                {
                    info += fireIcon;
                }
                if (item.IsDefaultIceAqua())
                {
                    info += aquaIcon;
                }
                if (item.IsDefaultElec())
                {
                    info += elecIcon;
                }
                if (item.IsDefaultWood())
                {
                    info += woodIcon;
                }
            }
        }

        void ProjectileElementInfo(ref string info, Projectile proj)
        {
            if (proj.IsFire() || proj.IsIceAqua() || proj.IsElec() || proj.IsWood())
            {
                if (proj.IsFire())
                {
                    info += fireIcon;
                }
                if (proj.IsIceAqua())
                {
                    info += aquaIcon;
                }
                if (proj.IsElec())
                {
                    info += elecIcon;
                }
                if (proj.IsWood())
                {
                    info += woodIcon;
                }
            }
        }
        void ProjectileElementInfoDefault(ref string info, Projectile proj)
        {
            if (proj.IsDefaultFire() || proj.IsDefaultIceAqua() || proj.IsDefaultElec() || proj.IsDefaultWood())
            {
                if (proj.IsDefaultFire())
                {
                    info += fireIcon;
                }
                if (proj.IsDefaultIceAqua())
                {
                    info += aquaIcon;
                }
                if (proj.IsDefaultElec())
                {
                    info += elecIcon;
                }
                if (proj.IsDefaultWood())
                {
                    info += woodIcon;
                }
            }
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            string uiStyle = MMZeroElements.Client.elementUIDisplayStyle;
            if (uiStyle == "Never")
            {
                return;
            }

            float xOffset = 400 - MMZeroElements.Client.uiOffsetX;
            float yOffset = 270 + MMZeroElements.Client.uiOffsetY;
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

            PlayerElements elementPlayer = player.GetModPlayer<PlayerElements>();
            text.SetText(SetInfo(elementPlayer.targetedNPC, elementPlayer.latestItem, elementPlayer.latestProj));
        }
    }

    class ElementInfoUI : ModSystem
    {
        internal ElementInfoState ElementInfoState;
        private UserInterface _elementInfoUI;

        // These two methods will set the state of our custom UI, causing it to show or hide
        public void ShowMyUI()
        {
            if (MMZeroElements.Client.elementUIDisplayStyle == "Never")
            {
                return;
            }
            _elementInfoUI?.SetState(ElementInfoState);
        }

        public void HideMyUI()
        {
            if (MMZeroElements.Client.elementUIDisplayStyle == "Always")
            {
                return;
            }
            if (MMZeroElements.Client.elementUIDisplayStyle != "Inventory open only")
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
                //if (MMZeroElements.Client.elementUIDisplayStyle == "Always")
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
            if (MMZeroElements.Client.elementUIDisplayStyle == "Always" && _elementInfoUI.CurrentState == null)
            {
                _elementInfoUI?.SetState(ElementInfoState);
            }
            int mouseTextIndex = layers.FindIndex(layer => layer.Name.Equals("Vanilla: Mouse Text"));
            if (mouseTextIndex != -1)
            {
                layers.Insert(mouseTextIndex, new LegacyGameInterfaceLayer(
                    "MMZeroElements: Elements Info",
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
