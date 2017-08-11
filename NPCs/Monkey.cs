using Terraria;
using System;
using Terraria.ID;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace Wildlife.NPCs
{
    public class Monkey : ModNPC
    {
		int timer = 0;
		bool walk = false;
		int direction = 0;
		int duration = 0;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Monkey");
            Main.npcFrameCount[npc.type] = 11;
        }
        public override void SetDefaults()
        {
            npc.width = 38;
            npc.height = 38;
            npc.damage = 0;
			npc.chaseable = false;
            npc.defense = 0;
			Main.npcCatchable[npc.type] = true;
            npc.catchItem = (short)mod.ItemType("Monkey");
            npc.lifeMax = 5;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 0f;
            npc.knockBackResist = .25f;
			banner = npc.type;
			bannerItem = mod.ItemType("MonkeyBanner");
  
        }

				public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return !spawnInfo.invasion && !spawnInfo.sky && !Main.eclipse && spawnInfo.player.ZoneJungle ? 0.15f : 0f;
        }
		
        public override void FindFrame(int frameHeight)
        {
			
			if (walk)
			{
				if (npc.velocity.Y < 0)
				{
						npc.frameCounter += 0.17f;
			npc.frameCounter %= (double)5;
			int num = (int)npc.frameCounter + 6;
			npc.frame.Y = num * frameHeight;
				}
				else
				{
				npc.frameCounter += 0.17f;
			npc.frameCounter %= (double)6;
			int num = (int)npc.frameCounter;
			npc.frame.Y = num * frameHeight;
		//	npc.spriteDirection = npc.direction;
				}
			}
			else
			{
				npc.frame.Y = 0;
			}
        }
        public override void AI()
		{
			if (npc.velocity.Y < 3)
			{
				npc.velocity.Y += 0.1f;
			}
			
			npc.TargetClosest(true);
            Player player = Main.player[npc.target];
			
			
			
			
			
			
			
				timer++;
				if (timer % 500 == 499)
				{
					direction = Main.rand.Next(2);
					duration = Main.rand.Next(80,450);
				}
				if (timer % 500 > 0 && timer % 500 < duration)
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
				if (npc.velocity.X == 0)
				{
					npc.velocity.Y = -4;
				}
				
				if (direction == 0)
				{
					npc.velocity.X = -3f;
					npc.spriteDirection = 1;
				}
				else
				{
					npc.velocity.X = 3f;
					npc.spriteDirection = 0;
				}
			}
		}
		public override void HitEffect(int hitDirection, double damage)
        {
            if (npc.life <= 0)
            {
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Monkey/MonkeyGore_1"), 1f);
                 Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Monkey/MonkeyGore_2"), 1f);
            }
        }
    }
}
