using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System;
using System.Collections.Generic;


namespace Wildlife.Items.Plants
{
	public class MagmaCorn : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Magma Corncob");
           Tooltip.SetDefault("'Too hot to eat!'");

        }
		public override void SetDefaults()
		{
			item.width = 26;
			item.height = 22;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.value = 5000;
			item.createTile = mod.TileType("MagmaCorn");
		}
		
        
	}
}
