using Terraria.ModLoader;
using Terraria.ID;

namespace Wildlife
{
	class Wildlife : Mod
	{
		public Wildlife()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
		 public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(this); //wormhole
			recipe.AddIngredient(ItemID.BottledWater, 1);
            recipe.AddIngredient(null, "FluxCoral", 1);
			recipe.AddIngredient(3191, 1);
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(2997);
            recipe.AddRecipe();
			
			
            ModRecipe recipe2 = new ModRecipe(this); //calming
			recipe2.AddIngredient(ItemID.BottledWater, 1);
            recipe2.AddIngredient(null, "CatTail", 1);
			recipe2.AddIngredient(313, 1);
            recipe2.AddTile(TileID.Bottles);
            recipe2.SetResult(2324);
            recipe2.AddRecipe();
			
			ModRecipe recipe3 = new ModRecipe(this); //teleporation
			recipe3.AddIngredient(ItemID.BottledWater, 1);
            recipe3.AddIngredient(null, "FluxCoral", 1);
			recipe3.AddIngredient(2317, 1);
            recipe3.AddTile(TileID.Bottles);
            recipe3.SetResult(2351);
            recipe3.AddRecipe();
			
			ModRecipe recipe4 = new ModRecipe(this); //archery
			recipe4.AddIngredient(ItemID.BottledWater, 1);
            recipe4.AddIngredient(null, "CatTail", 1);
			recipe4.AddIngredient(null, "Bamboo", 1);
            recipe4.AddTile(TileID.Bottles);
            recipe4.SetResult(303);
            recipe4.AddRecipe();
			
			ModRecipe recipe5 = new ModRecipe(this); //hunting
			recipe5.AddIngredient(ItemID.BottledWater, 1);
            recipe5.AddIngredient(null, "Jaderose", 1);
			recipe5.AddIngredient(315, 1);
            recipe5.AddTile(TileID.Bottles);
            recipe5.SetResult(304);
            recipe5.AddRecipe();
        }
	}
}
