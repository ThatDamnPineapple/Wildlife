using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace Wildlife.Tiles
{
    public class Bamboo : ModTile
    {
        public override void SetDefaults()
        {
          Main.tileFrameImportant[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileLavaDeath[Type] = true;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style2xX);
			TileObjectData.newTile.Height = 6;
			TileObjectData.newTile.CoordinateHeights = new int[]
			{
				16,
				16,
				16,
				16,
				16,
				16
			};
			TileObjectData.addTile(Type);
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Bamboo");
			AddMapEntry(new Color(200, 200, 200), name);
			dustType = 3;
			adjTiles = new int[] { TileID.GrandfatherClocks };
		}
		
		
		
        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = fail ? 1 : 3;
        }
       public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            int drop = Main.rand.Next(2,5);
			for (int k = 0; k < drop; k++)
			{
                Item.NewItem((i * 16) + Main.rand.Next(24), (j * 16) + Main.rand.Next(64), 48, 48, mod.ItemType("Bamboo"));
			}
           
        }
       

    }
}