using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;
using System;

namespace Wildlife.Projectiles
{
	public class HellPhoenixProj : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.width = 10;
			projectile.height = 10;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.ranged = true;
			projectile.penetrate = 1;
			projectile.light = 0.7f;
			projectile.timeLeft = 600;
			projectile.extraUpdates = 1;
			aiType = ProjectileID.Bat;
			projectile.tileCollide = true;
            Main.projFrames[projectile.type] = 4;
		}
		
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Scorching Phoenix");
			ProjectileID.Sets.Homing[projectile.type] = true;
		}
		public override void AI()
		{		
			Vector3 RGB = new Vector3(2.5f, 1.5f, 1.0f);
			float multiplier = 0.75f;
			float max = 2.25f;
			float min = 1.0f;
			RGB *= multiplier;
			if(RGB.X > max) {
				multiplier = 0.5f;
			}
			if(RGB.X < min) {
				multiplier = 1.5f;
			}
			Lighting.AddLight(projectile.position, RGB.X, RGB.Y, RGB.Z);
			
            if (Main.rand.Next(8) == 0)
            {
			Dust.NewDust(projectile.position, projectile.width, projectile.height, 174);
			Dust.NewDust(projectile.position, projectile.width, projectile.height, 174);
			Dust.NewDust(projectile.position, projectile.width, projectile.height, 174);
			}
            projectile.rotation = projectile.velocity.ToRotation() + MathHelper.ToRadians(90f);  
            projectile.spriteDirection = projectile.direction;
		}
		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(BuffID.OnFire, 300, false);
			Dust.NewDust(projectile.position, projectile.width, projectile.height, 174);
			Dust.NewDust(projectile.position, projectile.width, projectile.height, 174);
		}
		public override void Kill(int timeLeft)
		{
			{
                if (Main.rand.Next(3) == 0)
                {
				float sX = (float)Main.rand.Next(-60, 61) * 0.1f;
				float sY = (float)Main.rand.Next(-60, 61) * 0.1f;
				int z = Projectile.NewProjectile(projectile.position.X, projectile.position.Y, sX, sY, mod.ProjectileType("HellPhoenixProj"), projectile.damage / 2, 5f, projectile.owner);
			    int r = Projectile.NewProjectile(projectile.position.X, projectile.position.Y, sX, sY, mod.ProjectileType("HellPhoenixProj"), projectile.damage / 2, 5f, projectile.owner);		
				Main.projectile[z].ranged = true;
				Main.projectile[r].ranged = true;
			    Dust.NewDust(projectile.position, projectile.width, projectile.height, 174);
				Main.PlaySound(SoundID.Item4, projectile.position);
				}
			    Dust.NewDust(projectile.position, projectile.width, projectile.height, 174);
			    Dust.NewDust(projectile.position, projectile.width, projectile.height, 174);
			    Dust.NewDust(projectile.position, projectile.width, projectile.height, 174);
			}	
		}
	}
}