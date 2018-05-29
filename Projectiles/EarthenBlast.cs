using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;
using System;

namespace Wildlife.Projectiles
{
	public class EarthenBlast : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.width = 13;
			projectile.height = 13;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.ranged = true;
			projectile.penetrate = 1;
			projectile.light = 0.7f;
			projectile.timeLeft = 600;
			projectile.extraUpdates = 1;
			aiType = ProjectileID.Bullet;
			projectile.tileCollide = true;
            projectile.damage = 6;
		}
		
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Earthen Blast");
		}
		
		public override void Kill(int timeLeft)
		{
			{
				float sX = (float)Main.rand.Next(-60, 61) * 0.1f;
				float sY = (float)Main.rand.Next(-60, 61) * 0.1f;
			    Vector2 vector2 = new Vector2(projectile.width/2, projectile.height/2);
			    int dust;
			    dust = Dust.NewDust(projectile.position + vector2, 0, 0, mod.DustType("EarthDust"));
			    dust = Dust.NewDust(projectile.position + vector2, 0, 0, mod.DustType("EarthDust"));
			    dust = Dust.NewDust(projectile.position + vector2, 0, 0, mod.DustType("EarthDust"));
			    dust = Dust.NewDust(projectile.position + vector2, 0, 0, mod.DustType("EarthDust"));
			    dust = Dust.NewDust(projectile.position + vector2, 0, 0, mod.DustType("EarthDust"));
			}	
		}
	}
}