using System;
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
                player.maxRunSpeed += 0.05f;
            }
            // Frostspark Boots
            else if (item.type == ItemID.FrostsparkBoots)
            {
                player.maxRunSpeed += 0.06f;
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
                player.buffImmune[BuffID.Stoned] = true;
            }
            // And Ankh Shield...
            else if (item.type == ItemID.AnkhShield)
            {
                player.buffImmune[BuffID.Stoned] = true;
                player.dash = 2;
            }
            // Cobalt Shield and Obsidian Shield dash
            else if (item.type == ItemID.CobaltShield || item.type == ItemID.ObsidianShield)
            {
                player.dash = 2;
            }

            // Avenger Emblem
            else if (item.type == ItemID.AvengerEmblem)
            {
                player.allDamage += 0.06f;
            }

            // Destroyer Emblem
            else if (item.type == ItemID.DestroyerEmblem)
            {
                player.allDamage += 0.08f;
            }

            // Hive pack
            else if (item.type == ItemID.HiveBackpack)
            {
                player.maxMinions += 1;
            }
            // Spore sac
            else if (item.type == ItemID.SporeSac)
            {
                player.maxMinions += 1;
            }

            // Brain of Confusion
            else if (item.type == ItemID.BrainOfConfusion)
            {
                player.maxMinions += 1;
                player.meleeCrit += 10;
                player.rangedCrit += 10;
                player.magicDamage += 10;
            }
        }

        public override void UpdateInventory(Item item, Player player)
        {           
            // Slime staff
            if (item.type == ItemID.SlimeStaff)
            {
                item.damage = 6;
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

            // Minishark
            else if (item.type == ItemID.Minishark)
            {
                item.damage = 5;
            }

            // Bone Glove
            else if (item.type == ItemID.BoneGlove)
            {
                item.damage = 20;
            }
        }

        public override float UseTimeMultiplier(Item item, Player player)
        {
            if (item.type == ItemID.WoodenBoomerang || item.type == ItemID.ThornChakram || item.type == ItemID.LightDisc || item.type == ItemID.IceBoomerang || item.type == ItemID.Flamarang || item.type == ItemID.EnchantedBoomerang || item.type == ItemID.Bananarang)
            {
                return 1 / player.meleeSpeed;
            }

            else return base.UseTimeMultiplier (item, player);
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
            // Gold boot - ms
            else if (item.type == ItemID.GoldGreaves)
            {
                player.moveSpeed += 0.05f;
            }

            // Platinum hat - defense
            else if (item.type == ItemID.PlatinumHelmet)
            {
                player.endurance += 0.04f;
            }
            // Platinum shirt - defense
            else if (item.type == ItemID.PlatinumChainmail)
            {
                player.endurance += 0.08f;
            }
            // Platinum boots - defense
            else if (item.type == ItemID.PlatinumGreaves)
            {
                player.endurance += 0.04f;
            }

            // Fossil hat - rogue velocity
            else if (item.type == ItemID.FossilHelm)
            {
                player.thrownVelocity *= 1.3f;
            }

            // Necro shirt - ranged damage (+5% vanilla)
            else if (item.type == ItemID.NecroBreastplate)
            {
                player.rangedDamage += 0.05f;
            }
            // Necro greaves - movement speed
            else if (item.type == ItemID.NecroGreaves)
            {
                // Remove vanilla bonus
                player.rangedDamage -= 0.05f;
                player.maxRunSpeed += 0.2f;
            }

            // Pumpkin hat - max minions
            else if (item.type == ItemID.PumpkinHelmet)
            {
                player.maxMinions += 1;
            }
            // Pumpkin shirt - max minions and damage
            else if (item.type == ItemID.PumpkinBreastplate)
            {
                player.maxMinions += 1;
                player.minionDamage += 0.08f;
            }
            // Pumpkin boots - minion damage
            else if (item.type == ItemID.PumpkinLeggings)
            {
                player.minionDamage += 0.1f;
            }

            // Bee pants - +1 minion
            else if (item.type == ItemID.BeeGreaves)
            {
                player.maxMinions += 1;
            }

            // Spider shirt - +1 minion
            else if (item.type == ItemID.SpiderBreastplate)
            {
                player.maxMinions += 1;
            }
            // Tiki shirt - +1 minion
            else if (item.type == ItemID.TikiShirt)
            {
                player.maxMinions += 1;
            }
            // Spooky shirt - +1 minion
            else if (item.type == ItemID.SpookyBreastplate)
            {
                player.maxMinions += 1;
            }
            // Stardust helmet - +1 minion
            else if (item.type == ItemID.StardustHelmet)
            {
                player.maxMinions += 1;
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
            else if (item.type == ItemID.FireGauntlet)
            {
                addTooltip(tooltips, "12% increased melee damage and speed");
            }

            // Ankh Shield, Cobalt Shield, Obsidian Shield - adds a dash
            else if (item.type == ItemID.AnkhShield || item.type == ItemID.CobaltShield || item.type == ItemID.ObsidianShield)
            {
                tooltips.Add(new TooltipLine(mod, "Tooltip2", "Allows the player to dash into the enemy"));
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
            // Gold boots - ms
            else if (item.type == ItemID.GoldGreaves)
            {
                addTooltip(tooltips, "Moderately increased movement speed");
            }

            // Plat hat - +4% DR
            else if (item.type == ItemID.PlatinumHelmet)
            {
                addTooltip(tooltips, "+4% Damage Reduction");
            }
            // Plat shirt - +8% DR
            else if (item.type == ItemID.PlatinumChainmail)
            {
                addTooltip(tooltips, "+8% Damage Reduction");
            }
            else if (item.type == ItemID.PlatinumGreaves)
            {
                addTooltip(tooltips, "+4% Damage Reduction");
            }

            // Fossil hat - +50% rogue velocity
            else if (item.type == ItemID.FossilHelm)
            {
                addTooltip(tooltips, "Greatly increased throwing velocity");
            }

            // Necro shirt - +5% ranged damage (+5% vanilla)
            else if (item.type == ItemID.NecroBreastplate)
            {
                addTooltip(tooltips, "10% increased ranged damage");
            }
            // Necro boots - ms
            else if (item.type == ItemID.NecroGreaves)
            {
                addTooltip(tooltips, "Moderately increased movement speed");
            }

            // Pumpkin hats - +1 minion
            else if (item.type == ItemID.PumpkinHelmet)
            {
                addTooltip(tooltips, "+1 max minion");
            }
            // Pumpkin shirt - +1 minion, minion damage
            else if (item.type == ItemID.PumpkinBreastplate)
            {
                addTooltip(tooltips, "+1 max minion\n8% increased minion damage");
            }
            // Pumpkin boots - 10% minion damage
            else if (item.type == ItemID.PumpkinLeggings)
            {
                addTooltip(tooltips, "+10% minion damage");
            }

            // Bee greaves - +1 minion
            else if (item.type == ItemID.BeeGreaves)
            {
                addTooltip(tooltips, "+1 max minion\n5% increased minion damage");
            }

            // Avenger emblem - 18% increased damage
            else if (item.type == ItemID.AvengerEmblem)
            {
                addTooltip(tooltips, "18% increased damage");
            }
            // Destroyer emblem - 18% increased damage
            else if (item.type == ItemID.DestroyerEmblem)
            {
                addTooltip(tooltips, "18% increased damage");
            }

            // Hive Pack +1 minion
            else if (item.type == ItemID.HiveBackpack)
            {
                addTooltip(tooltips, "+1 max minions\nIncreases the strength of friendly bees");
            }
            // Spore sac - +1 minion
            else if (item.type == ItemID.SporeSac)
            {
                addTooltip(tooltips, "+1 max minion\nSummons spores over time that will damage enemies");
            }
            // Brain of Confusion - +1 minion, +10% crit
            else if (item.type == ItemID.BrainOfConfusion)
            {
                addTooltip(tooltips, "+1 max minion\n10% increased crit chance\nMay confuse nearby enemies after being struck");
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

            // Fossil armor set
            else if (head.type == ItemID.FossilHelm && body.type == ItemID.FossilShirt && legs.type == ItemID.FossilPants)
            {
                return "FossilArmorSet";
            }

            // Obsidian armor set
            else if (head.type == ItemID.ObsidianHelm && body.type == ItemID.ObsidianShirt && legs.type == ItemID.ObsidianPants)
            {
                return "ObsidianArmorSet";
            }

            // Rich Mahogany set
            else if (head.type == ItemID.RichMahoganyHelmet && body.type == ItemID.RichMahoganyBreastplate && legs.type == ItemID.RichMahoganyGreaves)
            {
                return "RichMahoganySet";
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
                player.meleeDamage -= 0.25f;
                player.setBonus = "30% increased Melee Speed\nSet bonus: 25% reduced melee damage";
            }

            // Obsidian set causes bullets to do cool things
            else if (set.Equals("ObsidianArmorSet"))
            {
                player.GetModPlayer<RainPlayer>().setObsidian(true);
                player.rangedDamage += 0.2f;
                player.setBonus = "20% increased projectile damage";
            }

            // Fossil set prevents throwing weapon use
            else if (set.Equals("FossilArmorSet"))
            {
                player.thrownCost50 = true;
                player.thrownCost33 = true;
                player.setBonus = "67% chance to not consume thrown projectiles";
            }

            // Rich mahogany set grants +1 minion
            else if (set.Equals("RichMahoganySet"))
            {
                player.maxMinions += 1;
                player.setBonus = "+1 max minions";
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