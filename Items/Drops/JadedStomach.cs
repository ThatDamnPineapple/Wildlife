using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System;
using System.Collections.Generic;


namespace Wildlife.Items.Drops
{
	public class JadedStomach : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Jaded Stomach");
            Tooltip.SetDefault("Right Click to open");           

        }
		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 24;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.noMelee = true;
			item.useTime = 10;
			item.useStyle = 1;
			item.noUseGraphic = true;
			item.consumable = true;
			item.value = 4000;
		}
         public override bool CanRightClick() 
        {
            return true;
        }
 
        public override void RightClick(Player player)
        {
			List<int> IamLoot = new List<int>(); //possibly add dye plants and mod compat in the future, perhaps revamp this table
			IamLoot.Add(ItemID.Blinkroot);
			IamLoot.Add(mod.ItemType("Stoneberry"));
			IamLoot.Add(mod.ItemType("MagmaCorn"));
			IamLoot.Add(mod.ItemType("FluxCoral"));
			IamLoot.Add(mod.ItemType("MedusaBerry"));
			IamLoot.ToArray();
			player.QuickSpawnItem(IamLoot[Main.rand.Next(0, IamLoot.Count)], Main.rand.Next(1, 4));
			Main.PlaySound(SoundID.NPCHit9);
 			if (Main.rand.Next(2) == 0)
			{
			    Main.PlaySound(SoundID.NPCHit9);
			}	
 			if (Main.rand.Next(3) == 0)
			{
			    player.QuickSpawnItem(IamLoot[Main.rand.Next(0, IamLoot.Count)], Main.rand.Next(1, 4));
			}	
			player.QuickSpawnItem(ItemID.CopperCoin, Main.rand.Next(1, 10));  
 			if (Main.rand.Next(5) == 0)
			{
			    player.QuickSpawnItem(ItemID.SilverCoin, Main.rand.Next(1, 10));  
			}	
        }  
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Jadefish", 1);
        //    recipe.AddTile(96);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }		
	}
}
