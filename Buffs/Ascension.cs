using System;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace Wildlife.Buffs
{
    public class Ascension : ModBuff
    {
        public override void SetDefaults()
        {
             DisplayName.SetDefault("Ascension");
            Description.SetDefault("Increased Wing Flight Time");
       
            Main.pvpBuff[Type] = true;
            Main.buffNoTimeDisplay[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.wingTime += 40f;
			
        }
    }
}
