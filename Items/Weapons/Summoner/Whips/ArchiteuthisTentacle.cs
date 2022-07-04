using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace YagoisCalmityAdditions.Items.Weapons.Summoner.Whips
{
	public class ArchiteuthisTentacle : ModItem
	{
		public override void SetStaticDefaults()
		{
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			// This method quickly sets the whip's properties.
			// Mouse over to see its parameters.
			Item.DefaultToWhip(ModContent.ProjectileType<ArchiteuthisTentacleProj>(), 230, 2, 4);

			Item.shootSpeed = 4;
			Item.rare = ItemRarityID.Green;

			Item.autoReuse = true;
			//Item.channel = true;
		}
	}
}