using CalamityMod.NPCs.Abyss;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace YagoisCalmityAdditions.Items.Fishing
{
    public class AbyssJelly : ModItem
    {
        public override void SetStaticDefaults()
        {
            //SacrificeTotal(1);
            DisplayName.SetDefault("Abyss Jelly");
            //Tooltip.SetDefault("Summons The Old Duke if used as bait in the Sulphurous Sea\nEnrages outside the Sulphurous Sea");
        }

        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 28;
            Item.maxStack = 20;
            Item.rare = ItemRarityID.Blue;
            //Item.Calamity().customRarity = CalamityRarity.PureGreen;
            Item.bait = 100;
            Item.useStyle = 1;
            Item.autoReuse = true;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.consumable = true;
            Item.noUseGraphic = true;
            //Item.makeNPC = (short)ModContent.NPCType<BloodwormNormal>();
        }
    }
}
