using System;
using System.Collections.Generic;
using CalamityMod;
using CalamityMod.NPCs.Abyss;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.Graphics.Shaders;
using Terraria.ModLoader;
using YagoisCalmityAdditions.Items.Weapons.Summoner.Whips;

namespace YagoisCalamityAdditions
{
	public class YagoisCalamityAdditionsGlobalNPC : GlobalNPC
	{
		public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
		{
			/*if (CalamityMod.DownedBossSystem.downedPolterghast == true)
            {
				if (npc.type == ModContent.NPCType<ColossalSquid>())
				{
					//50% drop chance
					((NPCLoot)(npcLoot)).Add(ItemDropRule.Common(ModContent.ItemType<ArchiteuthisTentacle>(),2,1,1));
				}
			}*/
			if (npc.type == ModContent.NPCType<ColossalSquid>())
			{
				//50% drop chance
				((NPCLoot)(npcLoot)).Add(ItemDropRule.Common(ModContent.ItemType<ArchiteuthisTentacle>(), 2, 1, 1));
			}
		}

		public static void PlagueBaitSpawn(int plr, int type, int baitType)
        {
			Player val = Main.player[plr];
			if (!((Entity)val).active || val.dead)
			{
				return;
			}
			for (int i = 0; i < 1000; i++)
			{
				Projectile val2 = Main.projectile[i];
				if (!((Entity)val2).active || !val2.bobber || val2.owner != plr)
				{
					continue;
				}
				if (plr != Main.myPlayer || val2.ai[0] != 0f)
				{
					break;
				}
				for (int j = 0; j < 58; j++)
				{
					if (val.inventory[j].type == baitType)
					{
						Item obj = val.inventory[j];
						obj.stack--;
						if (val.inventory[j].stack <= 0)
						{
							val.inventory[j].SetDefaults(0, false);
						}
						break;
					}
				}
				val2.ai[0] = 2f;
				val2.netUpdate = true;
				if (Main.myPlayer != val2.owner)
				{
					break;
				}
				if (Main.netMode == 0)
				{
					if (!((Entity)val).active || val.dead)
					{
						break;
					}
					Projectile val3 = null;
					for (int k = 0; k < 1000; k++)
					{
						val3 = Main.projectile[k];
						if (((Entity)Main.projectile[k]).active && Main.projectile[k].bobber && Main.projectile[k].owner == ((Entity)val).whoAmI)
						{
							val3 = Main.projectile[k];
							break;
						}
					}
					if (val3 != null)
					{
						NPC.NewNPC(NPC.GetBossSpawnSource(((Entity)val).whoAmI), (int)((Entity)val3).Center.X, (int)((Entity)val3).Center.Y + 100, type, 0, 0f, 0f, 0f, 0f, 255);
					}
				}
				break;
			}
		}
	}
}
