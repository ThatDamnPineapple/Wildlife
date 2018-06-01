using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System;
using System.Collections.Generic;


namespace Wildlife.Items.Potions
{
	public class MoltenPotion : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Molten Potion");
           Tooltip.SetDefault("Attacks set enemies on fire");

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
            item.buffType = mod.BuffType("MoltenBuff");
            item.buffTime = 15000;
           // return;
        }
		
       
		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater, 1);
            recipe.AddIngredient(null, "Firebug", 1);
            recipe.AddIngredient(null, "MagmaCorn", 1);
			recipe.AddIngredient(318, 1);
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        
	}
}
