using Terraria;
using System;
using Terraria.ID;
using System.Diagnostics;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace Wildlife.NPCs
{
    public class Termite : ModNPC
    {
		//npc.ai[0] = 0;
		bool walk = false;
		//npc.ai[1] = 0;
		//npc.ai[2] = 0;
		bool jump = false;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Living Wood Mite");
            Main.npcFrameCount[npc.type] = 3;
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
            npc.catchItem = (short)mod.ItemType("Termite");
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 0f;
            npc.knockBackResist = .25f;
			npc.aiStyle = 7;
			aiType = NPCID.Bunny;  
			animationType = NPCID.Zombie;
        }

    	public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			int x = spawnInfo.spawnTileX;
			int y = spawnInfo.spawnTileY;
			int tile = (int)Main.tile[x, y].type;
            return (tile == 192) && !spawnInfo.invasion && !spawnInfo.sky && !Main.eclipse ? 0.5f : 0f;
            return (tile == 191) && !spawnInfo.invasion && !spawnInfo.sky && !Main.eclipse ? 0.5f : 0f;
		}
		public override void HitEffect(int hitDirection, double damage)
        {
            if (npc.life <= 0)
            {
                Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/Termite/TermiteGore"), 1f);
            }
        }
    }
}


