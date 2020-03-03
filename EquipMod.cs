﻿using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using VanillaOverhaulMod.Projectiles;

namespace VanillaOverhaulMod.Items
{
    class VanillaEquipMod : GlobalItem
    {
        public override void UpdateAccessory(Item item, Player player, bool hideVisual)
        {
            // Lightning Boots
            if (item.type == ItemID.LightningBoots)
            {
                player.moveSpeed += 0.05f;
            }
            // Frostspark Boots
            else if (item.type == ItemID.FrostsparkBoots)
            {
                player.moveSpeed += 0.06f;
            }

            // Fire Gauntlet
            else if (item.type == ItemID.FireGauntlet)
            {
                player.meleeSpeed += 0.02f;
                player.meleeDamage += 0.02f;
            }

            // Ankh Charm
            else if (item.type == ItemID.AnkhCharm)
            {
                player.stoned = false;
            }
            // And Ankh Shield...
            else if (item.type == ItemID.AnkhShield)
            {
                player.stoned = false;
            }
        }

        public override void UpdateInventory(Item item, Player player)
        {           
            // Slime staff
            if (item.type == ItemID.SlimeStaff)
            {
                item.damage = 5;
            }

            // Wooden Boomerang
            else if (item.type == ItemID.WoodenBoomerang)
            {
                item.shoot = ModContent.ProjectileType<WoodenBoomerangProj>();
                item.useTime = 32;
                item.knockBack = 1;
            }

            // Enchanted Boomerang
            else if (item.type == ItemID.EnchantedBoomerang)
            {
                item.shoot = ModContent.ProjectileType<EnchantedBoomerangProj>();
                item.useTime = 30;
                item.knockBack = 2;
            }

            // Ice Boomerang
            else if (item.type == ItemID.IceBoomerang)
            {
                item.shoot = ModContent.ProjectileType<IceBoomerangProj>();
                item.useTime = 30;
                item.knockBack = 2;
            }

            // Thorn Chakram
            else if (item.type == ItemID.ThornChakram)
            {
                item.shoot = ModContent.ProjectileType<ThornChakramProj>();
                item.useTime = 30;
                item.knockBack = 2;
            }

            // Flamarang
            else if (item.type == ItemID.Flamarang)
            {
                item.shoot = ModContent.ProjectileType<FlamarangProj>();
                item.useTime = 28;
                item.knockBack = 2;
            }

            // Bananarang
            else if (item.type == ItemID.Bananarang)
            {
                item.shoot = ModContent.ProjectileType<BananarangProj>();
                item.useTime = 28;
                item.knockBack = 2;
                item.maxStack = 1;
            }

            // Light Disc
            else if (item.type == ItemID.LightDisc)
            {
                item.shoot = ModContent.ProjectileType<LightDiscProj>();
                item.useTime = 20;
                item.maxStack = 1;
                item.knockBack = 1;
            }
        }

        public override void UpdateEquip(Item item, Player player)
        {
            // Eskimo Armor - magic damage and reduced manacost
            if (item.type == ItemID.EskimoCoat || item.type == ItemID.PinkEskimoCoat)
            {
                player.manaCost -= 0.2f;
                player.magicDamage += 0.1f;
            }
            // Eskimo Hood - magic damage and reduced manacost
            else if (item.type == ItemID.EskimoHood || item.type == ItemID.PinkEskimoCoat)
            {
                player.manaCost -= 0.1f;
                player.magicDamage += 0.05f;
            }
            // Eskimo Pants - magic damage
            else if (item.type == ItemID.EskimoPants || item.type == ItemID.PinkEskimoPants)
            {
                player.magicDamage += 0.1f;
            }

            // Cactus hat - melee crit
            else if (item.type == ItemID.CactusHelmet)
            {
                player.meleeCrit += 2;
            }
            // Cactus shirt - melee damage
            else if (item.type == ItemID.CactusBreastplate)
            {
                player.meleeDamage += 0.05f;
            }

            // Silver hat - crit
            else if (item.type == ItemID.SilverHelmet)
            {
                player.meleeCrit += 2;
                player.rangedCrit += 2;
                player.thrownCrit += 2;
                player.magicCrit += 2;
            }
            // Silver shirt - crit
            else if (item.type == ItemID.SilverChainmail)
            {
                player.meleeCrit += 3;
                player.rangedCrit += 3;
                player.thrownCrit += 3;
                player.magicCrit += 3;
            }
            // Silver boots - crit
            else if (item.type == ItemID.SilverGreaves)
            {
                player.meleeCrit += 2;
                player.rangedCrit += 2;
                player.thrownCrit += 2;
                player.magicCrit += 2;
            }

            // Tungsten hat - -movement and liferegen
            else if (item.type == ItemID.TungstenHelmet)
            {
                player.moveSpeed -= 0.1f;
                player.lifeRegen += 1;
            }
            // Tungsten shirt - -movement and liferegen
            else if (item.type == ItemID.TungstenChainmail)
            {
                player.moveSpeed -= 0.1f;
                player.lifeRegen += 2;
            }
            // Tungsten boot - -ms
            else if (item.type == ItemID.TungstenGreaves)
            {
                player.moveSpeed -= 0.2f;
                item.defense = 12;
            }

            // Gold hat - damage
            else if (item.type == ItemID.GoldHelmet || item.type == ItemID.AncientGoldHelmet)
            {
                player.allDamage += 0.05f;
            }
            // Gold shirt - damage
            else if (item.type == ItemID.GoldChainmail)
            {
                player.allDamage += 0.1f;
            }
            // Gold boot - damage
            else if (item.type == ItemID.GoldGreaves)
            {
                player.allDamage += 0.05f;
            }

            // Platinum hat - defense
            else if (item.type == ItemID.PlatinumHelmet)
            {
                item.defense = 7;
            }
            // Platinum shirt - defense
            else if (item.type == ItemID.PlatinumChainmail)
            {
                item.defense = 9;
            }
            // Platinum boots - defense
            else if (item.type == ItemID.PlatinumGreaves)
            {
                item.defense = 8;
            }

            // Fossil hat - rogue velocity
            else if (item.type == ItemID.FossilHelm)
            {
                player.thrownVelocity *= 1.5f;
            }
        } 

        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            // Bananarang and Light Disc - remove stack size
            if (item.type == ItemID.Bananarang || item.type == ItemID.LightDisc)
            {
                tooltips.Remove(tooltips.Find(x => x.Name == "Tooltip0"));
            }
            // Fire Gauntlet - 12% increased melee damage and speed
            if (item.type == ItemID.FireGauntlet)
            {
                addTooltip(tooltips, "12% increased melee damage and speed");
            }

            // Eskimo Armor - 20% reduced manacost, 10% increased magic damage
            if (item.type == ItemID.EskimoCoat || item.type == ItemID.PinkEskimoCoat)
            {
                addTooltip(tooltips, "Increases magic damage by 10% and reduces manacost by 20%");
            }
            // Eskimo Hood - 10% reduced manacost, 5% increased magic damage
            else if (item.type == ItemID.EskimoHood || item.type == ItemID.PinkEskimoHood)
            {
                addTooltip(tooltips, "Increases magic damage by 5% and reduces manacost by 10%");
            }
            // Eskimo Pants - 5% increased magic damage
            else if (item.type == ItemID.EskimoPants || item.type == ItemID.PinkEskimoPants)
            {
                addTooltip(tooltips, "Increases magic damage by 10%");
            }

            // Cactus helmet - 2% melee crit
            else if (item.type == ItemID.CactusHelmet)
            {
                addTooltip(tooltips, "Increases melee crit by 2%");
            }
            // Cactus shirt - 5% melee damage
            else if (item.type == ItemID.CactusBreastplate)
            {
                addTooltip(tooltips, "Increases melee damage by 5%");
            }

            // Silver hat - 2% crit
            else if (item.type == ItemID.SilverHelmet)
            {
                addTooltip(tooltips, "Increases crit chance by 2%");
            }
            // Silver shirt - 3% crit
            else if (item.type == ItemID.SilverChainmail)
            {
                addTooltip(tooltips, "Increases crit chance by 3%");
            }
            // Silver boots - 2% crit
            else if (item.type == ItemID.SilverGreaves)
            {
                addTooltip(tooltips, "Increases crit chance by 2%");
            }

            // Tungsten hat - -ms, +liferegen
            else if (item.type == ItemID.TungstenHelmet)
            {
                addTooltip(tooltips, "Slightly reduced movement speed and increased life regen");
            }
            // Tungsten shirt - -ms, +liferegen
            else if (item.type == ItemID.TungstenChainmail)
            {
                addTooltip(tooltips, "Moderately reduced movement speed and increased life regen");
            }
            // Tungsten boots - -ms
            else if (item.type == ItemID.TungstenGreaves)
            {
                addTooltip(tooltips, "Significantly reduced movement speed");
            }

            // Gold hat - +2 damage
            else if (item.type == ItemID.GoldHelmet || item.type == ItemID.AncientGoldHelmet)
            {
                addTooltip(tooltips, "5% increased damage");
            }
            // Gold shirt - +3 damage
            else if (item.type == ItemID.GoldChainmail)
            {
                addTooltip(tooltips, "10% increased damage");
            }
            // Gold boots - +1 damage
            else if (item.type == ItemID.GoldGreaves)
            {
                addTooltip(tooltips, "5% increased damage");
            }
            
            // Fossil hat - +50% rogue velocity
            else if (item.type == ItemID.FossilHelm)
            {
                addTooltip(tooltips, "Greatly increased throwing velocity");
            }
        }

        public override string IsArmorSet(Item head, Item body, Item legs)
        {
            // Make Eskimo armor a set. Pink and regular are interchangeable.
            if ((head.type == ItemID.EskimoHood || head.type == ItemID.PinkEskimoHood) && (body.type == ItemID.EskimoCoat || body.type == ItemID.PinkEskimoCoat) && (legs.type == ItemID.EskimoPants || legs.type == ItemID.PinkEskimoPants))
            {
                return "EskimoArmorSet";
            }

            // Cactus armor set
            else if (head.type == ItemID.CactusHelmet && body.type == ItemID.CactusBreastplate && legs.type == ItemID.CactusLeggings)
            {
                return "CactusArmorSet";
            }
            
            // Gladiator armor set
            else if (head.type == ItemID.GladiatorHelmet && body.type == ItemID.GladiatorBreastplate && legs.type == ItemID.GladiatorLeggings)
            {
                return "GladiatorArmorSet";
            }

            // Silver armor set
            else if (head.type == ItemID.SilverHelmet && body.type == ItemID.SilverChainmail && legs.type == ItemID.SilverGreaves)
            {
                return "SilverArmorSet";
            }

            // Tungsten armor set
            else if (head.type == ItemID.TungstenHelmet && body.type == ItemID.TungstenChainmail && legs.type == ItemID.TungstenGreaves)
            {
                return "TungstenArmorSet";
            }

            // Gold armor set
            else if ((head.type == ItemID.GoldHelmet || head.type == ItemID.AncientGoldHelmet) && body.type == ItemID.GoldChainmail && legs.type == ItemID.GoldGreaves)
            {
                return "GoldArmorSet";
            }

            // Obsidian armor set
            else if (head.type == ItemID.FossilHelm && body.type == ItemID.FossilShirt && legs.type == ItemID.FossilPants)
            {
                return "FossilArmorSet";
            }
            return "";
        }

        public override void UpdateArmorSet(Player player, string set)
        {

            // Eskimo armor set grants 10 defense.
            if (set.Equals("EskimoArmorSet"))
            {
                player.statDefense += 10;
                player.setBonus = "+10 defense";
            }

            // Cactus armor set grants thorns
            else if (set.Equals("CactusArmorSet"))
            {
                // Remove the vanilla bonus
                player.statDefense -= 1;
                // thorns
                player.thorns = 0.30f;
                player.setBonus = "Deal contact damage on hit";
            }

            // Gladiator armor set grants B E E F
            else if (set.Equals("GladiatorArmorSet"))
            {
                player.statDefense += 8;
                player.setBonus = "+8 defense";
            }

            // Silver armor set grants ranged crit up the wazoo
            else if (set.Equals("SilverArmorSet"))
            {
                player.rangedCrit += 33;
                player.statDefense -= 13;
                player.setBonus = "+33% ranged crit chance";
            }

            // Tungsten armor set grants fall protection and speed
            else if (set.Equals("TungstenArmorSet"))
            {
                // Remove vanilla bonus
                player.statDefense -= 3;
                player.noFallDmg = true;
                player.maxFallSpeed *= 3f;
                player.setBonus = "Heavy!\nSet bonus: Cannot take fall damage";
            }

            // Gold armor set grants melee JUICE
            else if (set.Equals("GoldArmorSet"))
            {
                // Remove vanilla bonus
                player.statDefense -= 3;
                player.meleeSpeed += 0.30f;
                player.meleeDamage -= 0.3f;
                player.setBonus = "30% increased Melee Speed\nSet bonus: 30% reduced melee damage";
            }

            // Obsidian set prevents throwing weapon use
            else if (set.Equals("FossilArmorSet"))
            {
                player.thrownCost50 = true;
                player.thrownCost33 = true;
                player.setBonus = "67% chance to not consume thrown projectiles";
            }
        }

        public void addTooltip (List<TooltipLine> tooltips, String tooltip)
        {
            if (tooltips.Find(x => x.Name == "Tooltip0") != null)
            {
                tooltips.Find(x => x.Name == "Tooltip0").text = tooltip;
            }
            else
            {
                tooltips.Add(new TooltipLine(mod, "Tooltip0", tooltip));
            }
        }
    }
}