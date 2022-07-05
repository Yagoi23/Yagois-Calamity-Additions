using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace YagoisCalmityAdditions.Items.Weapons.Summoner
{
	public class PlagueHerringStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Plague Herring Staff");
			Tooltip.SetDefault("Summons an plagued herring to fight for you\nEach herring takes only half of a minion slot");
			//Main.set_SacrificeTotal(1);
		}

		public override void SetDefaults()
		{
			Item.damage = 20;
			Item.mana = 10;
			Item.width = 48;
			Item.height = 48;
			Item.useTime = (Item.useAnimation = 30);
			Item.useStyle = 1;
			Item.noMelee = true;
			Item.knockBack = 1.25f;
			//Item.value = Item.buyPrice(0, 4, 0, 0);
			Item.rare = 3;
			//Item.UseSound = SoundID.Item21;
			Item.autoReuse = true;
			Item.shoot = ModContent.ProjectileType<PlagueHerringMinion>();
			Item.shootSpeed = 10f;
			Item.DamageType = DamageClass.Summon;
		}

		/*public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
		{
			if (player.altFunctionUse != 2)
			{
				position = Main.get_MouseWorld();
				velocity.X = 0f;
				velocity.Y = 0f;
				int num = Projectile.NewProjectile((IEntitySource)(object)source, position.X, position.Y, velocity.X, velocity.Y, type, damage, knockback, ((Entity)player).whoAmI, 0f, 0f);
				if (Utils.IndexInRange<Projectile>(Main.projectile, num))
				{
					Main.projectile[num].originalDamage = Item.damage;
				}
			}
			return false;
		}*/
	}
}
