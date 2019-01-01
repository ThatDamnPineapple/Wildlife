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
		//npc.ai[0] = 0;
		bool walk = false;
		//npc.ai[1] = 0;
		//npc.ai[2] = 0;
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
		//	npc.spriteDirection = npc.npc.ai[1];
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
			
			
			
			
			
			
			
				npc.ai[0]++;
				if (npc.ai[0] % 500 == 499)
				{
					npc.ai[1] = Main.rand.Next(2);
					npc.ai[2] = Main.rand.Next(80,450);
				}
				if (npc.ai[0] % 500 > 0 && npc.ai[0] % 500 < npc.ai[2])
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
				if (npc.velocity.X == 0)
				{
					npc.velocity.Y = -4;
				}
				
				if (npc.ai[1] == 0)
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
