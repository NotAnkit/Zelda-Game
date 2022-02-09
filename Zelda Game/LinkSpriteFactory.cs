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

        public ISprite LinkWoodSwordDownAnimationSprite()
        {
            return new LinkWoodSwordDownAnimation(LinkSpritesheet);
        }

        // More public ISprite returning methods follow
        // ...
    }
}
