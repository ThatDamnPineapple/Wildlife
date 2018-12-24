using System;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace Wildlife.Buffs
{
    public class StoneberryBuff : ModBuff
    {
        public override void SetDefaults()
        {
             DisplayName.SetDefault("Crunch");
            Description.SetDefault("The teeth you just swallowed empower you");
       
            Main.pvpBuff[Type] = true;
            Main.buffNoTimeDisplay[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.statLifeMax2 += 15;
			player.statDefense -= 3;			
        }
    }
}
