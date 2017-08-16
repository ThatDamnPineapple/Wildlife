using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System;
using System.Collections.Generic;


namespace Wildlife.Items.Drops
{
    public class DeerBlood : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Deer Blood");
            Tooltip.SetDefault("Increases damage by 5%\n'You are horrible'");

        }
        public override void SetDefaults()
        {
          //  item.name = "Deer Blood";
            item.UseSound = SoundID.Item3;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 30;
            item.consumable = true;
            item.width = 12;
            item.height = 30;
          //  item.toolTip = "Increases critical strike damage";
            item.value = 3000;
            item.rare = 1;
            item.buffType = mod.BuffType("DeerBlood");
            item.buffTime = 5000;
           // return;
        }
        
    }
}