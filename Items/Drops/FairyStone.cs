using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Wildlife.Items.Drops
{
	public class FairyStone : ModItem
	{
		public override void SetDefaults()
		{

			item.width = 10;
			item.height = 12;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = mod.TileType("OrbTile");
			item.value = 100000;
            item.rare = 6;
		}
        public override void SetStaticDefaults()
        {
        DisplayName.SetDefault("Heavenly Crystal");
        Tooltip.SetDefault("Increases the spawn rates of fairies when placed");
        }
    }
}
