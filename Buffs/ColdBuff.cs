using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Wildlife.Buffs
{
    public class ColdBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Frozen Feet");
            Description.SetDefault("Decreased movement speed");
            Main.buffNoTimeDisplay[Type] = false;
			Main.debuff[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.moveSpeed -= 0.7f;
        }
    }
}
