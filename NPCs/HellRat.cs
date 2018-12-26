using Terraria;
using System;
using Terraria.ID;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace Wildlife.NPCs
{
    public class HellRat : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hellscale Rat");
			Main.npcFrameCount[npc.type] = 6;
        }
        public override void SetDefaults()
        {
            npc.width = 48;
            npc.height = 34;
			npc.chaseable = false;
            npc.damage = 0;
            npc.defense = 0;
            npc.lifeMax = 5;
			Main.npcCatchable[npc.type] = true;
            npc.catchItem = (short)mod.ItemType("Firebug");
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 0f;
			animationType = NPCID.Mouse;
			aiType = NPCID.Mouse;  
			npc.aiStyle = 7;
            npc.knockBackResist = .50f;
			npc.lavaImmune = true;
			npc.velocity = 5;
  /*
        }

		 public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return spawnInfo.player.ZoneUnderworldHeight ? 0.05f : 0f; */
        }
        public override void AI()
		{
			Vector3 RGB = new Vector3(1f, 0f, 0.1f);
			float multiplier = 0.75f;
			float max = 2.25f;
			float min = 1.0f;
			RGB *= multiplier;
			if(RGB.X > max) {
				multiplier = 0.5f;
			}
			if(RGB.X < min) {
				multiplier = 1.5f;
			}
			Lighting.AddLight(npc.position, RGB.X, RGB.Y, RGB.Z);
			
		} 
    }
}
