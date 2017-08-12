using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System;
using System.Collections.Generic;


namespace Wildlife.Items.Drops
{
    public class BambooArrow : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bamboo Arrow");

        }
        public override void SetDefaults()
		{
			
			item.width = 10;
			item.height = 28;
            item.value = 10;
            item.rare = 1;

            item.maxStack = 999;

            item.damage = 7;
			item.knockBack = 2f;
            item.ammo = AmmoID.Arrow;

            item.ranged = true;
            item.consumable = true;

            item.shoot = mod.ProjectileType("BambooArrow");
            item.shootSpeed = 2.5f;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Bamboo", 1);
                      recipe.AddTile(18);
            recipe.SetResult(this, 30);
            recipe.AddRecipe();
        }
    }
}
