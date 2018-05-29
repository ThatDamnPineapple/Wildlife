using Terraria;
using Terraria.ModLoader;

namespace Wildlife.Items.Banners
{
	public class TurtleBanner : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 10;
			item.height = 24;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("TurtleBanner");
			item.rare = 1;
			item.value = 1000;
			item.placeStyle = 1;		//Place style means which frame(Horizontally, starting from 0) of the tile should be placed
		}
	}
}
