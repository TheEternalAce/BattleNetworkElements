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
        public ElementInfo item;
        public ElementInfo projectile;

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
                    ElementMultipliersDefault = AssignElements();
                }
                vulnSet = true;
            }
        }

        public float[] AssignElements(int t = -1)
        {
            int element = t;
            if (t == -1)
            {
                element = Main.rand.Next(4);
            }
            float[] multipliers = element switch
            {
                Element.Fire => new[] { 0.8f, 2.0f, 1.0f, 0.5f },
                Element.Aqua => new[] { 0.5f, 0.8f, 2.0f, 1.0f },
                Element.Elec => new[] { 1.0f, 0.5f, 0.8f, 2.0f },
                Element.Wood => new[] { 2.0f, 1.0f, 0.5f, 0.8f },
                _ => new[] { 1.0f, 1.0f, 1.0f, 1.0f },
            };
            ElementMultipliersDefault = multipliers;
            return multipliers;
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

        void UpdateInfo(NPC npc, ElementInfo item, ElementInfo proj)
        {
            targetedNPC = npc;
            this.item = item;
            projectile = proj;
            if (BattleNetworkElements.Client.elementUIDisplayStyle != "Inventory open only")
            {
                ModContent.GetInstance<ElementInfoUI>().ShowMyUI();
            }
        }

        public override void OnHitNPCWithItem(Item item, NPC target, NPC.HitInfo hit, int damageDone)
        {
            ElementInfo eInfo = new()
            {
                name = item.Name,
                elements = item.ElementBoolArray()
            };
            UpdateInfo(target, eInfo, projectile);
        }
        public override void OnHitNPCWithProj(Projectile proj, NPC target, NPC.HitInfo hit, int damageDone)
        {
            ElementInfo eInfo = new()
            {
                name = proj.Name,
                elements = proj.ElementBoolArray()
            };
            UpdateInfo(target, item, eInfo);
        }
        public override void ModifyHitByNPC(NPC npc, ref Player.HurtModifiers modifiers)
        {
            UpdateInfo(npc, item, projectile);
            modifiers.FinalDamage *= ElementHelper.MultiplyDamage(npc, Player);
        }
        public override void ModifyHitByProjectile(Projectile proj, ref Player.HurtModifiers modifiers)
        {
            ElementInfo eInfo = new()
            {
                name = proj.Name,
                elements = proj.ElementBoolArray()
            };
            UpdateInfo(targetedNPC, item, eInfo);
            modifiers.FinalDamage *= ElementHelper.MultiplyDamage(proj, Player);
        }
        public struct ElementInfo
        {
            public string name;
            public bool[] elements;

            public override string ToString()
            {
                return name;
            }
        }
    }
}
