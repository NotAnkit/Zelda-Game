﻿using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public class LinkSpriteFactory
    {
        private Texture2D LinkSpritesheet;

        private static readonly LinkSpriteFactory instance = new LinkSpriteFactory();

        public static LinkSpriteFactory Instance => instance;

        private LinkSpriteFactory()
        {
        }

        public void LoadAllTextures(ContentManager content)
        {
            LinkSpritesheet = content.Load<Texture2D>("LinkSheet");
        }

        public ISprite LinkDownAnimationSprite() => new LinkDownAnimation(LinkSpritesheet);
       
        public ISprite LinkDownIdleSprite() => new LinkDownIdle(LinkSpritesheet);

        public ISprite LinkLeftAnimationSprite() => new LinkLeftAnimation(LinkSpritesheet);

        public ISprite LinkLeftIdleSprite() => new LinkLeftIdle(LinkSpritesheet);

        public ISprite LinkRightAnimationSprite() => new LinkRightAnimation(LinkSpritesheet);

        public ISprite LinkRightIdleSprite() => new LinkRightIdle(LinkSpritesheet);

        public ISprite LinkUpAnimationSprite() => new LinkUpAnimation(LinkSpritesheet);

        public ISprite LinkUpIdleSprite() => new LinkUpIdle(LinkSpritesheet);

        /*
         * Link Sprites for Wooden Sword
         */

        public ISprite LinkWoodSwordDownAnimationSprite() => new LinkWoodSwordDownAnimation(LinkSpritesheet);
        
        public ISprite LinkWoodSwordUpAnimationSprite() => new LinkWoodSwordUpAnimation(LinkSpritesheet);

        public ISprite LinkWoodSwordLeftAnimationSprite() => new LinkWoodSwordLeftAnimation(LinkSpritesheet);

        public ISprite LinkWoodSwordRightAnimationSprite() => new LinkWoodSwordRightAnimation(LinkSpritesheet);

        /*
         * Link Sprites for Damage
         */

        public ISprite LinkDamageAnimationSprite() => new LinkDamagedAnimation(LinkSpritesheet);
        public ISprite LinkDamageDownAnimationSprite() => new LinkDownDamage(LinkSpritesheet);
        public ISprite LinkDamageUpAnimationSprite() => new LinkUpDamage(LinkSpritesheet);
        public ISprite LinkDamageLeftAnimationSprite() => new LinkLeftDamage(LinkSpritesheet);
        public ISprite LinkDamageRightAnimationSprite() => new LinkRightDamage(LinkSpritesheet);

        /*
         * Link Sprites for Item
         */

        public ISprite LinkItemAnimationSprite() => new LinkPickUpItem2(LinkSpritesheet);

        /*
         * Link Sprites for bomb item
         */

        public IProjectile LinkBombDownAnimationSprite() => new BombDownAnimation(LinkSpritesheet);

        public IProjectile LinkBombUpAnimationSprite() => new BombUpAnimation(LinkSpritesheet);

        public IProjectile LinkBombLeftAnimationSprite() => new BombLeftAnimation(LinkSpritesheet);

        public IProjectile LinkBombRightAnimationSprite() => new BombRightAnimation(LinkSpritesheet);

        /*
         * Link Sprites for blue arrow
         */

        public IProjectile LinkBlueArrowDownAnimationSprite() => new BlueArrowDownAnimation(LinkSpritesheet);

        public IProjectile LinkBlueArrowUpAnimationSprite() => new BlueArrowUpAnimation(LinkSpritesheet);

        public IProjectile LinkBlueArrowLeftAnimationSprite() => new BlueArrowLeftAnimation(LinkSpritesheet);

        public IProjectile LinkBlueArrowRightAnimationSprite() => new BlueArrowRightAnimation(LinkSpritesheet);

        /*
         * Link Sprites for green arrow
         */

        public IProjectile LinkGreenArrowDownAnimationSprite() => new GreenArrowDownAnimation(LinkSpritesheet);

        public IProjectile LinkGreenArrowUpAnimationSprite() => new GreenArrowUpAnimation(LinkSpritesheet);

        public IProjectile LinkGreenArrowLeftAnimationSprite() => new GreenArrowLeftAnimation(LinkSpritesheet);

        public IProjectile LinkGreenArrowRightAnimationSprite() => new GreenArrowRightAnimation(LinkSpritesheet);

        /*
         * Link Sprites for fire item
         */

        public IProjectile LinkFireRightAnimationSprite() => new FireRightAnimation(LinkSpritesheet);

        public IProjectile LinkFireDownAnimationSprite() => new FireDownAnimation(LinkSpritesheet);

        public IProjectile LinkFireUpAnimationSprite() => new FireUpAnimation(LinkSpritesheet);

        public IProjectile LinkFireLeftAnimationSprite() => new FireLeftAnimation(LinkSpritesheet);

        /*
         * Link Sprites for blue boomerang item
         */

        public IProjectile LinkBlueBoomerangRightAnimationSprite() => new BlueBoomerangRightAnimation(LinkSpritesheet);

        public IProjectile LinkBlueBoomerangDownAnimationSprite() => new BlueBoomerangDownAnimation(LinkSpritesheet);

        public IProjectile LinkBlueBoomerangUpAnimationSprite() => new BlueBoomerangUpAnimation(LinkSpritesheet);

        public IProjectile LinkBlueBoomerangLeftAnimationSprite() => new BlueBoomerangLeftAnimation(LinkSpritesheet);

        /*
         * Link Sprites for green boomerang item
         */

        public IProjectile LinkGreenBoomerangRightAnimationSprite() => new GreenBoomerangRightAnimation(LinkSpritesheet);

        public IProjectile LinkGreenBoomerangDownAnimationSprite() => new GreenBoomerangDownAnimation(LinkSpritesheet);
        
        public IProjectile LinkGreenBoomerangUpAnimationSprite() => new GreenBoomerangUpAnimation(LinkSpritesheet);

        public IProjectile LinkGreenBoomerangLeftAnimationSprite() => new GreenBoomerangLeftAnimation(LinkSpritesheet);

    }
}
