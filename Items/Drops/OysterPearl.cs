using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System;
using System.Collections.Generic;


namespace Wildlife.Items.Drops
{
    public class OysterPearl : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Oyster Pearl");
            Tooltip.SetDefault("");

        }
        public override void SetDefaults()
        {
            item.useTime = 17;
            item.maxStack = 999;
            item.width = 12;
            item.height = 30;
            item.value = 100;
            item.rare = 1;
        }
        
    }
}