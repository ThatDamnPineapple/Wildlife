using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;
using System;

namespace Wildlife.Projectiles
{
	public class OysterBulletProj : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.width = 2;
			projectile.height = 10;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.ranged = true;
			projectile.penetrate = 1;
			projectile.light = 0.7f;
			projectile.timeLeft = 600;
			projectile.extraUpdates = 1;
			aiType = ProjectileID.Bullet;
			projectile.tileCollide = true;
		}
		
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("OysterRound");
		}
		
		public override void Kill(int timeLeft)
		{
			{
				float sX = (float)Main.rand.Next(-60, 61) * 0.1f;
				float sY = (float)Main.rand.Next(-60, 61) * 0.1f;
				int z = Projectile.NewProjectile(projectile.position.X, projectile.position.Y, sX, sY, mod.ProjectileType("OysterShard"), projectile.damage / 2, 5f, projectile.owner);
				Main.projectile[z].ranged = false;
				Main.projectile[z].thrown = true;
				int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 0);
				Main.dust[dust].scale = 1.5f;
				Main.dust[dust].noGravity = true;
			}	
		}
	}
}