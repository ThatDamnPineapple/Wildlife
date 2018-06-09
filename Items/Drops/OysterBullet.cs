using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace Wildlife.Items.Drops
{
public class OysterBullet : ModItem
{
	
    public override void SetDefaults()
    {
        item.damage = 11;
        item.ranged = true;
        item.width = 22;
        item.height = 22;
		item.shootSpeed = 5f;
		item.shoot = mod.ProjectileType("OysterBulletProj");
        item.knockBack = 0f;
		item.UseSound = SoundID.Item1;
		item.scale = 1f;
        item.value = 140;
        item.rare = 1;
		item.consumable = true;
		item.maxStack = 999;
        item.ammo = AmmoID.Bullet;
	}

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Oyster Round");
      Tooltip.SetDefault("Splits into pieces on hit \nDoes not do additional knockback, unlike normal bullets");
    }

		
		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "OysterPearl", 1);
			recipe.AddIngredient(97, 333);
            recipe.AddTile(18);
            recipe.SetResult(this, 333);
            recipe.AddRecipe();
        }
    }
}
