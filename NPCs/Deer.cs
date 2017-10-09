using Terraria;
using System;
using Terraria.ID;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace Wildlife.NPCs
{
    public class Deer : ModNPC
    {
		bool run = false;
		int timer = 0;
		bool walk = false;
		int direction = 0;
		int duration = 0;
		bool jump = false;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Deer");
            Main.npcFrameCount[npc.type] = 7;
        }
        public override void SetDefaults()
        {
            npc.width = 68;
            npc.height = 72;
            npc.damage = 0;
			npc.chaseable = false;
            npc.defense = 0;
            npc.lifeMax = 40;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 0f;
            npc.knockBackResist = .25f;
			banner = npc.type;
			bannerItem = mod.ItemType("DeerBanner");
  
        }

				public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return spawnInfo.spawnTileY < Main.rockLayer && Main.dayTime && !spawnInfo.invasion && !spawnInfo.sky && !Main.eclipse && !spawnInfo.player.ZoneDesert && !spawnInfo.player.ZoneJungle ? 0.06f : 0f;
        }
		
        public override void FindFrame(int frameHeight)
        {
			if (run)
			{
            npc.frameCounter += 0.3;
			npc.frameCounter %= (double)5;
			int num = (int)npc.frameCounter + 1;
			npc.frame.Y = num * frameHeight;
			//npc.spriteDirection = npc.direction;
			}
			else
			{
				npc.frame.Y = 0;
			}
			if (walk && !run)
			{
				npc.frameCounter += 0.17f;
			npc.frameCounter %= (double)5;
			int num = (int)npc.frameCounter + 1;
			npc.frame.Y = num * frameHeight;
		//	npc.spriteDirection = npc.direction;
			}
        }
        public override void AI()
		{
			npc.netUpdate = true;
			if (npc.collideY)
			{
				jump = false;
				npc.netUpdate = true;
			}
			if (npc.velocity.Y < 5)
			{
				npc.velocity.Y += 0.1f;
				npc.netUpdate = true;
			}
			
			npc.TargetClosest(true);
            Player player = Main.player[npc.target];
			if (Math.Abs(player.Center.X - npc.Center.X) < 120)
			{
				//run away
				run = true;
				npc.netUpdate = true;
			}
			
			
			
			if (run)
			{
				npc.netUpdate = true;
				if (npc.velocity.X == 0 && npc.velocity.Y >= 0 && !jump)
				{
					npc.velocity.Y = -6;
					jump = true;
					npc.netUpdate = true;
				}
				if (Math.Abs(player.Center.X - npc.Center.X) > 950)
				{
					npc.life = 0;
					npc.netUpdate = true;
				}
				if (player.position.X > npc.position.X)
				{
					npc.velocity.X = -7;
					npc.spriteDirection = 1;
					npc.netUpdate = true;
				}
				else
				{
					npc.velocity.X = 7;
					npc.spriteDirection = 0;
					npc.netUpdate = true;
				}
				
			}
			else
			{
				npc.netUpdate = true;
				timer++;
				if (timer % 500 == 499)
				{
					npc.netUpdate = true;
					direction = Main.rand.Next(2);
					duration = Main.rand.Next(80,450);
					npc.netUpdate = true;
				
				}
				if (timer % 500 > 0 && timer % 500 < duration)
				{
					walk = true;
					npc.netUpdate = true;
				}
				else
				{
				walk = false;
				npc.netUpdate = true;
				
				if (direction == 0)
				{
					npc.spriteDirection = 1;
				}
				else
				{
					
					npc.spriteDirection = 0;
				}
				
				}
			}
			
			if (walk && !run)
			{
				npc.netUpdate = true;
				if (Math.Abs(npc.velocity.X) <= 0.25f && npc.velocity.Y >= 0.3f && !jump)
				{
					npc.velocity.Y = -6;
					jump = true;
					npc.netUpdate = true;
				}
				
				if (direction == 0)
				{
					npc.velocity.X = -2f;
					npc.spriteDirection = 1;
					npc.netUpdate = true;
				}
				else
				{
					npc.velocity.X = 2f;
					npc.spriteDirection = 0;
					npc.netUpdate = true;
				}
			}
		}
		public override void NPCLoot()
        {
            if (Main.rand.Next(30) == 0)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("DeerBlood"));
            }
        }
		public override void HitEffect(int hitDirection, double damage)
        {
            if (npc.life <= 0)
            {
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Deer/DeerGore_1"), 1f);
                 Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Deer/DeerGore_2"), 1f);
				 Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Deer/DeerGore_3"), 1f);
            }
        }
    }
}
