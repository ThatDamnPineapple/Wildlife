﻿using System;

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace Wildlife.Buffs
{
    public class PrismaticBuff : ModBuff
    {
        public override void SetDefaults()
        {
             DisplayName.SetDefault("Prismatic Mana");
            Description.SetDefault("Maximum mana increased");
       
            Main.pvpBuff[Type] = true;
            Main.buffNoTimeDisplay[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.statManaMax2 += 40;

        }
    }
}
