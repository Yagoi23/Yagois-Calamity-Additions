using Terraria;
using Terraria.ModLoader;
using YagoisCalamityAdditions;
//using YagoisCalmityAdditions;

namespace YagoisCalmityAdditions.Items.Weapons.Summoner
{
	public class AbyssHerringBuff : ModBuff
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Abyss Herring");
			Description.SetDefault("The herring will protect you");
			Main.buffNoTimeDisplay[Type] = true;
			Main.buffNoSave[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			//ModPlayer modPlayer = player.YagoisCalmityAdditionsModPlayer();
			YagoisCalmityAdditionsPlayer modPlayer = player.GetModPlayer<YagoisCalmityAdditionsPlayer>();
			if (player.ownedProjectileCounts[ModContent.ProjectileType<AbyssHerringMinion>()] > 0)
			{
				modPlayer.AbyssHerring = true;
			}
			if (!modPlayer.AbyssHerring)
			{
				player.DelBuff(buffIndex);
				buffIndex--;
			}
			else
			{
				player.buffTime[buffIndex] = 18000;
			}
		}
	}
}
