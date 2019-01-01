using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Events;
using System;
using System.Diagnostics;

namespace Wildlife.NPCs
{
    public class Oyster : ModNPC
    {
		bool open = false;
		bool reset = false;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Oyster");
            Main.npcFrameCount[npc.type] = 4;
        }
        public override void SetDefaults()
        {
            npc.width = 32;
            npc.height = 38;
            npc.damage = 0;
			npc.chaseable = false;
            npc.defense = 0;
			npc.velocity.X = 1;
            npc.lifeMax = 10;
			//npc.aiStyle = 0;
			npc.HitSound = SoundID.NPCHit41;
			npc.DeathSound = SoundID.NPCHit41;
            npc.value = 0f;
            npc.knockBackResist = 1f;
		//	banner = npc.type;
		//	bannerItem = mod.ItemType("DolphinBanner");
  			npc.friendly = true;
        }

				public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
           return SpawnCondition.OceanMonster.Chance * 0.2f;
        }
		
        public override void FindFrame(int frameHeight)
        {
			if (reset != open)
			{
				npc.frameCounter = 0;
				reset = open;
			}
			if (open == true && npc.frame.Y != 0)
			{
            npc.frameCounter += 0.1;
			npc.frameCounter %= (double)3;
			int num = (int)npc.frameCounter + 1;
			npc.frame.Y = (3 - num) * frameHeight;
			}
			if (open == false && npc.frame.Y != (3 * frameHeight))
			{
            npc.frameCounter += 0.1;
			npc.frameCounter %= (double)3;
			int num = (int)npc.frameCounter + 1;
			npc.frame.Y = num * frameHeight;
			}
			//npc.spriteDirection = npc.direction;
			
        }
        public override void AI()
		{
			npc.TargetClosest(true);
            Player player = Main.player[npc.target];
			if (Math.Abs(player.Center.X - npc.Center.X) < 120)
			{
				open = true;
				npc.netUpdate = true;
			}
			else
			{
				open = false;
			}
		}
		public override void NPCLoot()
        {
            if (Main.rand.Next(2) == 0)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("OysterPearl"));
            }
        }
		public override void HitEffect(int hitDirection, double damage)
        {
            if (npc.life <= 0)
            {
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Oyster/Oyster1"), 1f);
                 Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Oyster/Oyster2"), 1f);
				  Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Oyster/Oyster3"), 1f);
            }
        }
    }
}
