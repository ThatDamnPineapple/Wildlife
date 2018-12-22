using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Wildlife.Tiles
{
	internal sealed class WGlobalTile : GlobalTile
	{
		int[] TileArray2 = {0, 3, 185, 186, 187, 71, 28};
		public override void RandomUpdate(int i, int j, int type)
        {
			if (type == 367)
			{
            if(TileArray2.Contains(Framing.GetTileSafely(i,j-1).type) &&TileArray2.Contains(Framing.GetTileSafely(i,j-2).type))
            {
                        if(Main.rand.Next(800)==0)
                        {
                            WorldGen.PlaceObject(i-1,j-1,mod.TileType("Medustalk"));
                            NetMessage.SendObjectPlacment(-1,i-1,j-1,mod.TileType("Medustalk"),0,0,-1,-1);
                        }            
                
            }
			}
			
			if (type == 147)
			{
            if(TileArray2.Contains(Framing.GetTileSafely(i,j-1).type) &&TileArray2.Contains(Framing.GetTileSafely(i,j-2).type))
            {
                        if(Main.rand.Next(1800)==0)
                        {
                            WorldGen.PlaceObject(i-1,j-1,mod.TileType("FrostShine"));
                            NetMessage.SendObjectPlacment(-1,i-1,j-1,mod.TileType("FrostShine"),0,0,-1,-1);
                        }            
                
            }
			}
			
			if (type == 2)
			{
            if(TileArray2.Contains(Framing.GetTileSafely(i,j-1).type) && (i < (Main.maxTilesX / 5) || i > Main.maxTilesX - (Main.maxTilesX / 5)))
            {
                        if(Main.rand.Next(400)==0)
                        {
						   
                             int why = Main.rand.Next(8);
							WorldGen.PlaceObject(i,j-why,mod.TileType("Bamboo"));
                            NetMessage.SendObjectPlacment(-1,i,j-why,mod.TileType("Bamboo"),0,0,-1,-1);
							
                       }            
                
            }
			}
			
			if (type == 2) //add water support later
			{
				bool place = false;
				for (int x = i - 5; x < i + 5; x++)
				{
					for (int y = j; y < j + 5; y++)
					{
						if (Main.tile[x, y].liquid == 255)
						{
							place = true;
						}
					}
				}
			
			 if(TileArray2.Contains(Framing.GetTileSafely(i,j-1).type) &&TileArray2.Contains(Framing.GetTileSafely(i,j-2).type) && place)
            {
                        if(Main.rand.Next(800) ==1)
                        {
                            WorldGen.PlaceObject(i-1,j-1,mod.TileType("CatTail"));
                            NetMessage.SendObjectPlacment(-1,i-1,j-1,mod.TileType("CatTail"),0,0,-1,-1);
						
							
                        }            
                
            }
			}
			
			if (type == 1) //magma corn
			{
				bool place = false;
				for (int x = i - 7; x < i + 7; x++)
				{
					for (int y = j; y < j + 7; y++)
					{
						if (Main.tile[x, y].liquid == 255 && Main.tile[x, y].lava())
						{
							place = true;
						}
					}
				}
			
			 if(TileArray2.Contains(Framing.GetTileSafely(i,j-1).type) &&TileArray2.Contains(Framing.GetTileSafely(i,j-2).type) && place)
            {
                        if(Main.rand.Next(800)==1)
                        {
                            WorldGen.PlaceObject(i-1,j-1,mod.TileType("MagmaCorn"));
                            NetMessage.SendObjectPlacment(-1,i-1,j-1,mod.TileType("MagmaCorn"),0,0,-1,-1);
						
							
                        }            
                
            }
			}
			
			if (type == 2) //add water support later
			{
				
			
			 if(TileArray2.Contains(Framing.GetTileSafely(i,j-1).type) &&TileArray2.Contains(Framing.GetTileSafely(i,j-2).type))
            {
                        if(Main.rand.Next(1800)==2)
                        {
                            WorldGen.PlaceObject(i-1,j-1,mod.TileType("StrawberryPlant"));
                            NetMessage.SendObjectPlacment(-1,i-1,j-1,mod.TileType("StrawberryPlant"),0,0,-1,-1);
						
							
                        }            
                
            }
			}
			
			
			if (type == 368)
			{
            if(TileArray2.Contains(Framing.GetTileSafely(i,j-1).type) &&TileArray2.Contains(Framing.GetTileSafely(i,j-2).type))
            {
                        if(Main.rand.Next(1400)==0)
                        {
                            WorldGen.PlaceObject(i-1,j-1,mod.TileType("FluxCoral"));
                            NetMessage.SendObjectPlacment(-1,i-1,j-1,mod.TileType("FluxCoral"),0,0,-1,-1);
                        }            
                
            }
			}
			
			if (type == 70)
			{
            if(TileArray2.Contains(Framing.GetTileSafely(i,j-1).type) &&TileArray2.Contains(Framing.GetTileSafely(i,j-2).type))
            {
                        if(Main.rand.Next(1400)==0)
                        {
                            WorldGen.PlaceObject(i-1,j-1,mod.TileType("Gelon"));
                            NetMessage.SendObjectPlacment(-1,i-1,j-1,mod.TileType("Gelon"),0,0,-1,-1);
                        }            
                
            }
			}
			
			if (type == 396)
			{
            if(TileArray2.Contains(Framing.GetTileSafely(i,j-1).type) &&TileArray2.Contains(Framing.GetTileSafely(i,j-2).type))
            {
                        if(Main.rand.Next(1200)==0)
                        {
                            WorldGen.PlaceObject(i-1,j-1,mod.TileType("Jaderose"));
                            NetMessage.SendObjectPlacment(-1,i-1,j-1,mod.TileType("Jaderose"),0,0,-1,-1);
                        }            
                
            }
			}
			
			if (type == 396)
			{
            if(TileArray2.Contains(Framing.GetTileSafely(i,j-1).type) &&TileArray2.Contains(Framing.GetTileSafely(i,j-2).type))
            {
                        if(Main.rand.Next(2500)==0)
                        {
                            WorldGen.PlaceObject(i-1,j-1,mod.TileType("JungleFungus"));
                            NetMessage.SendObjectPlacment(-1,i-1,j-1,mod.TileType("JungleFungus"),0,0,-1,-1);
                        }            
                
            }
			}
			
			if (type == 396)
			{
            if(TileArray2.Contains(Framing.GetTileSafely(i,j-1).type) &&TileArray2.Contains(Framing.GetTileSafely(i,j-2).type))
            {
                        if(Main.rand.Next(2500)==0)
                        {
                            WorldGen.PlaceObject(i-1,j-1,mod.TileType("VenomRadish"));
                            NetMessage.SendObjectPlacment(-1,i-1,j-1,mod.TileType("VenomRadish"),0,0,-1,-1);
                        }            
                
            }
			}
			
			if (type == 2) //add water support later
			{
				
			
			if(TileArray2.Contains(Framing.GetTileSafely(i,j-1).type) &&TileArray2.Contains(Framing.GetTileSafely(i,j-2).type))
            {
                        if(Main.rand.Next(1800)==2)
                        {
                            WorldGen.PlaceObject(i-1,j-1,mod.TileType("ForestPlant"));
                            NetMessage.SendObjectPlacment(-1,i-1,j-1,mod.TileType("ForestPlant"),0,0,-1,-1);
                        }                          
            }
			}	
        }
	}
}
