using Terraria;
using Terraria.ModLoader;

namespace MMZeroElements
{
    public class NPCElementInfoDisplay : InfoDisplay
    {
        public override void SetStaticDefaults()
        {
            // This is the name that will show up when hovering over icon of this info display
            InfoName.SetDefault("NPC Element");
        }

        public override bool Active()
        {
            return true;
        }

        public override string DisplayValue()
        {
            string data = "N/A";
            NPC targetNPC = Main.LocalPlayer.GetModPlayer<PlayerElements>().targetedNPC;
            if (targetNPC != null)
            {
                int type = targetNPC.type;
                double[] multipliers = targetNPC.GetGlobalNPC<NPCElements>().elementMultipliers;
                data = $"{targetNPC.FullName}\n" +
                    $"-Elements-\n" +
                    $"Fire: {(float)multipliers[0]}x\n" +
                    $"Ice: {(float)multipliers[1]}x\n" +
                    $"Electric: {(float)multipliers[2]}x";
            }
            return data;
        }
    }
}
