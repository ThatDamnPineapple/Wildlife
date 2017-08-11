using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace Wildlife.Buffs
{
    public class FluxGlow : ModBuff
    {
        public override void SetDefaults()
        {
             DisplayName.SetDefault("Flux Glow");
            Description.SetDefault("You are glowing brightly");
       
            Main.pvpBuff[Type] = true;
            Main.buffNoTimeDisplay[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
             Vector3 RGB = new Vector3(0f,0.75f,1.5f);
			float multiplier = 1.5f;
			float max = 2.25f;
			float min = 1.0f;
			RGB *= multiplier;
			if (RGB.X > max)
			{
			multiplier = 0.5f;
			}
			if (RGB.X < min)
			{
			multiplier = 1.5f;
			}
			Lighting.AddLight(player.position,RGB.X,RGB.Y,RGB.Z);

        }
    }
}
