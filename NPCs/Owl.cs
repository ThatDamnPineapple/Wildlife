using Terraria;
using System;
using Terraria.ID;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace Wildlife.NPCs
{
    public class Owl : ModNPC
    {
		int state = 0;
		int timer1 = 0;
		int timer2 = 0;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Owl");
            Main.npcFrameCount[npc.type] = 11;
        }
        public override void SetDefaults()
        {
            npc.width = 32;
            npc.height = 24;
            npc.damage = 0;
            npc.defense = 0;
            npc.lifeMax = 10;
			npc.chaseable = false;
			Main.npcCatchable[npc.type] = true;
            npc.catchItem = (short)mod.ItemType("Owl");
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 0f;
			npc.noGravity = true;
				aiType = 364;
			npc.aiStyle = 68;
            npc.knockBackResist = .25f;
			//banner = npc.type;
			//bannerItem = mod.ItemType("SnakeBanner");
  
        }

				public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
			if (SpawnCondition.Cavern.Chance != 0)
			{
				return 0.0f;
			}
            return !spawnInfo.invasion && !spawnInfo.sky && !Main.eclipse && !Main.dayTime ? 0.1f : 0f;
        }
		
        public override void FindFrame(int frameHeight)
        {
			if (state == 2)
			{
				timer1++;
				if (timer1 % 4 == 0)
				{
					timer2++;
				}
				npc.frame.Y = (int)((timer2 % 2) + 1) * frameHeight;
			}
			if (state == 0)
			{
				timer1++;
				if (timer1 % 6 == 0)
				{
					timer2++;
				}
				npc.frame.Y = (int)((timer2 % 8) + 3) * frameHeight;
			}
			if (state == 1)
			{
				npc.frame.Y = 0;
			}
			if (npc.velocity.X > 0)
				{
					npc.spriteDirection = 1;
				}
				else if (npc.velocity.X < 0)
				{	
					npc.spriteDirection = 0;
				}
        }
        public override bool PreAI()
		{
			if (npc.velocity.Y < 0)
			{
				state = 2;
			}
			else if (npc.velocity.Y == 0)
			{
				state = 1;
			}
			else if (npc.velocity.Y > 0)
			{
				state = 0;
			}
			return true;
		}
		public override void HitEffect(int hitDirection, double damage)
        {
            if (npc.life <= 0)
            {
                Gore.NewGore(npc.position, npc.velocity, 13);
				Gore.NewGore(npc.position, npc.velocity, 12);
				Gore.NewGore(npc.position, npc.velocity, 11);
            }
        }
    }
}
