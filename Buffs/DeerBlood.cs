using System;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace Wildlife.Buffs
{
    public class DeerBlood : ModBuff
    {
        public override void SetDefaults()
        {
             DisplayName.SetDefault("Deer Blood");
            Description.SetDefault("Increases damage by 5%");
       
            Main.pvpBuff[Type] = true;
            Main.buffNoTimeDisplay[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.magicDamage *= 1.05f;
            player.meleeDamage *= 1.05f;
            player.rangedDamage *= 1.05f;
            player.minionDamage *= 1.05f;
            player.thrownDamage *= 1.05f;

        }
    }
}
