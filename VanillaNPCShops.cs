using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace Wildlife
{
    public class VanillaNPCShops : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            switch (type)
            {	
				case NPCID.ArmsDealer:
                {				
			        if (NPC.downedBoss2)
                    {
                        shop.item[nextSlot].SetDefaults(mod.ItemType("OysterRound"));
                        nextSlot++;
                    }
				    break;
                }
            }
        }
    }
}