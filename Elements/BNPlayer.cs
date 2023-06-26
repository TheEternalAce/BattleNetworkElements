using BattleNetworkElements.ElementUI.ElementInfo;
using BattleNetworkElements.Utilities;
using System.Linq;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace BattleNetworkElements.Elements
{
    public class BNPlayer : ModPlayer
    {
        public float[] elementMultipliers = { 1.0f, 1.0f, 1.0f, 1.0f };
        private float[] ElementMultipliersDefault = { 1.0f, 1.0f, 1.0f, 1.0f };
        bool vulnSet = false;
        public NPC targetedNPC = null;
        public Item latestItem = null;
        public Projectile latestProj = null;

        public override void SaveData(TagCompound tag)
        {
            tag.Add(nameof(ElementMultipliersDefault), ElementMultipliersDefault.ToList());
            tag[nameof(vulnSet)] = vulnSet;
        }

        public override void LoadData(TagCompound tag)
        {
            if (tag.ContainsKey(nameof(vulnSet)))
            {
                vulnSet = tag.GetBool(nameof(vulnSet));
            }
            if (tag.ContainsKey(nameof(ElementMultipliersDefault)))
            {
                ElementMultipliersDefault = tag.GetList<float>(nameof(ElementMultipliersDefault)).ToArray();
            }
        }

        public override void OnEnterWorld()
        {
            if (!vulnSet)
            {
                if (Main.rand.NextFloat() <= 0.66f)
                {
                    int element = Main.rand.Next(4);
                    float[] multipliers = new float[4];
                    switch (element)
                    {
                        case Element.Fire:
                            multipliers = new[] { 0.8f, 2.0f, 1.0f, 0.5f };
                            break;
                        case Element.Aqua:
                            multipliers = new[] { 0.5f, 0.8f, 2.0f, 1.0f };
                            break;
                        case Element.Elec:
                            multipliers = new[] { 1.0f, 0.5f, 0.8f, 2.0f };
                            break;
                        case Element.Wood:
                            multipliers = new[] { 2.0f, 1.0f, 0.5f, 0.8f };
                            break;
                    }
                    ElementMultipliersDefault = multipliers;
                }
                vulnSet = true;
            }
        }

        public override void ResetEffects()
        {
            if (BattleNetworkElements.Client.enablePlayerElement)
            {
                float[] reset = ElementMultipliersDefault.Select(i => i).ToArray();
                elementMultipliers = reset;
            }
            else
            {
                elementMultipliers = new[] { 1f, 1f, 1f, 1f };
            }

            if (BattleNetworkElements.Client.elementUIDisplayStyle == "Inventory open only")
            {
                if (Main.playerInventory)
                {
                    ModContent.GetInstance<ElementInfoUI>().ShowMyUI();
                }
                else
                {
                    ModContent.GetInstance<ElementInfoUI>().HideMyUI();
                }
            }
        }

        void UpdateInfo(NPC npc, Item item, Projectile projectile)
        {
            targetedNPC = npc;
            if (projectile?.owner == Player.whoAmI)
            {
                latestProj = projectile;
            }
            latestItem = item;
            if (BattleNetworkElements.Client.elementUIDisplayStyle != "Inventory open only")
            {
                ModContent.GetInstance<ElementInfoUI>().ShowMyUI();
            }
        }

        public override void OnHitNPCWithItem(Item item, NPC target, NPC.HitInfo hit, int damageDone)
        {
            UpdateInfo(target, item, null);
        }

        public override void OnHitNPCWithProj(Projectile proj, NPC target, NPC.HitInfo hit, int damageDone)
        {
            UpdateInfo(target, null, proj);
        }

        public override void ModifyHitByNPC(NPC npc, ref Player.HurtModifiers modifiers)
        {
            UpdateInfo(npc, latestItem, latestProj);

            modifiers.FinalDamage *= ElementHelper.MultiplyDamage(npc, Player);
        }

        public override void ModifyHitByProjectile(Projectile proj, ref Player.HurtModifiers modifiers)
        {
            UpdateInfo(targetedNPC, latestItem, proj);

            modifiers.FinalDamage *= ElementHelper.MultiplyDamage(proj, Player);
        }
    }
}
