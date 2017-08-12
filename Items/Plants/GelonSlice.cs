using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System;
using System.Collections.Generic;
namespace Wildlife.Items.Plants
{
	public class GelonSlice : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gelon Slice");
           Tooltip.SetDefault("'Sweet 'n' slimy'");
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
            item.height = 99;
          
            item.value = 5500;
            item.rare = 1;
            item.buffType = item.BuffType("137");
            item.buffTime = 5000;
           // return;
	}
	
	}
}
