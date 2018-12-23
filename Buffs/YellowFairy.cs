using System;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace Wildlife.Buffs
{
    public class YellowFairy : ModBuff
    {
        public override void SetDefaults()
        {
             DisplayName.SetDefault("Fairy's Shield");
            Description.SetDefault("Increased defense by 4");
       
            Main.pvpBuff[Type] = true;
            Main.buffNoTimeDisplay[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
			player.statDefense += 4;
        }
    }
}
