using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System;
using System.Collections.Generic;


namespace Wildlife.Items.Animals
{
	public class Jadefish : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Jadefish");
            

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
			item.value = 5000;
		}
		  public override bool UseItem(Player player)
        {
            NPC.NewNPC((int)player.Center.X, (int)player.Center.Y, mod.NPCType("Jadefish"));
            return true;
        }
        
	}
}
