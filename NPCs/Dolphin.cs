using Terraria;
using System;
using Terraria.ID;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace Wildlife.NPCs
{
    public class Dolphin : ModNPC
    {
		//npc.ai[0] = 0;
		bool jump = false;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dolphin");
            Main.npcFrameCount[npc.type] = 6;
        }
        public override void SetDefaults()
        {
            npc.width = 94;
            npc.height = 38;
            npc.damage = 0;
			npc.chaseable = false;
            npc.defense = 0;
			npc.velocity.X = 1;
            npc.lifeMax = 40;
			npc.aiStyle = 0;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 0f;
            npc.knockBackResist = .25f;
			banner = npc.type;
			bannerItem = mod.ItemType("DolphinBanner");
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
           return SpawnCondition.OceanMonster.Chance * 0.08f;
        }
		
        public override void FindFrame(int frameHeight)
        {
			
            npc.frameCounter += 0.3;
			npc.frameCounter %= (double)5;
			int num = (int)npc.frameCounter + 1;
			npc.frame.Y = num * frameHeight;
			//npc.spriteDirection = npc.direction;
			
        }
        public override void AI()
		{
			if (npc.velocity.ToRotation() > 1.57f)
			{
				npc.rotation = 1.57f -(npc.velocity.ToRotation() - 1.57f);
				npc.spriteDirection = 1;
			}
			else
			{
				npc.spriteDirection = 0;
				 npc.rotation = npc.velocity.ToRotation();
			}
			string SlopeText = npc.rotation.ToString();
				//Main.NewText(SlopeText, Color.Orange.R, Color.Orange.G, Color.Orange.B);
			// npc.rotation = npc.velocity.ToRotation();
			if (Math.Abs(npc.velocity.X) < 4)
			{
				npc.velocity.X = (Math.Abs(npc.velocity.X) / npc.velocity.X) * 4;
			}
		if (npc.collideX || npc.position.Y < 300 || npc.position.Y > (Main.maxTilesX * 16) - 300)
						{
							npc.velocity.X = npc.velocity.X * -1f;
							npc.direction *= -1;
							npc.netUpdate = true;
						}
						
						
						/*if (npc.collideY)
						{
							npc.netUpdate = true;
							if (npc.velocity.Y > 0f)
							{
								npc.velocity.Y = Math.Abs(npc.velocity.Y) * -1f;
								npc.directionY = -1;
								npc.ai[0] = -1f;
							}
							else if (npc.velocity.Y < 0f)
							{
								npc.velocity.Y = Math.Abs(npc.velocity.Y);
								npc.directionY = 1;
								npc.ai[0] = 1f;
							}
						}*/
			//npc.spriteDirection = npc.direction;
			
			if (!jump && npc.wet && npc.velocity.Y < 0.2f)
			{
			npc.velocity.Y+= 0.2f;
		}
		
			if (!jump && npc.wet && npc.velocity.Y > 0.2f)
			{
			npc.velocity.Y-= 0.2f;
		}
			npc.noGravity = npc.wet;
			if (!npc.wet)
			{
				jump = false;
				npc.velocity.Y += 0.2f;
				
			}
			
			npc.ai[0]++;
			if (npc.ai[0] % 600 == 0 && npc.wet)
			{
				jump = true;
			}
			
			if (jump && npc.velocity.Y < 7.5f)
			{
				npc.velocity.Y -= 0.3f;
			}
		}
		
		public override void HitEffect(int hitDirection, double damage)
        {
            if (npc.life <= 0)
            {
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Dolphin/DolphinGore_1"), 1f);
                 Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Dolphin/DolphinGore_2"), 1f);
				 Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Dolphin/DolphinGore_3"), 1f);
				 Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Dolphin/DolphinGore_4"), 1f);
            }
        }
    }
}
