using MMZeroElements.Elements;
using Terraria;

namespace MMZeroElements.Utilities
{
    public static class ElementPlayerHelper
    {
        public static void SetFireResist(this Player player, float multiplier)
        {
            player.Elements().elementMultipliers[Element.Fire] = multiplier;
        }
        public static float GetFireResist(this Player player)
        {
            return player.Elements().elementMultipliers[Element.Fire];
        }

        public static void SetIceResist(this Player player, float multiplier)
        {
            player.Elements().elementMultipliers[Element.IceAqua] = multiplier;
        }
        public static float GetIceResist(this Player player)
        {
            return player.Elements().elementMultipliers[Element.IceAqua];
        }

        public static void SetElecResist(this Player player, float multiplier)
        {
            player.Elements().elementMultipliers[Element.Elec] = multiplier;
        }
        public static float GetElecResist(this Player player)
        {
            return player.Elements().elementMultipliers[Element.Elec];
        }

        public static void SetWoodResist(this Player player, float multiplier)
        {
            player.Elements().elementMultipliers[Element.Wood] = multiplier;
        }
        public static float GetWoodResist(this Player player)
        {
            return player.Elements().elementMultipliers[Element.Wood];
        }

        public static PlayerElements Elements(this Player player)
        {
            return player.GetModPlayer<PlayerElements>();
        }
    }
}
