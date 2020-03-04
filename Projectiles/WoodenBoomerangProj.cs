using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace VanillaOverhaulMod.Projectiles
{
    class WoodenBoomerangProj : ModProjectile
    {
        public override String Texture => "Terraria/Projectile_" + ProjectileID.WoodenBoomerang;
        public float speed;
        public float delay = 30f;
        public float deceleration = 1.5f;
        public float tileCollide = 7;

        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.WoodenBoomerang);
            projectile.aiStyle = 0;
            projectile.timeLeft = 120;
            projectile.knockBack = 1;

        }

        public override bool PreAI()
        {
            Player player = Main.player[projectile.owner];
            speed = 8f * (player.thrownVelocity + 1) / 2;
            return true;
        }

        public override void AI()
        {
            Player player = Main.player[projectile.owner];

            // Gravity
            projectile.velocity.Y += 0.02f;

            // Rotate like a vanilla boomerang
            projectile.rotation += 0.4f;
            
            // Create two vectors, one showing the direction of the projectile, the other showing the direction to the player
            Vector2 moveDir = new Vector2(projectile.velocity.X, projectile.velocity.Y);
            Vector2 dirToPlayer = new Vector2(projectile.position.X - player.position.X, projectile.position.Y - player.position.Y);

            // After 5 ticks, destroy the projectile if it's close enough to the player
            projectile.ai[0] += 1f;
            if (projectile.ai[1] >= 15)
            {
                if (dirToPlayer.Length() < 40)
                {
                    projectile.Kill();
                }
            }

            // Home in towards player after a delay
            projectile.ai[1] += 1f;
            if (projectile.ai[1] >= delay)
            {
                // Accelerate the projectile depending on the difference between the projectile direction and player direction vectors
                Vector2 accel = Vector2.Subtract(dirToPlayer, moveDir);
                accel = Vector2.Multiply(accel, 1 / (accel.Length() * deceleration));
                projectile.velocity.X -= accel.X;
                projectile.velocity.Y -= accel.Y;

                // Check if projectile is moving too fast
                moveDir = new Vector2(projectile.velocity.X, projectile.velocity.Y);
                if (moveDir.Length() > speed)
                {
                    moveDir = Vector2.Multiply(moveDir, speed / moveDir.Length());
                    projectile.velocity.X = moveDir.X;
                    projectile.velocity.Y = moveDir.Y;
                }
            } else
            {
                // Default velocity
                moveDir = new Vector2(projectile.velocity.X, projectile.velocity.Y);
                if (Math.Abs(moveDir.Length() - speed) > 1)
                {
                    moveDir = Vector2.Multiply(moveDir, speed / moveDir.Length());
                    projectile.velocity.X = moveDir.X;
                    projectile.velocity.Y = moveDir.Y;
                }
            }
        }

        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            // Handle tile collisions
            tileCollide--;
            if (tileCollide <= 0)
            {
                projectile.Kill();
            }
            else
            {
                if (projectile.velocity.X != oldVelocity.X)
                {
                    projectile.velocity.X = -oldVelocity.X / 2;
                }
                if (projectile.velocity.Y != oldVelocity.Y)
                {
                    projectile.velocity.Y = -oldVelocity.Y / 2;
                }
            }
            return false;
        }
    }
}
