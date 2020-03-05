using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace VanillaOverhaulMod
{
    class RainPlayer : ModPlayer
    {
        bool obsidian = false;

        public void setObsidian(bool value)
        {
            obsidian = value;
        }

        public bool getObsidian()
        {
            return obsidian;
        }
    }
}
