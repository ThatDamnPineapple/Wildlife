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
			//-------------------------------------------------------------------------------------------------------
			//Potions
			//-------------------------------------------------------------------------------------------------------			
			
            ModRecipe recipe = new ModRecipe(this); //Wormhole
			recipe.AddIngredient(ItemID.BottledWater, 1);
            recipe.AddIngredient(null, "FluxCoral", 1);
			recipe.AddIngredient(3191, 1);
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(2997);
            recipe.AddRecipe();
			
			
            ModRecipe recipe2 = new ModRecipe(this); //Calming
			recipe2.AddIngredient(ItemID.BottledWater, 1);
            recipe2.AddIngredient(null, "CatTail", 1);
			recipe2.AddIngredient(313, 1);
            recipe2.AddTile(TileID.Bottles);
            recipe2.SetResult(2324);
            recipe2.AddRecipe();
			
			ModRecipe recipe3 = new ModRecipe(this); //Teleporation
			recipe3.AddIngredient(ItemID.BottledWater, 1);
            recipe3.AddIngredient(null, "FluxCoral", 1);
			recipe3.AddIngredient(2317, 1);
            recipe3.AddTile(TileID.Bottles);
            recipe3.SetResult(2351);
            recipe3.AddRecipe();
			
			ModRecipe recipe4 = new ModRecipe(this); //Archery
			recipe4.AddIngredient(ItemID.BottledWater, 1);
            recipe4.AddIngredient(null, "CatTail", 1);
			recipe4.AddIngredient(null, "Bamboo", 1);
            recipe4.AddTile(TileID.Bottles);
            recipe4.SetResult(303);
            recipe4.AddRecipe();
			
			ModRecipe recipe5 = new ModRecipe(this); //Lesser Healing
			recipe5.AddIngredient(ItemID.BottledWater, 1);
            recipe5.AddIngredient(null, "Strawberry", 1);
			recipe5.AddIngredient(313, 1);
            recipe5.AddTile(TileID.Bottles);
            recipe5.SetResult(28, 5);
            recipe5.AddRecipe();
			
			ModRecipe recipe6 = new ModRecipe(this); //Hunting
			recipe6.AddIngredient(ItemID.BottledWater, 1);
            recipe6.AddIngredient(null, "Jaderose", 1);
			recipe6.AddIngredient(315, 1);
            recipe6.AddTile(TileID.Bottles);
            recipe6.SetResult(304);
            recipe6.AddRecipe();
			
			ModRecipe recipe7 = new ModRecipe(this); //Warmth
			recipe7.AddIngredient(ItemID.BottledWater, 1);
            recipe7.AddIngredient(null, "FrostShine", 1);
			recipe7.AddIngredient(2358, 1);
            recipe7.AddTile(TileID.Bottles);
            recipe7.SetResult(2359);
            recipe7.AddRecipe();
			
			ModRecipe recipe8 = new ModRecipe(this); //Gills
			recipe8.AddIngredient(ItemID.BottledWater, 1);
            recipe8.AddIngredient(null, "FrostShine", 1);
			recipe8.AddIngredient(null, "CatTail", 1);
            recipe8.AddTile(TileID.Bottles);
            recipe8.SetResult(291);
            recipe8.AddRecipe();
			
			ModRecipe recipe9 = new ModRecipe(this); //Gills
			recipe9.AddIngredient(ItemID.BottledWater, 1);
            recipe9.AddIngredient(null, "Bamboo", 1);
			recipe9.AddIngredient(null, "Jaderose", 1);
            recipe9.AddTile(TileID.Bottles);
            recipe9.SetResult(291);
            recipe9.AddRecipe();
			
			ModRecipe recipe10 = new ModRecipe(this); //Obsidian Skin
			recipe10.AddIngredient(ItemID.BottledWater, 1);
            recipe10.AddIngredient(null, "MagmaCorn", 1);
			recipe10.AddIngredient(173, 1);
			recipe10.AddIngredient(317, 1);
            recipe10.AddTile(TileID.Bottles);
            recipe10.SetResult(288);
            recipe10.AddRecipe();
	    
			ModRecipe recipe11 = new ModRecipe(this); //Inferno
			recipe11.AddIngredient(ItemID.BottledWater, 1);
			recipe11.AddIngredient(317, 1);
            recipe11.AddIngredient(null, "HellRat", 1);
            recipe11.AddIngredient(null, "Phoenix", 1);
            recipe11.AddIngredient(null, "MagmaCorn", 4);
			recipe11.AddIngredient(174, 8);
            recipe11.AddTile(TileID.Bottles);
            recipe11.SetResult(2348);
            recipe11.AddRecipe();			
			
			ModRecipe recipe12 = new ModRecipe(this); //Gravity
			recipe12.AddIngredient(ItemID.BottledWater, 1);
            recipe12.AddIngredient(null, "MagmaCorn", 2);
            recipe12.AddIngredient(null, "FluxCoral", 2);
            recipe12.AddIngredient(null, "Jaderose", 1);
			recipe12.AddIngredient(331, 1);
            recipe12.AddTile(TileID.Bottles);
            recipe12.SetResult(305);
            recipe12.AddRecipe();
			
			ModRecipe recipe13 = new ModRecipe(this); //Battle
			recipe13.AddIngredient(ItemID.BottledWater, 1);
			recipe13.AddIngredient(2303, 1);
            recipe13.AddIngredient(null, "VenomRadish", 1);
            recipe13.AddTile(TileID.Bottles);
            recipe13.SetResult(300);
            recipe13.AddRecipe();
			
			ModRecipe recipe14 = new ModRecipe(this); //Stink
			recipe14.AddIngredient(ItemID.BottledWater, 1);
            recipe14.AddIngredient(null, "CatTail", 1);
            recipe14.AddIngredient(null, "VenomRadish", 1);
            recipe14.AddTile(TileID.Bottles);
            recipe14.SetResult(2353);
            recipe14.AddRecipe();
			
			ModRecipe recipe15 = new ModRecipe(this); //Venom Vial
			recipe15.AddIngredient(2607, 3);
            recipe15.AddIngredient(null, "VenomRadish", 1);
            recipe15.AddTile(TileID.Bottles);
            recipe15.SetResult(1339);
            recipe15.AddRecipe();
			
			//-------------------------------------------------------------------------------------------------------
			//Cages
			//-------------------------------------------------------------------------------------------------------
			
            ModRecipe cage1 = new ModRecipe(this); //Cage (dragonfly)
			cage1.AddIngredient(ItemID.Bottle, 1);
            cage1.AddIngredient(null, "Dragonfly", 1);
            cage1.SetResult(null, "DragonflyCageItem", 1);
            cage1.AddRecipe();
			
			ModRecipe cage2 = new ModRecipe(this); //Cage (infernal mosquito)
			cage2.AddIngredient(ItemID.Bottle, 1);
            cage2.AddIngredient(null, "Firebug", 1);
            cage2.SetResult(null, "HellbugCageItem", 1);
            cage2.AddRecipe();
			
			ModRecipe cage3 = new ModRecipe(this); //Cage (supercharged orb)
			cage3.AddIngredient(ItemID.Bottle, 1);
            cage3.AddIngredient(null, "GraniteOrb", 1);
            cage3.SetResult(null, "OrbCageItem", 1);
            cage3.AddRecipe();
        }
	}
}
