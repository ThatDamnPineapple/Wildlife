using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System;
using System.Collections.Generic;


namespace Wildlife.Items.Plants
{
	public class BambooStalk : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bamboo Stalk");
            

        }
		public override void SetDefaults()
		{
			item.width = 26;
			item.height = 22;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 500;
			item.createTile = mod.TileType("Bamboo");
		}
		
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Bamboo", 5);
            recipe.AddTile(18);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}