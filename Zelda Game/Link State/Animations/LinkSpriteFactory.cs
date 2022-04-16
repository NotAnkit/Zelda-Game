using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public class LinkSpriteFactory
    {
        private Texture2D LinkSpritesheet;
        public SoundEffect sword;
        public SoundEffect hurt;
        public SoundEffect item;
        public SoundEffect bomb;
        public SoundEffect arrow;
        public SoundEffect fire;
        public SoundEffect boomerang;

        private static readonly LinkSpriteFactory instance = new LinkSpriteFactory();

        public static LinkSpriteFactory Instance => instance;

        private LinkSpriteFactory()
        {
        }

        public void LoadAllTextures(ContentManager content)
        {
            LinkSpritesheet = content.Load<Texture2D>("LinkSheet");
            sword = content.Load<SoundEffect>("sword");
            hurt = content.Load<SoundEffect>("Hurt");
            item = content.Load<SoundEffect>("PickUpItem");
            bomb = content.Load<SoundEffect>("BombEffect");
            arrow = content.Load<SoundEffect>("UseArrow");
            fire = content.Load<SoundEffect>("Fire");
            boomerang = content.Load<SoundEffect>("Boomerang");
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

        public ISprite LinkWoodSwordDownAnimationSprite() => new LinkWoodSwordDownAnimation(LinkSpritesheet, sword);
        
        public ISprite LinkWoodSwordUpAnimationSprite() => new LinkWoodSwordUpAnimation(LinkSpritesheet, sword);

        public ISprite LinkWoodSwordLeftAnimationSprite() => new LinkWoodSwordLeftAnimation(LinkSpritesheet, sword);

        public ISprite LinkWoodSwordRightAnimationSprite() => new LinkWoodSwordRightAnimation(LinkSpritesheet, sword);

        /*
         * Link Sprites for Damage
         */

        public ISprite LinkDamageAnimationSprite() => new LinkDamagedAnimation(LinkSpritesheet, hurt);

        /*
         * Link Sprites for Item
         */

        public ISprite LinkItemAnimationSprite() => new LinkPickUpItem2(LinkSpritesheet, item);

        /*
         * Link Sprites for bomb item
         */

        public IProjectile LinkBombDownAnimationSprite() => new BombDownAnimation(LinkSpritesheet, bomb);

        public IProjectile LinkBombUpAnimationSprite() => new BombUpAnimation(LinkSpritesheet, bomb);

        public IProjectile LinkBombLeftAnimationSprite() => new BombLeftAnimation(LinkSpritesheet, bomb);

        public IProjectile LinkBombRightAnimationSprite() => new BombRightAnimation(LinkSpritesheet, bomb);

        /*
         * Link Sprites for blue arrow
         */

        public IProjectile LinkBlueArrowDownAnimationSprite() => new BlueArrowDownAnimation(LinkSpritesheet, arrow);

        public IProjectile LinkBlueArrowUpAnimationSprite() => new BlueArrowUpAnimation(LinkSpritesheet, arrow);

        public IProjectile LinkBlueArrowLeftAnimationSprite() => new BlueArrowLeftAnimation(LinkSpritesheet, arrow);

        public IProjectile LinkBlueArrowRightAnimationSprite() => new BlueArrowRightAnimation(LinkSpritesheet, arrow);

        /*
         * Link Sprites for green arrow
         */

        public IProjectile LinkGreenArrowDownAnimationSprite() => new GreenArrowDownAnimation(LinkSpritesheet, arrow);

        public IProjectile LinkGreenArrowUpAnimationSprite() => new GreenArrowUpAnimation(LinkSpritesheet, arrow);

        public IProjectile LinkGreenArrowLeftAnimationSprite() => new GreenArrowLeftAnimation(LinkSpritesheet, arrow);

        public IProjectile LinkGreenArrowRightAnimationSprite() => new GreenArrowRightAnimation(LinkSpritesheet, arrow);

        /*
         * Link Sprites for fire item
         */

        public IProjectile LinkFireRightAnimationSprite() => new FireRightAnimation(LinkSpritesheet, fire);

        public IProjectile LinkFireDownAnimationSprite() => new FireDownAnimation(LinkSpritesheet, fire);

        public IProjectile LinkFireUpAnimationSprite() => new FireUpAnimation(LinkSpritesheet, fire);

        public IProjectile LinkFireLeftAnimationSprite() => new FireLeftAnimation(LinkSpritesheet, fire);

        /*
         * Link Sprites for blue boomerang item
         */

        public IProjectile LinkBlueBoomerangRightAnimationSprite() => new BlueBoomerangRightAnimation(LinkSpritesheet, boomerang);

        public IProjectile LinkBlueBoomerangDownAnimationSprite() => new BlueBoomerangDownAnimation(LinkSpritesheet, boomerang);

        public IProjectile LinkBlueBoomerangUpAnimationSprite() => new BlueBoomerangUpAnimation(LinkSpritesheet, boomerang);

        public IProjectile LinkBlueBoomerangLeftAnimationSprite() => new BlueBoomerangLeftAnimation(LinkSpritesheet, boomerang);

        /*
         * Link Sprites for green boomerang item
         */

        public IProjectile LinkGreenBoomerangRightAnimationSprite() => new GreenBoomerangRightAnimation(LinkSpritesheet, boomerang);

        public IProjectile LinkGreenBoomerangDownAnimationSprite() => new GreenBoomerangDownAnimation(LinkSpritesheet, boomerang);
        
        public IProjectile LinkGreenBoomerangUpAnimationSprite() => new GreenBoomerangUpAnimation(LinkSpritesheet, boomerang);

        public IProjectile LinkGreenBoomerangLeftAnimationSprite() => new GreenBoomerangLeftAnimation(LinkSpritesheet, boomerang);

    }
}
