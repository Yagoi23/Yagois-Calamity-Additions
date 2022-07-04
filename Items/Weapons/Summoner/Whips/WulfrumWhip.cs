using CalamityMod.Items;
using CalamityMod.Items.Materials;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace YagoisCalmityAdditions.Items.Weapons.Summoner.Whips
{
    public class WulfrumWhip : ModItem
	{
		public override void SetStaticDefaults()
		{
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			// This method quickly sets the whip's properties.
			// Mouse over to see its parameters.
			Item.DefaultToWhip(ModContent.ProjectileType<WulfrumWhipProj>(), 12, 2, 4);

			Item.shootSpeed = 4;
			Item.rare = ItemRarityID.Green;

			Item.autoReuse = true;
			//Item.channel = true;
		}
		
		public override void AddRecipes()
        {
			//Mod CalamityMod = ModLoader.GetMod("CalamityMod");
			/////if (CalamityMod != null)
			//{
			//recipe.AddIngredient(CalamityMod.ItemType("ExampleWings"));
			//CreateRecipe()
			//.AddIngredient<CalamityMod.ItemType(Wulfrum)>()
			//.AddTile<Tiles.Furniture.ExampleWorkbench>()
			//.Register();
			//}
			CreateRecipe()
				.AddIngredient(ModContent.ItemType<WulfrumShard>(), 3)
				.AddIngredient(ModContent.ItemType<EnergyCore>(), 1)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}