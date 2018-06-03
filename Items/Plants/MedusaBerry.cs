using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System;
using System.Collections.Generic;


namespace Wildlife.Items.Plants
{
	public class MedusaBerry : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Forbidden Fruit");
            Tooltip.SetDefault("Has a chance to petrify you for a short time\n'Life is given for a price'");

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
			item.healLife = 130;
            item.value = 3500;
			
            item.rare = 0;
            //item.buffTime = 150;
            return;
		}
		public override bool CanUseItem(Player player)
		{
			if (player.FindBuffIndex(BuffID.PotionSickness)>=0)
			{
				return false;
			}
			return true;
			
		}
        public override bool UseItem(Player player)
        {
            player.AddBuff(BuffID.PotionSickness, 3600);
			if (Main.rand.Next(3) == 0)
			{
            player.AddBuff(156, 450);
			}
            
            return true;
        }
        
	}
}
