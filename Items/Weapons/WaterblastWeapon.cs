using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoonlitSouls.Items.Weapons

{
    public class WaterblastWeapon : ModItem

    {
        public override void SetStaticDefaults()

        {
            Tooltip.SetDefaults("The Waterbolt wasn't overpowered enough for you? Wow...");
            Item.staff[item.type] = true;
        }
        
        public override void SetDefaults()
        {
            item.damage = 30;
            item.magic = true;
            item.mana = 15;
            item.width = 40;
            item.height = 40;
            item.useTime = 4;
            item.useAnimation = 12;
            item.reuseDelay = 14;
            item.useStyle = 5;
            item.noMelee = true; 
            item.knockBack = 0.5;
            item.value = 10000;
            item.rare = 2;
            item.UseSound = 21;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("WaterblastProjectile");
            item.shootSpeed = 10f;
        }
        
        public override void AddRecipies()
        
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(165, 1);
            recipe.AddIngredient(1225, 10);
            recipe.AddTile(49);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
