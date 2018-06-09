using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Wildlife.Projectiles;

namespace Wildlife.Items.Drops
{
	public class BambooSpear : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Bamboo Spear");
		}

		public override void SetDefaults()
		{
			item.damage = 13;
			item.useStyle = 5;
			item.useAnimation = 18;
			item.useTime = 24;
			item.shootSpeed = 3.7f;
			item.knockBack = 1.2f;
			item.width = 32;
			item.height = 32;
			item.scale = 1f;
			item.rare = 1;
			item.value = Item.sellPrice(silver: 10);

			item.melee = true;
			item.noMelee = true; 
			item.noUseGraphic = true; 
			item.autoReuse = true; 

			item.UseSound = SoundID.Item1;
			item.shoot = mod.ProjectileType<BambooSpearProj>();
		}

		public override bool CanUseItem(Player player)
		{
			return player.ownedProjectileCounts[item.shoot] < 1; 
		}
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Bamboo", 8);
            recipe.AddTile(18);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
	}
}
