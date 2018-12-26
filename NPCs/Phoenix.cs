using Terraria;
using System;
using Terraria.ID;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace Wildlife.NPCs
{
    public class Phoenix : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Scorching Phoenix");
            Main.npcFrameCount[npc.type] = 5;
        }
        public override void SetDefaults()
        {
            npc.width = 32;
            npc.height = 24;
            npc.damage = 0;
            npc.defense = 0;
            npc.lifeMax = 5;
			npc.chaseable = false;
			Main.npcCatchable[npc.type] = true;
            npc.catchItem = (short)mod.ItemType("Phoenix");
            npc.HitSound = SoundID.NPCHit5;
            npc.DeathSound = SoundID.NPCDeath3;
            npc.value = 0f;
			npc.noGravity = true;
			animationType = NPCID.Bird;
			aiType = NPCID.Bird;  
			npc.aiStyle = 24;
            npc.knockBackResist = .25f;
			//banner = npc.type;
			//bannerItem = mod.ItemType("SnakeBanner");
  
        }

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return spawnInfo.player.ZoneUnderworldHeight ? 0.05f : 0f;
        }
		public override void HitEffect(int hitDirection, double damage)
        {
            if (npc.life <= 0)
            {
                if (Main.rand.Next(4) == 0)
                {
			    NPC.NewNPC((int)(npc.position.X), (int)(npc.position.Y), (mod.NPCType("Phoenix")));
			    NPC.NewNPC((int)(npc.position.X), (int)(npc.position.Y), (mod.NPCType("Phoenix")));
				Main.PlaySound(SoundID.Item4, npc.position);
			    Dust.NewDust(npc.position, npc.width, npc.height, 158);
			    Dust.NewDust(npc.position, npc.width, npc.height, 158);
			    Dust.NewDust(npc.position, npc.width, npc.height, 158);
			    Dust.NewDust(npc.position, npc.width, npc.height, 158);
                }
			Dust.NewDust(npc.position, npc.width, npc.height, 158);
            }
        }
        public override void AI()
		{
			Vector3 RGB = new Vector3(0.25f, 0.15f, 0.10f);
			float multiplier = 0.75f;
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
			
		} 
    }
}
