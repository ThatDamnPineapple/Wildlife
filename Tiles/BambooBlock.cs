using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Wildlife.Tiles
{
	public class BambooBlock : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			dustType = 1;
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Bamboo");
			drop = mod.ItemType("Bamboo");
			AddMapEntry(new Color(64, 115, 47), name);
			mineResist = 0.5f;

		}

		public override void NumDust(int i, int j, bool fail, ref int num)
		{
			num = fail ? 1 : 3;
		}
	}
}