using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoonlitSouls.Projectiles
{
    public class WaterblastProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Waterblast Projectile")
        }
        public override void SetDefaults()
        {
            projectile.width = 30;
            projectile.height = 30;
            projectile.ranged = true;
            projectile.aiStyle = 8;
            projectile.alpha = 200;
            projectile.timeLeft = 300;
            projectile.penetrate = 10;
            projectile.light = 1.0f;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.magic = true;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
        }
        public override DrawAnimation GetAnimation()
        {
            return new DrawAnimationVertical(30, 30);
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(103, 60);
        }
    }
}