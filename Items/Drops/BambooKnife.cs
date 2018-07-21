using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Wildlife.Projectiles;

namespace Wildlife.Items.Drops
{
	public class BambooKnife : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			item.damage = 7;
			item.useStyle = 1;
			item.useTime = 9;
			item.useAnimation = 9;
			item.shootSpeed = 12f;
			item.knockBack = 0.8f;
			item.width = 32;
			item.height = 32;
			item.scale = 1f;
			item.rare = 1;
			item.consumable = true;
			item.value = Item.sellPrice(copper: 3);
            item.maxStack = 999;
			item.thrown = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.autoReuse = true;
			item.UseSound = SoundID.Item1;
			item.shoot = mod.ProjectileType("BambooKnife");
		}
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Bamboo", 3);
            recipe.AddTile(18);
            recipe.SetResult(this, 99);
            recipe.AddRecipe();
        }
	}
}
