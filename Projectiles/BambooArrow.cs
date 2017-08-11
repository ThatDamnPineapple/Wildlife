using System;

using Microsoft.Xna.Framework;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Wildlife.Projectiles
{
    class BambooArrow : ModProjectile
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Beetle Arrow");
        }
        public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.WoodenArrowFriendly);
			projectile.penetrate = 2;
		}

		
    }
}
