using BattleNetworkElements.Elements;
using Terraria;

namespace BattleNetworkElements.Utilities
{
    public static class ElementPlayerHelper
    {
        public static ref float[] ElementMultipliers(this Player player)
        {
            return ref player.Elements().elementMultipliers;
        }
        public static ref float FireMultiplier(this Player player)
        {
            return ref player.ElementMultipliers()[Element.Fire];
        }
        public static ref float AquaMultiplier(this Player player)
        {
            return ref player.ElementMultipliers()[Element.Aqua];
        }
        public static ref float ElecMultiplier(this Player player)
        {
            return ref player.ElementMultipliers()[Element.Elec];
        }
        public static ref float WoodMultiplier(this Player player)
        {
            return ref player.ElementMultipliers()[Element.Wood];
        }

        public static BNPlayer Elements(this Player player)
        {
            return player.GetModPlayer<BNPlayer>();
        }
    }
}
