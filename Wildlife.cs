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
			
			ModRecipe recipe5 = new ModRecipe(this); //Lesser Healing
			recipe5.AddIngredient(ItemID.BottledWater, 1);
            recipe5.AddIngredient(null, "Strawberry", 2);
			recipe5.AddIngredient(313, 1);
            recipe5.AddTile(TileID.Bottles);
            recipe5.SetResult(28);
            recipe5.AddRecipe();
			
			ModRecipe recipe6 = new ModRecipe(this); //hunting
			recipe6.AddIngredient(ItemID.BottledWater, 1);
            recipe6.AddIngredient(null, "Jaderose", 1);
			recipe6.AddIngredient(315, 1);
            recipe6.AddTile(TileID.Bottles);
            recipe6.SetResult(304);
            recipe6.AddRecipe();
			
			ModRecipe recipe7 = new ModRecipe(this); //warmth
			recipe7.AddIngredient(ItemID.BottledWater, 1);
            recipe7.AddIngredient(null, "FrostShine", 1);
			recipe7.AddIngredient(2358, 1);
            recipe7.AddTile(TileID.Bottles);
            recipe7.SetResult(2359);
            recipe7.AddRecipe();
			
			ModRecipe recipe8 = new ModRecipe(this); //gills
			recipe8.AddIngredient(ItemID.BottledWater, 1);
            recipe8.AddIngredient(null, "FrostShine", 1);
			recipe8.AddIngredient(null, "CatTail", 1);
            recipe8.AddTile(TileID.Bottles);
            recipe8.SetResult(291);
            recipe8.AddRecipe();
			
			ModRecipe recipe9 = new ModRecipe(this); //gills
			recipe9.AddIngredient(ItemID.BottledWater, 1);
            recipe9.AddIngredient(null, "Bamboo", 1);
			recipe9.AddIngredient(null, "Jaderose", 1);
            recipe9.AddTile(TileID.Bottles);
            recipe9.SetResult(291);
            recipe9.AddRecipe();
			
			ModRecipe recipe10 = new ModRecipe(this); //ObsSkin
			recipe10.AddIngredient(ItemID.BottledWater, 1);
            recipe10.AddIngredient(null, "MagmaCorn", 1);
			recipe10.AddIngredient(173, 1);
			recipe10.AddIngredient(317, 1);
            recipe10.AddTile(TileID.Bottles);
            recipe10.SetResult(288);
            recipe10.AddRecipe();
	    
			ModRecipe recipe11 = new ModRecipe(this); //Inferno
			recipe11.AddIngredient(ItemID.BottledWater, 1);
			recipe11.AddIngredient(502, 8);
			recipe11.AddIngredient(174, 3);
            recipe11.AddIngredient(null, "MagmaCorn", 1);
			recipe11.AddIngredient(317, 1);
            recipe11.AddTile(TileID.Bottles);
            recipe11.SetResult(2348);
            recipe11.AddRecipe();
        }
	}
}
