using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System;
using System.Collections.Generic;


namespace Wildlife.Items.Drops
{
	public class FairyBottleB : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bottled Fairy");
           // Tooltip.SetDefault("Restores 160 mana");

        }
		public override void SetDefaults()
		{
			item.UseSound = SoundID.Item3;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 20;
            item.useTime = 20;
            item.maxStack = 30;
			//item.potion = true;
			item.healMana = 160;
            item.consumable = true;
            item.value = 3500;
            item.rare = 5;
            return;
		}
		
        public override bool UseItem(Player player)
        {
        //    player.statMana += 160;
			player.AddBuff(BuffID.ManaSickness, 2000);
			
            
            return true;
        }
		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "FairyB", 1);
            recipe.AddIngredient(ItemID.Bottle, 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        
	}
}