using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System;
using System.Collections.Generic;


namespace Wildlife.Items.Drops
{
	public class FairyBottleG : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bottled Fairy");
           Tooltip.SetDefault("Gives 5% extra damage");

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
            item.rare = 5;
            item.buffType = mod.BuffType("GreenFairy");
            item.buffTime = 15000;
           // return;
        }
		
       
		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "FairyG", 1);
            recipe.AddIngredient(ItemID.Bottle, 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        
	}
}