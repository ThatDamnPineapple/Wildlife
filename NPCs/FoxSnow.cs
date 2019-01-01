using Terraria;
using System;
using Terraria.ID;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace Wildlife.NPCs
{
    public class FoxSnow : ModNPC
    {
		//npc.ai[0] = 0;
		bool walk = false;
		//npc.ai[1] = 0;
		//npc.ai[2] = 0;
		bool jump = false;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Arctic Fox");
            Main.npcFrameCount[npc.type] = 3;
        }
        public override void SetDefaults()
        {
            npc.width = 42;
            npc.height = 28;
            npc.damage = 0;
			npc.chaseable = false;
            npc.defense = 0;
            npc.lifeMax = 5;
			Main.npcCatchable[npc.type] = true;
            npc.catchItem = (short)mod.ItemType("FoxSnow");
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 0f;
            npc.knockBackResist = .25f;
			banner = npc.type;
			bannerItem = mod.ItemType("FoxBanner");
			npc.aiStyle = 7;
			aiType = NPCID.Bunny;  
			animationType = NPCID.Zombie;
			npc.friendly = true;
        }

				public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
			if (SpawnCondition.Cavern.Chance != 0)
			{
				return 0.0f;
			}
            return spawnInfo.player.ZoneOverworldHeight && !spawnInfo.invasion && !spawnInfo.sky && !Main.eclipse && spawnInfo.player.ZoneSnow ? 0.08f : 0f;
		}
		public override void HitEffect(int hitDirection, double damage)
        {
            if (npc.life <= 0)
            {
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Fox/FoxGore_4"), 1f);
                 Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Fox/FoxGore_5"), 1f);
            }
        }
    }
}
