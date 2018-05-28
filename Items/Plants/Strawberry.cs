using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System;
using System.Collections.Generic;
namespace Wildlife.Items.Plants
{
	public class Strawberry : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Strawberry");
           Tooltip.SetDefault("Increases movement speed\n'Simply Delicious'");
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
          
            item.value = 2500;
            item.rare = 0;
            item.buffType = mod.BuffType("StrawberryBuff");
            item.buffTime = 700;
           // return;
	}
	
	}
}
