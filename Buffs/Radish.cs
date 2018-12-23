using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Wildlife.Buffs
{
	public class Radish : ModBuff
	{
		public override void SetDefaults()
		{
			Main.buffNoTimeDisplay[Type] = false;
			DisplayName.SetDefault("Radish Venom");
            Description.SetDefault("Spicier than a normal radish, huh?");
            Main.pvpBuff[Type] = true;
		}
		public override void Update(Player player, ref int buffIndex)
		{
			player.lifeRegen -= 10;
		}
	}
}