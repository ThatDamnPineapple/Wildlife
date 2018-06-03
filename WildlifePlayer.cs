using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader.IO;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using Terraria;

namespace Wildlife
{
	public class WildlifePlayer : ModPlayer
	{
		public bool Fairy;
		
		public override void ResetEffects()
		{
			Fairy = false;
        }
    }
}