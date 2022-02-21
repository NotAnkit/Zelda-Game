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

        /*
         * Link Sprites for bomb item
         */

        public ISprite LinkBombDownAnimationSprite() => new BombDownAnimation(LinkSpritesheet);

        public ISprite LinkBombUpAnimationSprite() => new BombUpAnimation(LinkSpritesheet);

        public ISprite LinkBombLeftAnimationSprite() => new BombLeftAnimation(LinkSpritesheet);

        public ISprite LinkBombRightAnimationSprite() => new BombRightAnimation(LinkSpritesheet);

        /*
         * Link Sprites for blue arrow
         */

        public ISprite LinkBlueArrowDownAnimationSprite() => new BlueArrowDownAnimation(LinkSpritesheet);

        public ISprite LinkBlueArrowUpAnimationSprite() => new BlueArrowUpAnimation(LinkSpritesheet);

        public ISprite LinkBlueArrowLeftAnimationSprite() => new BlueArrowLeftAnimation(LinkSpritesheet);

        public ISprite LinkBlueArrowRightAnimationSprite() => new BlueArrowRightAnimation(LinkSpritesheet);

        /*
         * Link Sprites for green arrow
         */

        public ISprite LinkGreenArrowDownAnimationSprite() => new GreenArrowDownAnimation(LinkSpritesheet);

        public ISprite LinkGreenArrowUpAnimationSprite() => new GreenArrowUpAnimation(LinkSpritesheet);

        public ISprite LinkGreenArrowLeftAnimationSprite() => new GreenArrowLeftAnimation(LinkSpritesheet);

        public ISprite LinkGreenArrowRightAnimationSprite() => new GreenArrowRightAnimation(LinkSpritesheet);

        /*
         * Link Sprites for fire item
         */

        public ISprite LinkFireRightAnimationSprite() => new FireRightAnimation(LinkSpritesheet);

        public ISprite LinkFireDownAnimationSprite() => new FireDownAnimation(LinkSpritesheet);

        public ISprite LinkFireUpAnimationSprite() => new FireUpAnimation(LinkSpritesheet);

        public ISprite LinkFireLeftAnimationSprite() => new FireLeftAnimation(LinkSpritesheet);

        /*
         * Link Sprites for blue boomerang item
         */

        public ISprite LinkBlueBoomerangRightAnimationSprite() => new BlueBoomerangRightAnimation(LinkSpritesheet);

        public ISprite LinkBlueBoomerangDownAnimationSprite() => new BlueBoomerangDownAnimation(LinkSpritesheet);

        public ISprite LinkBlueBoomerangUpAnimationSprite() => new BlueBoomerangUpAnimation(LinkSpritesheet);

        public ISprite LinkBlueBoomerangLeftAnimationSprite() => new BlueBoomerangLeftAnimation(LinkSpritesheet);

        /*
         * Link Sprites for green boomerang item
         */

        public ISprite LinkGreenBoomerangRightAnimationSprite() => new GreenBoomerangRightAnimation(LinkSpritesheet);

        public ISprite LinkGreenBoomerangDownAnimationSprite() => new GreenBoomerangDownAnimation(LinkSpritesheet);
        
        public ISprite LinkGreenBoomerangUpAnimationSprite() => new GreenBoomerangUpAnimation(LinkSpritesheet);

        public ISprite LinkGreenBoomerangLeftAnimationSprite() => new GreenBoomerangLeftAnimation(LinkSpritesheet);

    }
}
