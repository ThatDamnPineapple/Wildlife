using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System;
using System.Collections.Generic;


namespace Wildlife.Items.Potions
{
	public class BerryJuice : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mixed Berry Juice");
           Tooltip.SetDefault("Grants the effects of both Nymphberries and Strawberries");

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
            item.buffType = mod.BuffType("ForestBuff");
            item.buffTime = 8000;
           // return;
        }
        public override bool UseItem(Player player)
        {
            player.AddBuff(mod.BuffType("StrawberryBuff"), 8000);
            return true;
        }		
       
		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater, 1);
			recipe.AddIngredient(317, 1);
			recipe.AddIngredient(313, 1);
            recipe.AddIngredient(null, "Strawberry", 3);
            recipe.AddIngredient(null, "ForestBerry", 3);
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        
	}
}