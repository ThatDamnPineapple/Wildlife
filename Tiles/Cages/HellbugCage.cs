using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace Wildlife.Tiles.Cages
{
	internal class HellbugCage : ModTile
	{
		public override void SetDefaults() {
			Main.tileLighted[Type] = true;
			Main.tileFrameImportant[Type] = true;
			Main.tileLavaDeath[Type] = true;

			TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2Top);
			TileObjectData.addTile(Type);
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Infernal Mosquito in a bottle");
			AddMapEntry(new Color(100, 0, 15), name);

			//Can't use this since texture is vertical.
			//animationFrameHeight = 56;
		}

		// Our textures animation frames are arranged horizontally, which isn't typical, so here we specify animationFrameWidth which we use later in AnimateIndividualTile
		private readonly int animationFrameWidth = 18;

		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b) {
			r = 1f;
			g = 0f;
			b = 0.1f;
		}

		public override void SetSpriteEffects(int i, int j, ref SpriteEffects spriteEffects) {
			if (i % 2 == 1) {
				spriteEffects = SpriteEffects.FlipHorizontally;
			}
		}

		public override void AnimateIndividualTile(int type, int i, int j, ref int frameXOffset, ref int frameYOffset) {
			// Tweak the frame drawn by x position so tiles next to each other are off-sync and look much more interesting.
			int uniqueAnimationFrame = Main.tileFrame[Type] + i;
			if (i % 2 == 0) {
				uniqueAnimationFrame += 3;
			}
			if (i % 3 == 0) {
				uniqueAnimationFrame += 3;
			}
			if (i % 4 == 0) {
				uniqueAnimationFrame += 3;
			}
			uniqueAnimationFrame = uniqueAnimationFrame % 6;

			frameXOffset = uniqueAnimationFrame * animationFrameWidth;
		}
		public override void AnimateTile(ref int frame, ref int frameCounter) {
			frame = Main.tileFrame[TileID.FireflyinaBottle];
		}

		public override void KillMultiTile(int i, int j, int frameX, int frameY) {
			Item.NewItem(i * 16, j * 16, 16, 32, mod.ItemType<HellbugCageItem>());
		}
	}

	internal class HellbugCageItem : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Infernal Mosquito in a Bottle");
		}

		public override void SetDefaults() {
			item.CloneDefaults(ItemID.FireflyinaBottle);
			item.createTile = mod.TileType<HellbugCage>();
		}
	}
}