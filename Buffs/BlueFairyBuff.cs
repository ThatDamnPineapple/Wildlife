using System;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace Wildlife.Buffs
{
    public class BlueFairyBuff : ModBuff
    {
        public override void SetDefaults()
        {
             DisplayName.SetDefault("Fairy's Knowledge");
            Description.SetDefault("10% Reduced Mana Cost");
       
            Main.pvpBuff[Type] = true;
            Main.buffNoTimeDisplay[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.manaCost -= 0.10f;
			
        }
    }
}
