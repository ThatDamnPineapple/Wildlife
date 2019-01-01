using Terraria;
using System;
using Terraria.ID;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace Wildlife.NPCs
{
    public class GoldTurtle : ModNPC
    {
		//npc.ai[0] = 0;
		bool walk = false;
		//npc.ai[1] = 0;
		//npc.ai[2] = 0;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gold Turtle");
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
            npc.catchItem = (short)mod.ItemType("GoldTurtle");
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 0f;
            npc.knockBackResist = .25f;
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
            return !spawnInfo.invasion && !spawnInfo.sky && !Main.eclipse && spawnInfo.player.ZoneJungle ? 0.01f : 0f;
        }
		
        public override void FindFrame(int frameHeight)
        {
			
			if (walk)
			{
				npc.frameCounter += 0.17f;
			npc.frameCounter %= (double)10;
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
					npc.spriteDirection = 1;
				}
				else
				{
					
					npc.spriteDirection = 0;
				}
				
				}
			
			if (walk)
			{
				if (npc.velocity.X == 0 && npc.velocity.Y > 5)
				{
					npc.velocity.Y = -4;
				}
				
				if (npc.ai[1] == 0)
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
			
			if(Main.rand.Next(20) == 5) {
				
						Dust.NewDust (npc.position, npc.width, npc.height, 43, Main.rand.Next(-1,2), Main.rand.Next(-1,2), 0);
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
