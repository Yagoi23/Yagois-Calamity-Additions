using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using CalamityMod.BiomeManagers;
using CalamityMod.World;
using CalamityMod.NPCs.Abyss;
using YagoisCalmityAdditions.Items.Weapons.Summoner;
using CalamityMod.CalPlayer;
using YagoisCalmityAdditions.Items.Fishing;

namespace YagoisCalamityAdditions
{
    public class YagoisCalmityAdditionsPlayer : ModPlayer
    {
        public bool NuclearHerring;
        public override void ResetEffects()
        {
            NuclearHerring = false;
        }

        public override void CatchFish(FishingAttempt attempt, ref int itemDrop, ref int npcSpawn, ref AdvancedPopupRequest sonar, ref Vector2 sonarPosition)
        {
            int baitItemType = ((PlayerFishingConditions)(attempt.playerFishingConditions)).BaitItemType;
            /*int npcspawntype = ModContent.NPCType<ReaperShark>();
            if (baitItemType == ModContent.ItemType<AbyssJelly>())
            {
                float val1 = Main.rand.NextFloat(1f);                
                if(val1 == 0){ npcspawntype = ModContent.NPCType<ReaperShark>(); }
                if(val1 == 1){ npcspawntype = ModContent.NPCType<ColossalSquid>(); }
                YagoisCalamityAdditionsGlobalNPC.PlagueBaitSpawn(Player.whoAmI, npcspawntype, baitItemType);
            }*/
            if (Player.GetModPlayer<CalamityPlayer>().ZoneSulphur || Player.GetModPlayer<CalamityPlayer>().ZoneAbyss)
            {
                if (baitItemType == ModContent.ItemType<AbyssJelly>()) 
                {
                    int randomnumber = Main.rand.Next(100);
                    itemDrop = ModContent.ItemType<NuclearHerringStaff>();
                }   
            }
            if (Player.GetModPlayer<CalamityPlayer>().ZoneSulphur || Player.GetModPlayer<CalamityPlayer>().ZoneAbyss)
            {
                if (baitItemType == ModContent.ItemType<RedJellyFishBait>() || ModContent.ItemType<PurpleJellyFishBait>() ) 
                {
                    int randomnumber = Main.rand.Next(100);
                    itemDrop = ModContent.ItemType<AbyssJelly>();
                }   
            }
        }
    }
}
