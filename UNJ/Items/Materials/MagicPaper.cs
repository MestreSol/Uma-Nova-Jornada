using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using static Terraria.ModLoader.ModContent;
namespace UNJ.Items.Materials
{
    class MagicPaper : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pergaminho magico");
            Tooltip.SetDefault("Pergaminho antigo escrito em uma lingua desconhecida");
        }
    }
}
