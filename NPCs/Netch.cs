using Terraria;
using System;
using Terraria.ID;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace Wildlife.NPCs
{
    public class Netch : ModNPC
    {
		Vector2 direction = new Vector2(1, 1);
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Netch");
			Main.npcFrameCount[npc.type] = 4;
        }
        public override void SetDefaults()
        {
            npc.width = 50;
            npc.height = 54;
			npc.chaseable = false;
            npc.damage = 0;
            npc.defense = 0;
			npc.aiStyle = -1;
            npc.lifeMax = 35;
			Main.npcCatchable[npc.type] = true;
            npc.HitSound = SoundID.NPCHit2;
			npc.DeathSound = SoundID.NPCDeath6;
            npc.value = 0f;
			npc.noGravity = true;
			npc.noTileCollide = true;
            npc.knockBackResist = 0.25f;
  
        }

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return !spawnInfo.invasion && spawnInfo.sky && !Main.eclipse && Main.dayTime ? 0.1f : 0f;
        }
		public override void FindFrame(int frameHeight)
        {
			
				npc.frameCounter += 0.17f;
			npc.frameCounter %= (double)4;
			int num = (int)npc.frameCounter;
			npc.frame.Y = num * frameHeight;
		//	npc.spriteDirection = npc.direction;
			
        }
		
		 public override bool PreAI()
		  {
            //npc.TargetClosest(true);
            //Vector2 direction = new Vector2(0, 1);
            npc.rotation = direction.ToRotation() + 1.57f;
            direction.Normalize();
            npc.velocity *= 0.98f;
           
            if (Math.Sqrt((npc.velocity.X * npc.velocity.X) + (npc.velocity.Y * npc.velocity.Y)) < 0.6f)
            {
                if (Main.rand.Next(25) == 1)
                {
					direction = direction.RotatedBy(Main.rand.Next(360) * (System.Math.PI / 180));
                    direction *= Main.rand.Next(3,6);
                    npc.velocity = direction;
                }
            }
            return true;

        } 
		
        public override void AI()
		{
			Vector3 RGB = new Vector3(0f, 0.3f, 1f);
			float multiplier = 0.25f;
			float max = 2.25f;
			float min = 1.0f;
			RGB *= multiplier;
			if(RGB.X > max) {
				multiplier = 0.5f;
			}
			if(RGB.X < min) {
				multiplier = 1.5f;
			}
			Lighting.AddLight(npc.position, RGB.X, RGB.Y, RGB.Z);
			
			//npc.rotation = direction.ToRotation();
			
		}
		public override void HitEffect(int hitDirection, double damage)
        {
            if (npc.life <= 0)
            {
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Netch/Netch_1"), 1f);
                 Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Netch/Netch_2"), 1f);
				  Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Netch/Netch_3"), 1f);
				   Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Netch/Netch_4"), 1f);
            }
        }
    }
}
