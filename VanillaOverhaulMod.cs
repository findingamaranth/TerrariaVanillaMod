using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

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
            // Magic carpet gold
            ModRecipe recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Silk, 30);
            recipe.AddIngredient(ItemID.GoldBar, 8);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(ItemID.FlyingCarpet);
            recipe.AddRecipe();

            // Magic carpet plat
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.Silk, 30);
            recipe.AddIngredient(ItemID.PlatinumBar, 8);
            recipe.AddTile(TileID.Loom);
            recipe.SetResult(ItemID.FlyingCarpet);
            recipe.AddRecipe();

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
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.GoldBar, 15);
            recipe.AddIngredient(ItemID.Glass, 15);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(ItemID.Sextant);
            recipe.AddRecipe();

            // Sextant plat
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.PlatinumBar, 15);
            recipe.AddIngredient(ItemID.Glass, 15);
            recipe.AddTile(TileID.CrystalBall);
            recipe.SetResult(ItemID.Sextant);
            recipe.AddRecipe();

            // Cobalt Shield cobalt
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.CobaltBar, 20);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.CobaltShield);
            recipe.AddRecipe();

            // Cobalt Shield palladium
            recipe = new ModRecipe(this);
            recipe.AddIngredient(ItemID.PalladiumBar, 20);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(ItemID.CobaltShield);
            recipe.AddRecipe();

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
        }
    }
}