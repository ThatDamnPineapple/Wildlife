using Terraria;
using System;
using Terraria.ID;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace Wildlife.NPCs
{
    public class SilverSparkle : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Flying Coin");
			Main.npcFrameCount[npc.type] = 4;
        }
        public override void SetDefaults()
        {
            npc.width = 32;
            npc.height = 26;
            npc.damage = 0;
			npc.chaseable = false;
            npc.defense = 0;
            npc.lifeMax = 5;
			Main.npcCatchable[npc.type] = true;
            npc.catchItem = (short)73;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 0f;
			npc.aiStyle = 64;
			//npc.alpha = 255;
				aiType = 358;
				npc.noGravity = true;
            npc.knockBackResist = .25f;
  
        }
 public override bool PreAI()
        {
			
			if(Main.rand.Next(10) == 5) {
				
						Dust.NewDust (npc.position, npc.width, npc.height, 43, Main.rand.Next(-1,2), Main.rand.Next(-1,2), 0);
					}
			return true;
		}
			public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (spawnInfo.playerSafe)
            {
                return 0f;
            }
            return SpawnCondition.Cavern.Chance * 0.0213f;
        }
		public override void FindFrame(int frameHeight)
        {
			
				npc.frameCounter += 0.17f;
			npc.frameCounter %= (double)4;
			int num = (int)npc.frameCounter;
			npc.frame.Y = num * frameHeight;
		//	npc.spriteDirection = npc.direction;
			
        }
		
        public override void AI()
		{
			Vector3 RGB = new Vector3(0.4f, 0.4f, 0f);
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
		public override void HitEffect(int hitDirection, double damage)
        {
            if (npc.life <= 0)
            {
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Coin/Coin_1"), 1f);
                 Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Coin/Coin_2"), 1f);
				  Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Coin/Coin_3"), 1f);
				   Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Coin/Coin_4"), 1f);
            }
        }
    }
}
