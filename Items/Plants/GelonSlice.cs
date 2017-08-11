using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System;
using System.Collections.Generic;


namespace Wildlife.Items.Plants
{
	public class GelonSlice : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gelon Slice");
            //Tooltip.SetDefault("Restores 30 life");

        }
		public override void SetDefaults()
		{
			item.UseSound = SoundID.Item3;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 20;
            item.useTime = 20;
            item.maxStack = 30;
           item.potion = true;
            item.consumable = true;
			item.healLife = 60;
            item.value = 5500;
			
            item.rare = 2;
            return;
		}
		/*public override bool CanUseItem(Player player)
		{
			if (player.FindBuffIndex(BuffID.PotionSickness)>=0)
			{
				return false;
			}
			return true;
			
		}*/
        public override bool UseItem(Player player)
        {
          
			player.AddBuff(BuffID.PotionSickness, 3600);
			
            
            return true;
        }
        
	}
}