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

        public override void OnInitialize()
        {
            panel = new();
            panel.SetPadding(0);
            SetRectangle(panel, Main.screenWidth, Main.screenHeight, 200, 250);

            string startInfo = SetInfo();
            text = new UIText(startInfo); // text to read disk contents
            SetRectangle(text, 15, 15, 170, 220);
            panel.Append(text);

            Asset<Texture2D> buttonDeleteTexture = ModContent.Request<Texture2D>("Terraria/Images/UI/ButtonDelete");
            UIHoverImageButton closeButton = new UIHoverImageButton(buttonDeleteTexture, Language.GetTextValue("LegacyInterface.52")); // Localized text for "Close"
            SetRectangle(closeButton, 168f, 10f, 22f, 22f);
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

        string SetInfo()
        {
            string info = "Null NPC\n" +
                "--Elements--\n" +
                "[i:MMZeroElements/FireIcon] - 0.0x\n" +
                "[i:MMZeroElements/IceIcon] - 0.0x\n" +
                "[i:MMZeroElements/ElecIcon] - 0.0x\n" +
                "[i:MMZeroElements/WoodIcon] - 0.0x\n" +
                "----------";
            return info;
        }

        string SetInfo(NPC npc, Item item, Projectile proj)
        {
            string info;
            if (npc != null)
            {
                NPCElements elementNPC = npc.GetGlobalNPC<NPCElements>();
                string elementDamageIcon = "[i:MMZeroElements/DamageIcon]";
                info = npc.FullName + "\n" +
                    "---Elements---\n" +
                    "[i:MMZeroElements/FireIcon] - " + elementNPC.elementMultipliers[Element.Fire] + "x " +
                    (npc.IsFire() ? elementDamageIcon : "") + "\n" +
                    "[i:MMZeroElements/IceIcon] - " + elementNPC.elementMultipliers[Element.IceAqua] + "x " +
                    (npc.IsIce() ? elementDamageIcon : "") + "\n" +
                    "[i:MMZeroElements/ElecIcon] - " + elementNPC.elementMultipliers[Element.Elec] + "x " +
                    (npc.IsElec() ? elementDamageIcon : "") + "\n" +
                    "[i:MMZeroElements/WoodIcon] - " + elementNPC.elementMultipliers[Element.Wood] + "x " +
                    (npc.IsWood() ? elementDamageIcon : "") + "\n" +
                    "------------\n";
            }
            else
            {
                return SetInfo();
            }
            if (item != null)
            {
                info += item.Name + "\n" +
                    (item.IsFire() ? "[i:MMZeroElements/FireIcon] " : "") +
                    (item.IsIce() ? "[i:MMZeroElements/IceIcon] " : "") +
                    (item.IsElec() ? "[i:MMZeroElements/ElecIcon] " : "") +
                    (item.IsWood() ? "[i:MMZeroElements/WoodIcon] " : "") +
                    "";
            }
            else if (proj != null)
            {
                info += proj.Name + "\n" +
                    (proj.IsFire() ? "[i:MMZeroElements/FireIcon] " : "") +
                    (proj.IsIce() ? "[i:MMZeroElements/IceIcon] " : "") +
                    (proj.IsElec() ? "[i:MMZeroElements/ElecIcon] " : "") +
                    (proj.IsWood() ? "[i:MMZeroElements/WoodIcon] " : "") +
                    "";
            }
            else
            {
                info += "Null Source";
            }
            return info;
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            SetRectangle(panel, Main.screenWidth - 400 * Main.UIScale,
                Main.screenHeight - 270 * Main.UIScale,
                200, 250);

            if (panel.ContainsPoint(Main.MouseScreen))
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
            if (MMZeroElements.Client.elementUIDisplayStyle == "Always" && _elementInfoUI == null)
            {
                _elementInfoUI?.SetState(ElementInfoState);
            }
            if (_elementInfoUI != null)
                _elementInfoUI?.Update(gameTime);
        }

        public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
        {
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
