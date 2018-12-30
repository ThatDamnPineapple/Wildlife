using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;
using System;

namespace Wildlife.Items.Animals
{
	public class FlyingCoin : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Flying Coin");
            

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
			item.noUseGraphic = true;
			item.consumable = true;
			item.value = 500000;
			item.makeNPC = (short)mod.NPCType<SilverSparkle>();
		}
	}
}
