using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader.IO;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using Terraria;
using Terraria.GameContent.Events;

namespace Wildlife.NPCs
{
    public class GraniteOrb : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Supercharged Orb");
			Main.npcFrameCount[npc.type] = 1;
        }
        public override void SetDefaults()
        {
            npc.width = 8;
            npc.height = 8;
            npc.damage = 0;
			npc.chaseable = false;
            npc.defense = 0;
            npc.lifeMax = 5;
			Main.npcCatchable[npc.type] = true;
            npc.catchItem = (short)mod.ItemType("GraniteOrb");
            npc.HitSound = SoundID.NPCHit53;
            npc.DeathSound = SoundID.NPCDeath56;
            npc.value = 0f;
			npc.aiStyle = 64;
				aiType = 358;
				npc.noGravity = true;
            npc.knockBackResist = .25f;
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
			int x = spawnInfo.spawnTileX;
			int y = spawnInfo.spawnTileY;
			int tile = (int)Main.tile[x, y].type;
            return (tile == 368) && !spawnInfo.invasion && !spawnInfo.sky && !Main.eclipse ? 0.05f : 0f;
        }		
        public override void AI()
		{
			Vector3 RGB = new Vector3(0f, 1.5f, 2.5f);
			npc.TargetClosest();
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
