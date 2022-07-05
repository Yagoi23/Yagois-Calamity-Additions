using CalamityMod.Projectiles.Summon;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using YagoisCalamityAdditions;
using CalamityMod;
using CalamityMod.Buffs.StatDebuffs;
using CalamityMod.Buffs.DamageOverTime;

namespace YagoisCalmityAdditions.Items.Weapons.Summoner
{
    public class PlagueHerringMinion : HerringMinion
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Plague Herring");
			Main.projFrames[Projectile.type] = 8;
			ProjectileID.Sets.MinionSacrificable[Projectile.type] = true;
			ProjectileID.Sets.MinionTargettingFeature[Projectile.type] = true;
		}

		public override void AI()
		{
			Player val = Main.player[Projectile.owner];
			YagoisCalmityAdditionsPlayer modPlayer = val.GetModPlayer<YagoisCalmityAdditionsPlayer>();
			if (dust > 0)
			{
				int num = 36;
				for (int i = 0; i < num; i++)
				{
					Vector2 val2 = Utils.RotatedBy(Vector2.Normalize(((Entity)((ModProjectile)this).Projectile).velocity) * new Vector2((float)((Entity)((ModProjectile)this).Projectile).width / 2f, (float)((Entity)((ModProjectile)this).Projectile).height) * 0.75f, (double)((float)(i - (num / 2 - 1)) * ((float)Math.PI * 2f) / (float)num), default(Vector2)) + ((Entity)((ModProjectile)this).Projectile).Center;
					Vector2 val3 = val2 - ((Entity)((ModProjectile)this).Projectile).Center;
					int num2 = Dust.NewDust(val2 + val3, 0, 0, DustID.Water, val3.X * 1.75f, val3.Y * 1.75f, 100, default(Color), 1.1f);
					Main.dust[num2].noGravity = true;
					Main.dust[num2].velocity = val3;
				}
				dust--;
			}
			if (Math.Abs(((Entity)((ModProjectile)this).Projectile).velocity.X) > 0.2f)
			{
				((ModProjectile)this).Projectile.spriteDirection = ((Entity)((ModProjectile)this).Projectile).direction;
			}
			((ModProjectile)this).Projectile.rotation = ((Entity)((ModProjectile)this).Projectile).velocity.X * 0.005f;
			Projectile projectile = ((ModProjectile)this).Projectile;
			projectile.frameCounter++;
			if (((ModProjectile)this).Projectile.frameCounter > 6)
			{
				Projectile projectile2 = ((ModProjectile)this).Projectile;
				projectile2.frame++;
				((ModProjectile)this).Projectile.frameCounter = 0;
			}
			if (((ModProjectile)this).Projectile.frame >= Main.projFrames[((ModProjectile)this).Projectile.type])
			{
				((ModProjectile)this).Projectile.frame = 0;
			}
			bool num3 = ((ModProjectile)this).Projectile.type == ModContent.ProjectileType<PlagueHerringMinion>();
			val.AddBuff(ModContent.BuffType<PlagueHerringBuff>(), 3600, true, false);
			//YagoisCalmityAdditionsPlayer modPlayer = player.GetModPlayer<YagoisCalmityAdditionsPlayer>();
			if (num3)
			{
				if (val.dead)
				{
					modPlayer.PlagueHerring = false;
				}
				if (modPlayer.PlagueHerring)
				{
					((ModProjectile)this).Projectile.timeLeft = 2;
				}
			}
			Projectile.ChargingMinionAI(600f, 800f, 1200f, 150f, 0, 40f, 8f, 4f, new Vector2(0f, -60f), 40f, 7f, tileVision: false, ignoreTilesWhenCharging: true);
		}
		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(ModContent.BuffType<Plague>(), 600);
		}
	}
}
