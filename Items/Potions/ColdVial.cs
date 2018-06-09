using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System;
using System.Collections.Generic;


namespace Wildlife.Items.Potions
{
	public class ColdVial : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Frostblood Draught");
            Tooltip.SetDefault("Slows you down significantly");

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
			item.healLife = 130;
            item.buffType = mod.BuffType("ColdBuff");
            item.buffTime = 4500;
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
        public override bool UseItem(Player player)
        {
            player.AddBuff(BuffID.PotionSickness, 3600);
            
            return true;
		}
		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater, 1);
			recipe.AddIngredient(null, "FrostShine", 2);
			recipe.AddIngredient(null, "MedusaBerry", 1);
			recipe.AddIngredient(null, "Strawberry", 1);
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }			
	}
}
