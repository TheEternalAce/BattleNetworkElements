using BattleNetworkElements.Elements;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace BattleNetworkElements.Utilities
{
    public static class ElementItemHelper
    {
        public static BNGlobalItem Elements(this Item item)
        {
            return item.GetGlobalItem<BNGlobalItem>();
        }

        public static void AddFire(this Item item)
        {
            item.type.AddFireItem();
        }
        public static void AddFireItem(this int itemType)
        {
            BNGlobalItem.Fire.Add(itemType);
        }
        public static bool IsFire(this Item item)
        {
            return item.Elements().isFire;
        }
        public static bool IsDefaultFire(this Item item)
        {
            return item.type.ItemIsFire();
        }
        public static bool ItemIsFire(this int type)
        {
            return BNGlobalItem.Fire.Contains(type);
        }

        public static void AddAqua(this Item item)
        {
            item.type.AddAquaItem();
        }
        public static void AddAquaItem(this int itemType)
        {
            BNGlobalItem.Aqua.Add(itemType);
        }
        public static bool IsAqua(this Item item)
        {
            return item.Elements().isAqua;
        }
        public static bool IsDefaultAqua(this Item item)
        {
            return item.type.ItemIsAqua();
        }
        public static bool ItemIsAqua(this int type)
        {
            return BNGlobalItem.Aqua.Contains(type);
        }

        public static void AddElec(this Item item)
        {
            item.type.AddElecItem();
        }
        public static void AddElecItem(this int itemType)
        {
            BNGlobalItem.Electric.Add(itemType);
        }
        public static bool IsElec(this Item item)
        {
            return item.Elements().isElec;
        }
        public static bool IsDefaultElec(this Item item)
        {
            return item.type.ItemElec();
        }
        public static bool ItemElec(this int type)
        {
            return BNGlobalItem.Electric.Contains(type);
        }

        public static void AddWood(this Item item)
        {
            item.type.AddWoodItem();
        }
        public static void AddWoodItem(this int itemType)
        {
            BNGlobalItem.Wood.Add(itemType);
        }
        public static bool IsWood(this Item item)
        {
            return item.Elements().isWood;
        }
        public static bool IsDefaultWood(this Item item)
        {
            return item.type.ItemIsWood();
        }
        public static bool ItemIsWood(this int type)
        {
            return BNGlobalItem.Wood.Contains(type);
        }

        public static bool[] ElementBoolArray(this Item item)
        {
            bool[] elements = new bool[4];
            elements[0] = item.IsFire();
            elements[1] = item.IsAqua();
            elements[2] = item.IsElec();
            elements[3] = item.IsWood();
            return elements;
        }

        internal static readonly string[] VanillaTooltipNames = new string[]
        {
                "ItemName",
                "Favorite",
                "FavoriteDesc",
                "Social",
                "SocialDesc",
                "Damage",
                "CritChance",
                "Speed",
                "Knockback",
                "FishingPower",
                "NeedsBait",
                "BaitPower",
                "Equipable",
                "WandConsumes",
                "Quest",
                "Vanity",
                "Defense",
                "PickPower",
                "AxePower",
                "HammerPower",
                "TileBoost",
                "HealLife",
                "HealMana",
                "UseMana",
                "Placeable",
                "Ammo",
                "Consumable",
                "Material",
                "Tooltip#",
                "EtherianManaWarning",
                "WellFedExpert",
                "BuffTime",
                "OneDropLogo",
                "PrefixDamage",
                "PrefixSpeed",
                "PrefixCritChance",
                "PrefixUseMana",
                "PrefixSize",
                "PrefixShootSpeed",
                "PrefixKnockback",
                "PrefixAccDefense",
                "PrefixAccMaxMana",
                "PrefixAccCritChance",
                "PrefixAccDamage",
                "PrefixAccMoveSpeed",
                "PrefixAccMeleeSpeed",
                "SetBonus",
                "Expert",
                "Master",
                "JourneyResearch",
                "BestiaryNotes",
                "SpecialPrice",
                "Price",
        };

        private static int FindLineIndex(string name)
        {
            if (name.StartsWith("Tooltip"))
            {
                name = "Tooltip#";
            }
            for (int i = 0; i < VanillaTooltipNames.Length; i++)
            {
                if (name == VanillaTooltipNames[i])
                {
                    return i;
                }
            }
            return -1;
        }

        public static void AddTooltip(this List<TooltipLine> tooltips, TooltipLine line)
        {
            tooltips.Insert(Math.Min(tooltips.GetIndex("Tooltip#"), tooltips.Count), line);
        }

        public static int GetIndex(this List<TooltipLine> tooltips, string lineName)
        {
            int myIndex = FindLineIndex(lineName);
            int i = 0;
            for (; i < tooltips.Count; i++)
            {
                if (tooltips[i].Mod == "Terraria" && FindLineIndex(tooltips[i].Name) >= myIndex)
                {
                    if (lineName == "Tooltip#")
                    {
                        for (; i < tooltips.Count; i++)
                        {
                            if (!tooltips[i].Name.StartsWith("Tooltip"))
                            {
                                return i;
                            }
                        }
                    }
                    return i;
                }
            }
            return i;
        }
    }
}