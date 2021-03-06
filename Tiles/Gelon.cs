using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;


namespace Wildlife.Tiles
{
    public class Gelon : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            //TileObjectData.addTile(Type);
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            Main.tileSolid[Type] = false;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileLighted[Type] = true;
            AddMapEntry(new Color(32, 55, 187));
			dustType = 29;
			Main.tileCut[Type] = true;
			TileObjectData.newTile.DrawYOffset = 2;
            TileObjectData.newTile.CoordinateHeights = new int[]
            {
                16,
                16
            };

            TileObjectData.addTile(Type);
        }
		public override void PostDraw(int i, int j, SpriteBatch spriteBatch)
		{
			Tile tile = Main.tile[i, j];
			Vector2 zero = new Vector2(Main.offScreenRange, Main.offScreenRange);
			if (Main.drawToScreen)
			{
				zero = Vector2.Zero;
			}
			int height = tile.frameY == 36 ? 18 : 16;
			Main.spriteBatch.Draw(mod.GetTexture("Tiles/GelonGlow"), new Vector2(i * 16 - (int)Main.screenPosition.X, j * 16 - (int)Main.screenPosition.Y) + zero, new Rectangle(tile.frameX, tile.frameY, 16, height), Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
		}
		
        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = fail ? 1 : 3;
        }
		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			r = 0.0f;
			g = 0.05f;
			b = 0.4f;
		}
      public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Main.PlaySound(4, i * 16, j * 16, 1);		
            Item.NewItem(i * 16, j * 16, 48, 48, mod.ItemType("GelonSlice"));
                Item.NewItem(i * 16, j * 16, 48, 48, mod.ItemType("GelonSlice"));
            if (Main.rand.Next(2) == 0)
			{
			Item.NewItem(i * 16, j * 16, 48, 48, mod.ItemType("GelonSlice"));
			}
        }
       

    }
}
