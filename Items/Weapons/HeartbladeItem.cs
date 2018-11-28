using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoonlitSouls.Items.Weapons
{
	public class Heartblade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Heartblade");
			Tooltip.SetDefault("This blade was forged from the heart of a demon.");
		}
		public override void SetDefaults()
		{
			item.damage = 100;
			item.melee = true;
			item.width = 148;
            		item.height = 148;
			item.useTime = 1;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 1;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(3335, 1);
            		recipe.AddIngredient(175, 5);
           		recipe.AddTile(77);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}


        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.OnFire, 60);
            target.AddBuff(33, 60);
            target.AddBuff(195, 60);
            target.AddBuff(196, 60);
            target.AddBuff(204, 60);
        }
    }

}
