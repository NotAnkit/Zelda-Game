using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Zelda_Game.LinkState;

namespace Zelda_Game
{
    public class LinkDamageState : ILinkState
    {
        private readonly Link player;
        private readonly ISprite sprite;
        private int animationCount;
        public LinkDamageState(Link link)
        {
            player = link;
            sprite = LinkSpriteFactory.Instance.LinkDamageAnimationSprite();
        }

        public void ChangeDirection(string direction)
        {
            if (direction.Equals("up") && animationCount == 10) player.currentState = new UpMovingLinkState(player);

            else if (direction.Equals("left") && animationCount == 10) player.currentState = new LeftMovingLinkState(player);

            else if (direction.Equals("down") && animationCount == 10) player.currentState = new DownMovingLinkState(player);

            else if (direction.Equals("right") && animationCount == 10) player.currentState = new RightMovingLinkState(player);

            else if (direction.Equals("idle") && animationCount == 10) player.currentState = new RightIdleLinkState(player);

        }

        public Vector2 ChangePosition(Vector2 location, int speed)
        {
            return location;
        }

        public void ChangeWeapon()
        {
            throw new NotImplementedException();
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            sprite.Draw(spriteBatch, location);
        }

        public void ThrowItem()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            sprite.Update();
            animationCount++;
            if (animationCount == 10)
            {
                player.inventory.LoseLife();
            }
        }

        public IProjectile UseItem(string itemName, SoundManager soundManager)
        {
            return new BlankProjectile();
        }

        public void UseSword()
        {

        }

        public void TakeDamage()
        {
        }
    }
}
