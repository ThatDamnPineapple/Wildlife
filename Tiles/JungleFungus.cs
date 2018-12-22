using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace Wildlife.Tiles
{
    public class JungleFungus : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            //TileObjectData.addTile(Type);
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            Main.tileSolid[Type] = false;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileLighted[Type] = false;
            AddMapEntry(new Color(163, 147, 115));
			dustType = 178;
			Main.tileCut[Type] = true;
			TileObjectData.newTile.DrawYOffset = 2;
            TileObjectData.newTile.CoordinateHeights = new int[]
            {
                16,
                16
            };

            TileObjectData.addTile(Type);
        }

        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = fail ? 1 : 3;
        }
       public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Main.PlaySound(3, i * 16, j * 16, 9);	 
            int drop = Main.rand.Next(1,10);
			for (int k = 0; k < drop; k++)
			{
                Item.NewItem((i * 16) + Main.rand.Next(24), (j * 16) + Main.rand.Next(64), 48, 48, mod.ItemType("Jaderose"));
			}
           
        }
       

    }
}
