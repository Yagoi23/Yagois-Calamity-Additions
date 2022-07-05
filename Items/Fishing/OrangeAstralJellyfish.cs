using CalamityMod.NPCs.Abyss;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace YagoisCalmityAdditions.Items.Fishing
{
    public class OrangeAstralJellyfish : ModItem
    {
        public override void SetStaticDefaults()
        {
            //SacrificeTotal(1);
            DisplayName.SetDefault("Astral Jellyfish");
            //Tooltip.SetDefault("Summons The Old Duke if used as bait in the Sulphurous Sea\nEnrages outside the Sulphurous Sea");
        }

        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 28;
            Item.maxStack = 20;
            Item.rare = ItemRarityID.Orange;
            Item.bait = 100;
            Item.consumable = true;
        }
    }
}
