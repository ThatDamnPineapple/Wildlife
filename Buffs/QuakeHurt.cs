using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace Wildlife.Buffs
{
	public class QuakeHurt : ModBuff
	{
		public override void SetDefaults()
		{
			Main.buffNoTimeDisplay[Type] = false;
			DisplayName.SetDefault("Fairy Swarm");
            Description.SetDefault("Fairies appear more often in the hallow");
			Main.buffNoTimeDisplay[Type] = true;
            canBeCleared = false;
		}
	}
}