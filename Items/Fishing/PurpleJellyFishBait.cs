using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace YagoisCalmityAdditions.Items.Fishing
{
    public class PurpleJellyfishBait : ModItem
    {
        public override void SetStaticDefaults()
        {
            //SacrificeTotal(1);
            DisplayName.SetDefault("Purple Jellyfish Bait");
            Tooltip.SetDefault("Attracts Jellyfish");
        }

        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 28;
            Item.maxStack = 20;
            Item.rare = ItemRarityID.Purple;       
            Item.bait = 100;
            Item.useStyle = 1;
            Item.autoReuse = true;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.consumable = true;
            Item.noUseGraphic = true;
        }
    }
}
