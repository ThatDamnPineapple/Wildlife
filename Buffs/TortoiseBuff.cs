using System;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace Wildlife.Buffs
{
    public class TortoiseBuff : ModBuff
    {
        public override void SetDefaults()
        {
             DisplayName.SetDefault("Tortoise protection");
            Description.SetDefault("Increases defense with lower health");
       
            Main.pvpBuff[Type] = true;
            Main.buffNoTimeDisplay[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
           float defBoost = (float)(player.statLifeMax2 - player.statLife) / (float)player.statLifeMax2 * 22f;
			player.statDefense += (int)defBoost;

        }
    }
}
