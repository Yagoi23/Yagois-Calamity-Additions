using Terraria;
using Terraria.ModLoader;
using YagoisCalamityAdditions;
//using YagoisCalmityAdditions;

namespace YagoisCalmityAdditions.Items.Weapons.Summoner
{
	public class ShadowHerringBuff : ModBuff
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shadow Herring");
			Description.SetDefault("The herring will protect you");
			Main.buffNoTimeDisplay[Type] = true;
			Main.buffNoSave[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			//ModPlayer modPlayer = player.YagoisCalmityAdditionsModPlayer();
			YagoisCalmityAdditionsPlayer modPlayer = player.GetModPlayer<YagoisCalmityAdditionsPlayer>();
			if (player.ownedProjectileCounts[ModContent.ProjectileType<ShadowHerringMinion>()] > 0)
			{
				modPlayer.ShadowHerring = true;
			}
			if (!modPlayer.ShadowHerring)
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
