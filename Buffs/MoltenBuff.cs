using System;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace Wildlife.Buffs
{
    public class MoltenBuff : ModBuff
    {
        public override void SetDefaults()
        {
             DisplayName.SetDefault("Molten Power");
            Description.SetDefault("Set enemies Ablaze");
       
            Main.pvpBuff[Type] = true;
            Main.buffNoTimeDisplay[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
           player.magmaStone = true;
        }
    }
}
