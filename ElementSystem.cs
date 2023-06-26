using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BattleNetworkElements
{
    public class ElementSystem : ModSystem
    {
        public override void PostAddRecipes()
        {
            for (int i = 0; i < Recipe.numRecipes; i++)
            {
                Recipe recipe = Main.recipe[i];

                if (recipe.TryGetResult(ItemID.PDA, out Item _))
                {
                    recipe.AddIngredient(ModContent.ItemType<ElementReader>());
                }
            }
        }
    }
}
