using Terraria;
using System;
using Terraria.ID;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace Wildlife.NPCs
{
    public class Firebug : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fire Bug");
			Main.npcFrameCount[npc.type] = 3;
        }
        public override void SetDefaults()
        {
            npc.width = 14;
            npc.height = 10;
			npc.chaseable = false;
            npc.damage = 0;
            npc.defense = 0;
            npc.lifeMax = 5;
			Main.npcCatchable[npc.type] = true;
            npc.catchItem = (short)mod.ItemType("Firebug");
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 0f;
			npc.aiStyle = 64;
				aiType = 358;
				npc.noGravity = true;
            npc.knockBackResist = .50f;
			 npc.lavaImmune = true;
  
        }

		 public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return spawnInfo.player.ZoneUnderworldHeight ? 0.2f : 0f;
        }
		public override void FindFrame(int frameHeight)
        {
			
				npc.frameCounter += 0.17f;
			npc.frameCounter %= (double)3;
			int num = (int)npc.frameCounter;
			npc.frame.Y = num * frameHeight;
		//	npc.spriteDirection = npc.direction;
			
        }
		
        public override void AI()
		{
			Vector3 RGB = new Vector3(1f, 0f, 0.1f);
			npc.TargetClosest();
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
