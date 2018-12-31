using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System;
using System.Collections.Generic;


namespace Wildlife.Items.Animals
{
	public class Termite : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Living Wood Mite");
            

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
			item.bait = 30;
			item.noUseGraphic = true;
			item.consumable = true;
			item.value = 800;
			item.makeNPC = (short)mod.NPCType<NPCs.Termite>();
		}
        
	}
}
