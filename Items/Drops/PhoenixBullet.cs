using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.DataStructures;

namespace Wildlife.Items.Drops
{
public class PhoenixBullet : ModItem
{
	
    public override void SetDefaults()
    {
        item.damage = 10;
        item.ranged = true;
        item.width = 20;
        item.height = 20;
		item.shootSpeed = 5f;
		item.shoot = mod.ProjectileType("HellPhoenixProj");
        item.knockBack = 0.1f;
		item.UseSound = SoundID.Item1;
		item.scale = 1f;
        item.value = 200;
        item.rare = 3;
		item.consumable = true;
		item.maxStack = 999;
        item.ammo = AmmoID.Bullet;
	}

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Scorching Round");
      Tooltip.SetDefault("Bounces, might split into two on hit \nDoes a very small amount of knockback \nInflicts the 'On Fire' debuff");
	  Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(4, 4));
    }

		
		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "OysterBullet", 99);
            recipe.AddIngredient(null, "PhoenixAshes", 1);
            recipe.AddTile(18);
            recipe.SetResult(this, 99);
            recipe.AddRecipe();
			
            ModRecipe recipe2 = new ModRecipe(mod);
            recipe2.AddIngredient(null, "OysterPearl", 1);
            recipe2.AddIngredient(null, "PhoenixAshes", 1);
            recipe2.AddTile(18);
            recipe2.SetResult(this, 99);
            recipe2.AddRecipe();
        }
    }
}
