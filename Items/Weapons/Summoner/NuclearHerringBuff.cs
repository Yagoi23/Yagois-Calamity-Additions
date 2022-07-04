using Terraria;
using Terraria.ModLoader;
using YagoisCalamityAdditions;
//using YagoisCalmityAdditions;

namespace YagoisCalmityAdditions.Items.Weapons.Summoner
{
	public class NuclearHerringBuff : ModBuff
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nuclear Herring");
			Description.SetDefault("The herring will protect you");
			Main.buffNoTimeDisplay[Type] = true;
			Main.buffNoSave[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			//ModPlayer modPlayer = player.YagoisCalmityAdditionsModPlayer();
			YagoisCalmityAdditionsPlayer modPlayer = player.GetModPlayer<YagoisCalmityAdditionsPlayer>();
			if (player.ownedProjectileCounts[ModContent.ProjectileType<NuclearHerringMinion>()] > 0)
			{
				modPlayer.NuclearHerring = true;
			}
			if (!modPlayer.NuclearHerring)
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
