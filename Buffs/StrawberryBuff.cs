using System;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace Wildlife.Buffs
{
    public class StrawberryBuff : ModBuff
    {
        public override void SetDefaults()
        {
             DisplayName.SetDefault("Sweet Adrenaline");
            Description.SetDefault("Increasess movement speed");
       
            Main.pvpBuff[Type] = true;
            Main.buffNoTimeDisplay[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.moveSpeed += 6.50f;
			
        }
    }
}
