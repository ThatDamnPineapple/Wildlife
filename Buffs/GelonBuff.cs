using System;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace Wildlife.Buffs
{
    public class GelonBuff : ModBuff
    {
        public override void SetDefaults()
        {
             DisplayName.SetDefault("Gelatinous");
            Description.SetDefault("Increased minion slots by 1");
       
            Main.pvpBuff[Type] = true;
            Main.buffNoTimeDisplay[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.maxMinions++;
			
        }
    }
}
