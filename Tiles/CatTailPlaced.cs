using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace Wildlife.Tiles
{
    public class CatTailPlaced : ModTile
    {
		bool flipped = false;
        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            //TileObjectData.addTile(Type);
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            Main.tileSolid[Type] = false;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileLighted[Type] = false;
            AddMapEntry(new Color(104, 77, 47));
			dustType = 0;
			TileObjectData.newTile.DrawYOffset = 2;
            TileObjectData.newTile.CoordinateHeights = new int[]
            {
                16,
                16
            };

            TileObjectData.addTile(Type);
			animationFrameHeight = 36;
        }	
	    private readonly int animationFrameWidth = 36;
		
		public override void RandomUpdate(int i, int j) {		
			if (Main.tile[i, j].frameX == 0) {

				Main.tile[i, j].frameX += 36;

			}

			else if (Main.tile[i, j].frameX == 36) {

				Main.tile[i, j].frameX += 36;
			}
		}		
        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = fail ? 1 : 3;
        }
        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Main.PlaySound(6, i * 16, j * 16);	            
			int stage = Main.tile[i, j].frameX / 18;
			if (stage == 3) {
			{
            Item.NewItem(i * 16, j * 16, 48, 48, mod.ItemType("CatTail"));
			}      
            if (Main.rand.Next(50) == 0)
			{
            Main.PlaySound(31, i * 16, j * 16);	 
			}          
        }
       
		}
    }
}
