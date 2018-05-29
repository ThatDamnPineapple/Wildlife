using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader.IO;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using Terraria;

namespace Wildlife
{
	public class WildlifePlayer : ModPlayer
	{
		public bool Quake;
		
		public override void ResetEffects()
		{
			Quake = false;
        }
		public override void OnHitNPC(Item item, NPC target, int damage, float knockback, bool crit)
		{
				if (Quake == true)
                {
					target.AddBuff(mod.BuffType("QuakeHurt"), 12, false);
                }
		}
		
		public override void OnHitNPCWithProj(Projectile projectile, NPC target, int damage, float knockBack, bool Crit)
		{
				if (Quake == true)
                {
					target.AddBuff(mod.BuffType("QuakeHurt"), 12, false);
				}
     		}
		}
	}
