using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System;
using System.Collections.Generic;


namespace Wildlife.Items.Drops
{
    public class PhoenixAshes : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Phoenix Ashes");
            Tooltip.SetDefault("It faintly squawks as it singes your hand");

        }
        public override void SetDefaults()
        {
            item.useTime = 17;
            item.maxStack = 999;
            item.width = 12;
            item.height = 30;
            item.value = 5000;
            item.rare = 3;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Phoenix", 1);
        //    recipe.AddTile(96);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }		       
    }
}