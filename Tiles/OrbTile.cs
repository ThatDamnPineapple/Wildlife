using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Terraria.GameContent.Events;
using System;
using System.Collections.Generic;

namespace Wildlife.Tiles
{
	public class OrbTile : ModTile
	{
		public override void SetDefaults()
		{
            Main.tileLighted[Type] = true;
            Main.tileFrameImportant[Type] = true;
            Main.tileSolid[Type] = false;
            Main.tileLavaDeath[Type] = true;
		    AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTorch);

			TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
			TileObjectData.addTile(Type);
            drop = mod.ItemType("FairyStone");
            //Can't use this since texture is virtical.
            //animationFrameHeight = 56;
        }
		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			r = 2.5f;
			g = 1f;
			b = 2.5f;
		}

		public override void KillMultiTile(int i, int j, int frameX, int frameY)
		{
			Item.NewItem(i * 16, j * 16, 16, 32, mod.ItemType("FairyStone"));
		}
		public override void NearbyEffects(int i, int j, bool closer)
		{
			if (closer && !Main.LocalPlayer.dead)
			{
				Player player = Main.LocalPlayer;		
				player.AddBuff(mod.BuffType("QuakeHurt"), 5);
			}
		}
	}
	
}
