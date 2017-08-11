using Terraria;
using System;
using Terraria.ID;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace Wildlife.NPCs
{
    public class GoldSnake : ModNPC
    {
		int timer = 0;
		bool walk = false;
		int direction = 0;
		int duration = 0;
		bool jump = false;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gold Snake");
            Main.npcFrameCount[npc.type] = 8;
        }
        public override void SetDefaults()
        {
            npc.width = 40;
            npc.height = 20;
            npc.damage = 0;
            npc.defense = 0;
            npc.lifeMax = 10;
			npc.chaseable = false;
			Main.npcCatchable[npc.type] = true;
            npc.catchItem = (short)mod.ItemType("GoldSnake");
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 0f;
            npc.knockBackResist = .25f;
			banner = npc.type;
			bannerItem = mod.ItemType("SnakeBanner");
  
        }

				public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return !spawnInfo.invasion && !spawnInfo.sky && !Main.eclipse && spawnInfo.player.ZoneDesert ? 0.01f : 0f;
        }
		
        public override void FindFrame(int frameHeight)
        {
			if (npc.collideY)
			{
				jump = false;
			}
			
			if (walk)
			{
				npc.frameCounter += 0.17f;
			npc.frameCounter %= (double)8;
			int num = (int)npc.frameCounter;
			npc.frame.Y = num * frameHeight;
		//	npc.spriteDirection = npc.direction;
			}
			else
			{
				npc.frame.Y = 0;
			}
        }
        public override void AI()
		{
			/*if (npc.wet)
			{
				npc.velocity.Y = -1;
			}*/
			if (npc.velocity.Y < 3)
			{
				npc.velocity.Y += 0.1f;
			}
			
			npc.TargetClosest(true);
            Player player = Main.player[npc.target];
			
			
			
			
			
			
			
				timer++;
				if (timer % 700 == 599)
				{
					direction = Main.rand.Next(2);
					duration = Main.rand.Next(80,450);
				}
				if (timer % 700 > 0 && timer % 700 < duration)
				{
					walk = true;
				}
				else
				{
				walk = false;
				
				if (direction == 0)
				{
					npc.spriteDirection = 0;
				}
				else
				{
					
					npc.spriteDirection = 1;
				}
				
				}
			
			if (walk)
			{
				if (Math.Abs(npc.velocity.X) <= 0.25f && npc.velocity.Y >= 0 && !jump)
				{
					npc.velocity.Y = -4;
					jump = true;
				}
				
				if (direction == 0)
				{
					npc.velocity.X = -1.5f;
					npc.spriteDirection = 0;
				}
				else
				{
					npc.velocity.X = 1.5f;
					npc.spriteDirection = 1;
				}
			}
			if(Main.rand.Next(20) == 5) {
				
						Dust.NewDust (npc.position, npc.width, npc.height, 43, Main.rand.Next(-1,2), Main.rand.Next(-1,2), 0);
					}
		}
		public override void HitEffect(int hitDirection, double damage)
        {
            if (npc.life <= 0)
            {
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Snake/SnakeGore_1"), 1f);
                 Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Snake/SnakeGore_2"), 1f);
            }
        }
    }
}
