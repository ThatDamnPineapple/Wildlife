using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System;
using System.Collections.Generic;


namespace Wildlife.Items.Potions
{
	public class FluxglowPotion : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fluxglow Potion");
           Tooltip.SetDefault("Gives off a high amount of light");

        }
		 public override void SetDefaults()
        {
         
            item.UseSound = SoundID.Item3;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 30;
            item.consumable = true;
            item.width = 12;
            item.height = 30;
          
            item.value = 2500;
            item.rare = 1;
            item.buffType = mod.BuffType("FluxGlow");
            item.buffTime = 20000;
           // return;
        }
		
       
		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(298, 1);
            recipe.AddIngredient(null, "FluxCoral", 2);
            recipe.AddIngredient(null, "FrostShine", 1);
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        
	}
}