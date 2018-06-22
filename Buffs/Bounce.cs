using System;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace Wildlife.Buffs
{
    public class Bounce : ModBuff
    {
        public override void SetDefaults()
        {
             DisplayName.SetDefault("Steelfall");
            Description.SetDefault("You don't take fall damage");
       
            Main.pvpBuff[Type] = true;
            Main.buffNoTimeDisplay[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
           player.noFallDmg = true;

        }
    }
}
