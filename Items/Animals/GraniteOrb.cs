using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System;
using System.Collections.Generic;


namespace Wildlife.Items.Animals
{
	public class GraniteOrb : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Supercharged Orb");
            Tooltip.SetDefault("'Despite its tiny size, it lures like an anglerfish...'");         

        }
		public override void SetDefaults()
		{
			item.width = 26;
			item.height = 22;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.noMelee = true;
			item.useTime = 10;
			item.useStyle = 1;
			item.bait = 40;
			item.noUseGraphic = true;
			item.consumable = true;
			item.value = 1500;
		}
		  public override bool UseItem(Player player)
        {
            NPC.NewNPC((int)player.Center.X, (int)player.Center.Y, mod.NPCType("GraniteOrb"));
            return true;
        }
        
	}
}
