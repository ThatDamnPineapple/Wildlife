using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System;
using System.Collections.Generic;
namespace Wildlife.Items.Plants
{
	public class Stoneberry : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Stoneberry Branch");
           Tooltip.SetDefault("Increases max health by 15 for a short time \nDecreased defense by 3 \n'Hard as rock, you have to chisel the berries off of the branch'");
        }
		 public override void SetDefaults()
        {
         
            item.UseSound = SoundID.Item2;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 30;
            item.consumable = true;
            item.width = 12;
            item.height = 12;
          
            item.value = 7500;
            item.rare = 0;
            item.buffType = mod.BuffType("StoneberryBuff");
            item.buffTime = 1400;
           // return;
		}		
	}
}
