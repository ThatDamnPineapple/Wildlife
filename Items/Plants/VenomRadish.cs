using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System;
using System.Collections.Generic;
namespace Wildlife.Items.Plants
{
	public class VenomRadish : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Venom Radish");
           Tooltip.SetDefault("Can be eaten with the 'quick buff' key \n'A nasty surpise...' \n'Stinks and oozes with purple bubbles'");
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
            item.buffType = mod.BuffType("Radish");
            item.buffTime = 600;         
            item.value = 5000;
            item.rare = 0;
           // return;
	}
        public override bool UseItem(Player player)
        {
            player.AddBuff(BuffID.NightOwl, 3600);
            
            return true;
		}	
	}
}
