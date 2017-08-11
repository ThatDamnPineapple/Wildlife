using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System;
using System.Collections.Generic;


namespace Wildlife.Items.Potions
{
	public class GlitchhopPotion : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Glitchhop Potion");
           Tooltip.SetDefault("Teleports you to a nearby area");

        }
		 public override void SetDefaults()
        {
         
            item.UseSound = SoundID.Item3;
            item.useStyle = 2;
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 30;
            item.consumable = true;
            item.width = 12;
            item.height = 30;
          
            item.value = 2500;
            item.rare = 5;
          //  item.buffType = mod.BuffType("SparkBuff");
          //  item.buffTime = 10000;
           // return;
        }
		 public override bool UseItem(Player player)
        {
			 bool canSpawn = false;
			 bool tele = false;
			 while (tele == false)
			 {
                int teleportStartX = (int)(Main.player[Main.myPlayer].position.X / 16) - 75;
            int teleportRangeX = 150;
                int teleportStartY = (int)(Main.player[Main.myPlayer].position.Y / 16) - 75;
                int teleportRangeY = 150;
                Vector2 vector2 = this.TestTeleport(ref canSpawn, teleportStartX, teleportRangeX, teleportStartY, teleportRangeY);
                if (canSpawn)
                {
                    Vector2 newPos = vector2;
                    Main.player[Main.myPlayer].Teleport(newPos, 2, 0);
                    Main.player[Main.myPlayer].velocity = Vector2.Zero;
                    if (Main.netMode == 2)
                    {
                        RemoteClient.CheckSection(Main.myPlayer, Main.player[Main.myPlayer].position, 1);
                        NetMessage.SendData(65, -1, -1, null, 0, (float)Main.myPlayer, newPos.X, newPos.Y, 3, 0, 0);
                    }
					tele = true;
                }
			 }
			return true;
		}
       
	   
	    private Vector2 TestTeleport(ref bool canSpawn, int teleportStartX, int teleportRangeX, int teleportStartY, int teleportRangeY)
        {
            Player player = Main.player[Main.myPlayer];
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int width = player.width;
            Vector2 Position = new Vector2((float)num2, (float)num3) * 16f + new Vector2((float)(-width / 2 + 8), (float)-player.height);
            while (!canSpawn && num1 < 1000)
            {
                ++num1;
                int index1 = teleportStartX + Main.rand.Next(teleportRangeX);
                int index2 = teleportStartY + Main.rand.Next(teleportRangeY);
                Position = new Vector2((float)index1, (float)index2) * 16f + new Vector2((float)(-width / 2 + 8), (float)-player.height);
                if (!Collision.SolidCollision(Position, width, player.height))
                {
                    if (Main.tile[index1, index2] == null)
                        Main.tile[index1, index2] = new Tile();
                    if (((int)Main.tile[index1, index2].wall != 87 || (double)index2 <= Main.worldSurface || NPC.downedPlantBoss) && (!Main.wallDungeon[(int)Main.tile[index1, index2].wall] || (double)index2 <= Main.worldSurface || NPC.downedBoss3))
                    {
                        int num4 = 0;
                        while (num4 < 100)
                        {
                            if (Main.tile[index1, index2 + num4] == null)
                                Main.tile[index1, index2 + num4] = new Tile();
                            Tile tile = Main.tile[index1, index2 + num4];
                            Position = new Vector2((float)index1, (float)(index2 + num4)) * 16f + new Vector2((float)(-width / 2 + 8), (float)-player.height);
                            Vector4 vector4 = Collision.SlopeCollision(Position, player.velocity, width, player.height, player.gravDir, false);
                            bool flag = !Collision.SolidCollision(Position, width, player.height);
                            if ((double)vector4.Z == (double)player.velocity.X)
                            {
                                double y = (double)player.velocity.Y;
                            }
                            if (flag)
                                ++num4;
                            else if (!tile.active() || tile.inActive() || !Main.tileSolid[(int)tile.type])
                                ++num4;
                            else
                                break;
                        }
                        if (!Collision.LavaCollision(Position, width, player.height) && (double)Collision.HurtTiles(Position, player.velocity, width, player.height, false).Y <= 0.0)
                        {
                            Collision.SlopeCollision(Position, player.velocity, width, player.height, player.gravDir, false);
                            if (Collision.SolidCollision(Position, width, player.height) && num4 < 99)
                            {
                                Vector2 Velocity1 = Vector2.UnitX * 16f;
                                if (!(Collision.TileCollision(Position - Velocity1, Velocity1, player.width, player.height, false, false, (int)player.gravDir) != Velocity1))
                                {
                                    Vector2 Velocity2 = -Vector2.UnitX * 16f;
                                    if (!(Collision.TileCollision(Position - Velocity2, Velocity2, player.width, player.height, false, false, (int)player.gravDir) != Velocity2))
                                    {
                                        Vector2 Velocity3 = Vector2.UnitY * 16f;
                                        if (!(Collision.TileCollision(Position - Velocity3, Velocity3, player.width, player.height, false, false, (int)player.gravDir) != Velocity3))
                                        {
                                            Vector2 Velocity4 = -Vector2.UnitY * 16f;
                                            if (!(Collision.TileCollision(Position - Velocity4, Velocity4, player.width, player.height, false, false, (int)player.gravDir) != Velocity4))
                                            {
                                                canSpawn = true;
                                                int num5 = index2 + num4;
                                                break;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return Position;
        }
		
		
		public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BottledWater, 1);
            recipe.AddIngredient(null, "FluxCoral", 1);
			 recipe.AddIngredient(null, "FairyP", 1);
			 recipe.AddIngredient(null, "FrostShine", 1);
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        
	}
}