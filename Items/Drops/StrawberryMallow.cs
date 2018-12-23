using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System;
using System.Collections.Generic;


namespace Wildlife.Items.Drops
{
    public class StrawberryMallow : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pink Marshmallow");

        }
        public override void SetDefaults()
        {
			item.CloneDefaults(969);
        }
        public override bool UseItem(Player player)
        {
            player.AddBuff(mod.BuffType("StrawberryBuff"), 5000);
            return true;
        }	
 		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "Strawberry", 1);
			recipe.AddIngredient(969, 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }       
    }
}
