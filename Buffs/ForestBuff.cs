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
    public class ForestBuff : ModBuff
    {
        public override void SetDefaults()
        {
             DisplayName.SetDefault("Taste of the Woods");
            Description.SetDefault("Slightly increased movement speed and increased regeneration");
       
            Main.pvpBuff[Type] = true;
            Main.buffNoTimeDisplay[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
			player.lifeRegen += 2;
            player.moveSpeed += 1.5f;
        }
    }
}
