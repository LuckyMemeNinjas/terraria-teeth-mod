using Terraria.ID;
using Terraria.ModLoader;

namespace TeethMod.Items
{
	public class Teeth : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Teeth");
			Tooltip.SetDefault("This is Teeth for your mouth.");
		}
		public override void SetDefaults()
		{
			item.accessory = true;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.scale = 0.25f;
			item.defense = 21;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = 1;
			item.knockBack = 21;
			item.value = 21000;
			item.rare = -12;
			item.UseSound = SoundID.Item28;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
