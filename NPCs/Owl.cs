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
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Owl");
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
            npc.catchItem = (short)mod.ItemType("Owl");
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
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
			if (SpawnCondition.Cavern.Chance != 0)
			{
				return 0.0f;
			}
            return !spawnInfo.invasion && !spawnInfo.sky && !Main.eclipse && !Main.dayTime ? 0.1f : 0f;
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
