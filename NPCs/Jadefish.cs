using Terraria;
using System;
using Terraria.ID;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace Wildlife.NPCs
{
    public class Jadefish : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Jadefish");
			Main.npcFrameCount[npc.type] = 2;
        }
        public override void SetDefaults()
        {
            npc.width = 28;
            npc.height = 24;
            npc.damage = 0;
			npc.chaseable = false;
            npc.defense = 0;
            npc.lifeMax = 5;
			Main.npcCatchable[npc.type] = true;
            npc.catchItem = (short)mod.ItemType("Jadefish");
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 0f;
			npc.aiStyle = 16;
			animationType = NPCID.Goldfish;
			aiType = NPCID.Goldfish;  
            npc.knockBackResist = .25f;
  
        }
 public override bool PreAI()
        {
			
			if(Main.rand.Next(10) == 5) {
				
						Dust.NewDust (npc.position, npc.width, npc.height, 43, Main.rand.Next(-1,2), Main.rand.Next(-1,2), 0);
					}
			return true;
		} /*
			public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (spawnInfo.playerSafe)
            {
                return 0f;
            }
			int x = spawnInfo.spawnTileX;
			int y = spawnInfo.spawnTileY;
			int tile = (int)Main.tile[x, y].type;
            return (tile == 1) && SpawnCondition.Cavern.Chance * 0.03f;
        } */
		public override void FindFrame(int frameHeight)
        {
			
				npc.frameCounter += 0.17f;
			npc.frameCounter %= (double)4;
			int num = (int)npc.frameCounter;
			npc.frame.Y = num * frameHeight;
		//	npc.spriteDirection = npc.direction;
		}
		public override void HitEffect(int hitDirection, double damage)
        {
            if (npc.life <= 0)
            {
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Coin/Coin_1"), 1f);
                 Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Coin/Coin_2"), 1f);
				  Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Coin/Coin_3"), 1f);
				   Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Coin/Coin_4"), 1f);
            }
        }
    }
}
