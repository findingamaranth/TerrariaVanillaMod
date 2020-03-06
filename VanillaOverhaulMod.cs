using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using System.Linq;
using System.Collections.Generic;

// TODO: Frostspark boot + Lava Wader upgrade
namespace VanillaOverhaulMod
{
	public class VanillaOverhaulMod : Mod
	{
		public VanillaOverhaulMod()
		{
		}

        public override void AddRecipes()
        {
            // Create equivalencies
            List<int> anyCopperBar = new List<int> { ItemID.CopperBar, ItemID.TinBar };
            List<int> anyIronBar = new List<int> { ItemID.IronBar, ItemID.LeadBar };
            List<int> anySilverBar = new List<int> { ItemID.SilverBar, ItemID.TungstenBar };
            List<int> anyGoldBar = new List<int> { ItemID.GoldBar, ItemID.PlatinumBar };
			List<int> anyCobaltBar = new List<int> {ItemID.CobaltBar, ItemID.PalladiumBar};
			List<int> anyMythrilBar = new List<int> {ItemID.MythrilBar, ItemID.OrichalcumBar};
			List<int> anyTitaniumBar = new List<int> {ItemID.TitaniumBar, ItemID.AdamantiteBar);

            // Magic carpet
			foreach (int gold in anyGoldBar) {
				ModRecipe recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Silk, 30);
				recipe.AddIngredient(gold, 8);
				recipe.AddTile(TileID.Loom);
				recipe.SetResult(ItemID.FlyingCarpet);
				recipe.AddRecipe();
			}

            // Hermes boots
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Silk, 10);
            recipe.AddIngredient(ItemID.SwiftnessPotion, 3);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(ItemID.HermesBoots);
            recipe.AddRecipe();

            // Fisherman's Pocket Guide
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Silk, 20);
            recipe.AddIngredient(ItemID.Chain);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(ItemID.FishermansGuide);
            recipe.AddRecipe();

            // Weather Radio iron
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.IronBar, 10);
            recipe.AddIngredient(ItemID.Wire, 50);
            recipe.AddIngredient(ItemID.NeptunesShell);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(ItemID.WeatherRadio);
            recipe.AddRecipe();

            // Weather Radio lead
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.LeadBar, 10);
            recipe.AddIngredient(ItemID.Wire, 50);
            recipe.AddIngredient(ItemID.NeptunesShell);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(ItemID.WeatherRadio);
            recipe.AddRecipe();

            // Sextant gold
			foreach (int gold in anyGoldBar) {
				recipe = new ModRecipe(this);
				recipe.AddIngredient(gold, 15);
				recipe.AddIngredient(ItemID.Glass, 15);
				recipe.AddTile(TileID.CrystalBall);
				recipe.SetResult(ItemID.Sextant);
				recipe.AddRecipe();
			}

            // Cobalt Shield
			foreach (int cobalt in anyCobaltBar) {
				recipe = new ModRecipe(this);
				recipe.AddIngredient(cobalt, 20);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.CobaltShield);
				recipe.AddRecipe();
			}

            // Cloud in a Bottle
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Bottle);
            recipe.AddIngredient(ItemID.Cloud);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.CloudinaBottle);
            recipe.AddRecipe();

            // Slime Staff
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Wood, 10);
            recipe.AddIngredient(ItemID.Gel, 20);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.SlimeStaff);
            recipe.AddRecipe();

            // Ankh Charm
            RecipeFinder finder = new RecipeFinder();
            finder.SetResult(ItemID.AnkhCharm);
            foreach (Recipe ankhRecipe in finder.SearchRecipes())
            {
                RecipeEditor editor = new RecipeEditor(ankhRecipe);
                editor.AddIngredient(ItemID.PocketMirror);
            }

            // Pocket Mirror
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.MagicMirror);
            recipe.AddIngredient(ItemID.SoulofLight, 10);
            recipe.AddIngredient(ItemID.Obsidian, 15);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.PocketMirror);
            recipe.AddRecipe();

            // Magic Mirror
			foreach (int iron in anyIronBar) {
				recipe = new ModRecipe(this);
				recipe.AddIngredient(iron, 10);
				recipe.AddIngredient(ItemID.Glass, 10);
				recipe.AddIngredient(ItemID.FallenStar, 10);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.MagicMirror);
				recipe.AddRecipe();
			}

            // Rod of Discord
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.SoulofLight, 20);
            recipe.AddIngredient(ItemID.FallenStar, 50);
            recipe.AddIngredient(ItemID.SoulofFright, 10);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(ItemID.RodofDiscord);
            recipe.AddRecipe();

            // Wooden Boomerang
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Wood, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.WoodenBoomerang);
            recipe.AddRecipe();

            // Enchanted Boomerang
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.WoodenBoomerang);
            recipe.AddIngredient(ItemID.FallenStar, 12);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(ItemID.EnchantedBoomerang);
            recipe.AddRecipe();

            // Aglet
			foreach (int copper in anyCopperBar) {
				recipe = new ModRecipe(this);
				recipe.AddIngredient(copper, 5);
				recipe.SetResult(ItemID.Aglet);
				recipe.AddTile(TileID.Anvils);
				recipe.AddRecipe();
			}

            // Anklet of the Wind
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.JungleSpores, 15);
            recipe.AddIngredient(ItemID.Cloud, 10);
            recipe.AddIngredient(ItemID.PinkGel, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(ItemID.AnkletoftheWind);
            recipe.AddRecipe();

            // Titan Glove
			foreach (int cobalt in anyCobaltBar) {
				recipe = new ModRecipe(this);
				recipe.AddIngredient(cobalt, 10);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.TitanGlove);
				recipe.AddRecipe();
			}
			
			// Bezoar
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Stinger, 15);
			recipe.AddIngredient(ItemID.Vine, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Bezoar);
			recipe.AddRecipe();
			
			// Adhesive Bandage
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Silk, 10);
			recipe.AddIngredient(ItemID.Gel, 50);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.AdhesiveBandage);
			recipe.AddRecipe();
			
			// Armor Polish
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Bone, 80);
			recipe.AddTile(TileID.Anvils);
			Recipe.SetResult(ItemID.ArmorPolish);
			recipe.AddRecipe();
			
			// Vitamins
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddIngredient(ItemID.Waterleaf, 5);
			recipe.AddIngredient(ItemID.Blinkroot, 5);
			recipe.AddIngredient(ItemID.Daybloom, 5);
			recipe.SetResult(ItemID.Vitamins);
			recipe.AddTile(TileID.Anvils);
			recipe.AddRecipe();
			
			// Fast Clock
			foreach (int watch in new List<int>{ ItemID.GoldWatch, ItemID.PlatinumWatch) {
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Timer1Second);
				recipe.AddIngredient(watch);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.FastClock);
				recipe.AddRecipe();
			}
			
			// Trifold Map
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Silk, 20);
			recipe.AddIngredient(ItemID.BlackInk);
			recipe.SetResult(ItemID.TrifoldMap);
			recipe.AddTile(TileID.Anvils);
			recipe.AddRecipe();
			
			// Megaphone
			foreach (int copper in anyCopperBar) {
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Wire, 10);
				recipe.AddIngredient(copper, 10);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.Megaphone);
				recipe.AddRecipe();
			}
			
			// Nazar
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Lens, 5);
			recipe.AddIngredient(ItemID.SoulOfNight, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.Nazar);
			recipe.AddRecipe();
			
			// Blindfold
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.Silk, 20);
			recipe.AddIngredient(ItemID.SoulOfNight, 10);
			recipe.SetResult(ItemID.Blindfold);
			recipe.AddTile(TileID.WorkBenches);
			recipe.AddRecipe();
        }
    }
}