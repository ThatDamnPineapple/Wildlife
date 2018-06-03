using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System;
using System.Collections.Generic;


namespace Wildlife.Items.Drops
{
	public class FairyBottleP : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bottled Fairy");
            //Tooltip.SetDefault("Restores 170 life");

        }
		public override void SetDefaults()
		{
			item.UseSound = SoundID.Item3;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 20;
            item.useTime = 20;
            item.maxStack = 30;
			item.potion = true;
            item.consumable = true;
			item.healLife = 170;
            item.value = 3500;
            item.rare = 5;
            return;
		}
		public override bool CanUseItem(Player player)
		{
			if (player.FindBuffIndex(BuffID.PotionSickness)>=0)
			{
				return false;
			}
			return true;
			
		}
     /* public override bool UseItem(Player player)
        {
			player.AddBuff(BuffID.PotionSickness, 3600);
			
            
            return true;
        }*/
		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "FairyP", 1);
            recipe.AddIngredient(ItemID.Bottle, 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        
	}
}