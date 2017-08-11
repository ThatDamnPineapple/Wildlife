using Terraria;
using System;
using Terraria.ID;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace Wildlife.NPCs
{
    public class Turtle : ModNPC
    {
		int timer = 0;
		bool walk = false;
		int direction = 0;
		int duration = 0;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Turtle");
            Main.npcFrameCount[npc.type] = 10;
        }
        public override void SetDefaults()
        {
            npc.width = 20;
            npc.height = 10;
            npc.damage = 0;
			npc.chaseable = false;
            npc.defense = 0;
            npc.lifeMax = 5;
			Main.npcCatchable[npc.type] = true;
            npc.catchItem = (short)mod.ItemType("Turtle");
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 0f;
            npc.knockBackResist = .25f;
			banner = npc.type;
			bannerItem = mod.ItemType("TurtleBanner");
  
        }

				public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return !spawnInfo.invasion && !spawnInfo.sky && !Main.eclipse && spawnInfo.player.ZoneJungle ? 0.15f : 0f;
        }
		
        public override void FindFrame(int frameHeight)
        {
			
			if (walk)
			{
				npc.frameCounter += 0.17f;
			npc.frameCounter %= (double)10;
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
			if (npc.wet)
			{
				npc.velocity.Y = -1;
			}
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
				if (npc.velocity.X == 0)
				{
					npc.velocity.Y = -4;
				}
				
				if (direction == 0)
				{
					npc.velocity.X = -0.75f;
					npc.spriteDirection = 1;
				}
				else
				{
					npc.velocity.X = 0.75f;
					npc.spriteDirection = 0;
				}
			}
		}
		public override void HitEffect(int hitDirection, double damage)
        {
            if (npc.life <= 0)
            {
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Turtle/TurtleGore_1"), 1f);
                 Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Turtle/TurtleGore_2"), 1f);
            }
        }
    }
}
