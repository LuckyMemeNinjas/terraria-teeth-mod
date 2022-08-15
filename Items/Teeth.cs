using Terraria;
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
			Item.accessory = true;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.scale = 0.25f;
			Item.defense = 21;
			Item.useTime = 25;
			Item.useAnimation = 25;
			Item.useStyle = 1;
			Item.knockBack = 21;
			Item.value = 21000;
			Item.rare = -12;
			Item.UseSound = SoundID.Item28;
			Item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}
