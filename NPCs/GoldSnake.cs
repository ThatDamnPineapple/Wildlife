using Terraria;
using System;
using Terraria.ID;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;
using Terraria.GameContent.Events;

namespace Wildlife.NPCs
{
    public class GoldSnake : ModNPC
    {
		//npc.ai[0] = 0;
		bool walk = false;
		//npc.ai[1] = 0;
		//npc.ai[2] = 0;
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
			npc.friendly = true;  
        }
		public override bool? CanBeHitByItem(Player player, Item item) {

			return true;

		}
		public override bool? CanBeHitByProjectile(Projectile projectile) {

			return true;

		}
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
			if (SpawnCondition.Cavern.Chance != 0)
			{
				return 0.0f;
			}
            return spawnInfo.player.ZoneOverworldHeight && !spawnInfo.invasion && !spawnInfo.sky && !Main.eclipse && spawnInfo.player.ZoneDesert && !Sandstorm.Happening ? 0.01f : 0f;
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
		//	npc.spriteDirection = npc.npc.ai[1];
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
			
			
			
			
			
			
			
				npc.ai[0]++;
				if (npc.ai[0] % 700 == 599)
				{
					npc.ai[1] = Main.rand.Next(2);
					npc.ai[2] = Main.rand.Next(80,450);
				}
				if (npc.ai[0] % 700 > 0 && npc.ai[0] % 700 < npc.ai[2])
				{
					walk = true;
				}
				else
				{
				walk = false;
				
				if (npc.ai[1] == 0)
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
				
				if (npc.ai[1] == 0)
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
