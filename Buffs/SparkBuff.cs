using System;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace Wildlife.Buffs
{
    public class SparkBuff : ModBuff
    {
        public override void SetDefaults()
        {
             DisplayName.SetDefault("Spark");
            Description.SetDefault("Increases damage based on speed");
       
            Main.pvpBuff[Type] = true;
            Main.buffNoTimeDisplay[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.magicDamage += (float)(Math.Abs(player.velocity.X) / 150);
            player.meleeDamage += (float)(Math.Abs(player.velocity.X) / 150);
            player.rangedDamage += (float)(Math.Abs(player.velocity.X) / 150);
            player.minionDamage += (float)(Math.Abs(player.velocity.X) / 150);
            player.thrownDamage += (float)(Math.Abs(player.velocity.X) / 150);

        }
    }
}
