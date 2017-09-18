using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System;
using System.Collections.Generic;
namespace Wildlife.Items.Plants
{
	public class ForestBerry : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nymph Berries");
           Tooltip.SetDefault("Increases life regeneration\n'Refreshing and renewable'");
        }
		 public override void SetDefaults()
        {
         
            item.UseSound = SoundID.Item2;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 30;
            item.maxStack = 30;
            item.consumable = true;
            item.width = 12;
            item.height = 99;
          
            item.value = 3000;
            item.rare = 0;
            item.buffType = mod.BuffType("ForestBuff");
            item.buffTime = 700;
           // return;
	}
	
	}
}
