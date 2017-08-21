using Terraria;
using System;
using Terraria.ID;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace Wildlife.NPCs
{
    public class Turkey : ModNPC
    {
		int timer = 0;
		bool walk = false;
		int direction = 0;
		int duration = 0;
		bool jump = false;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Turkey");
            Main.npcFrameCount[npc.type] = 5;
        }
        public override void SetDefaults()
        {
            npc.width = 46;
            npc.height = 38;
            npc.damage = 0;
			npc.chaseable = false;
            npc.defense = 0;
            npc.lifeMax = 10;
			Main.npcCatchable[npc.type] = true;
            npc.catchItem = (short)mod.ItemType("Turkey");
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 0f;
            npc.knockBackResist = .25f;
			banner = npc.type;
			bannerItem = mod.ItemType("TurkeyBanner");
  
        }

				public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return spawnInfo.spawnTileY < Main.rockLayer && !spawnInfo.invasion && !spawnInfo.sky && !Main.eclipse && !spawnInfo.player.ZoneDesert && !spawnInfo.player.ZoneJungle ? 0.08f : 0f;
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
			npc.frameCounter %= (double)4;
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
					npc.spriteDirection = 1;
				}
				else
				{
					
					npc.spriteDirection = 0;
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
					npc.spriteDirection = 1;
				}
				else
				{
					npc.velocity.X = 1.5f;
					npc.spriteDirection = 0;
				}
			}
		}
		public override void HitEffect(int hitDirection, double damage)
        {
            if (npc.life <= 0)
            {
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Turkey/TurkeyGore_1"), 1f);
                 Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Turkey/TurkeyGore_2"), 1f);
				  Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Turkey/TurkeyGore_3"), 1f);
            }
        }
    }
}
