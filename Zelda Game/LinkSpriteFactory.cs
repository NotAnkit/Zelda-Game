using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public class LinkSpriteFactory
    {
        private Texture2D LinkSpritesheet;
        // More private Texture2Ds follow
        // ...

        private static LinkSpriteFactory instance = new LinkSpriteFactory();

        public static LinkSpriteFactory Instance
        {
            get
            {
                return instance;
            }
        }

        private LinkSpriteFactory()
        {
        }

        public void LoadAllTextures(ContentManager content)
        {
            LinkSpritesheet = content.Load<Texture2D>("LinkSheet");
            // More Content.Load calls follow
            //...
        }

        public ISprite LinkDownAnimationSprite()
        {
            return new LinkDownAnimation(LinkSpritesheet);
        }

        public ISprite LinkDownIdleSprite()
        {
            return new LinkDownIdle(LinkSpritesheet);
        }

        public ISprite LinkLeftAnimationSprite()
        {
            return new LinkLeftAnimation(LinkSpritesheet);
        }

        public ISprite LinkLeftIdleSprite()
        {
            return new LinkLeftIdle(LinkSpritesheet);
        }

        public ISprite LinkRightAnimationSprite()
        {
            return new LinkRightAnimation(LinkSpritesheet);
        }

        public ISprite LinkRightIdleSprite()
        {
            return new LinkRightIdle(LinkSpritesheet);
        }

        public ISprite LinkUpAnimationSprite()
        {
            return new LinkUpAnimation(LinkSpritesheet);
        }

        public ISprite LinkUpIdleSprite()
        {
            return new LinkUpIdle(LinkSpritesheet);
        }

        /*
         * Link Sprites for Wooden Sword
         */

        public ISprite LinkWoodSwordDownAnimationSprite()
        {
            return new LinkWoodSwordDownAnimation(LinkSpritesheet);
        }

        public ISprite LinkWoodSwordUpAnimationSprite()
        {
            return new LinkWoodSwordUpAnimation(LinkSpritesheet);
        }

        public ISprite LinkWoodSwordLeftAnimationSprite()
        {
            return new LinkWoodSwordLeftAnimation(LinkSpritesheet);
        }

        public ISprite LinkWoodSwordRightAnimationSprite()
        {
            return new LinkWoodSwordRightAnimation(LinkSpritesheet);
        }

        /*
         * Link Sprites for Damage
         */

        public ISprite LinkDamageAnimationSprite()
        {
            return new LinkDamagedAnimation(LinkSpritesheet);
        }

        /*
         * Link Sprites for bomb item
         */

        public ISprite LinkBombDownAnimationSprite()
        {
            return new BombDownAnimation(LinkSpritesheet);
        }

        public ISprite LinkBombUpAnimationSprite()
        {
            return new BombUpAnimation(LinkSpritesheet);
        }

        public ISprite LinkBombLeftAnimationSprite()
        {
            return new BombLeftAnimation(LinkSpritesheet);
        }

        public ISprite LinkBombRightAnimationSprite()
        {
            return new BombRightAnimation(LinkSpritesheet);
        }

        /*
         * Link Sprites for blue arrow
         */

        public ISprite LinkBlueArrowDownAnimationSprite()
        {
            return new BlueArrowDownAnimation(LinkSpritesheet);
        }

        public ISprite LinkBlueArrowUpAnimationSprite()
        {
            return new BlueArrowUpAnimation(LinkSpritesheet);
        }

        public ISprite LinkBlueArrowLeftAnimationSprite()
        {
            return new BlueArrowLeftAnimation(LinkSpritesheet);
        }

        public ISprite LinkBlueArrowRightAnimationSprite()
        {
            return new BlueArrowRightAnimation(LinkSpritesheet);
        }

        /*
         * Link Sprites for green arrow
         */

        public ISprite LinkGreenArrowDownAnimationSprite()
        {
            return new GreenArrowDownAnimation(LinkSpritesheet);
        }

        public ISprite LinkGreenArrowUpAnimationSprite()
        {
            return new GreenArrowUpAnimation(LinkSpritesheet);
        }

        public ISprite LinkGreenArrowLeftAnimationSprite()
        {
            return new GreenArrowLeftAnimation(LinkSpritesheet);
        }

        public ISprite LinkGreenArrowRightAnimationSprite()
        {
            return new GreenArrowRightAnimation(LinkSpritesheet);
        }

        /*
         * Link Sprites for fire item
         */

        public ISprite LinkFireRightAnimationSprite()
        {
            return new FireRightAnimation(LinkSpritesheet);
        }

        public ISprite LinkFireDownAnimationSprite()
        {
            return new FireDownAnimation(LinkSpritesheet);
        }

        public ISprite LinkFireUpAnimationSprite()
        {
            return new FireUpAnimation(LinkSpritesheet);
        }

        public ISprite LinkFireLeftAnimationSprite()
        {
            return new FireLeftAnimation(LinkSpritesheet);
        }

        /*
         * Link Sprites for fire item
         *

        public ISprite LinkFireRightAnimationSprite()
        {
            return new FireRightAnimation(LinkSpritesheet);
        }

        public ISprite LinkFireArrowDownAnimationSprite()
        {
            return new FireDownAnimation(LinkSpritesheet);
        }

        public ISprite LinkFireArrowUpAnimationSprite()
        {
            return new FireUpAnimation(LinkSpritesheet);
        }

        public ISprite LinkFireArrowLeftAnimationSprite()
        {
            return new FireLeftAnimation(LinkSpritesheet);
        }

        */

    }
}
