using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Zelda_Game.LinkState;

namespace Zelda_Game
{
    public class DownMovingLinkState : ILinkState
    {
        private Link player;
        private ISprite sprite;
        public DownMovingLinkState(Link link)
        {
            player = link;
            sprite = LinkSpriteFactory.Instance.LinkDownAnimationSprite();
        }

        public void ChangeDirection(string direction)
        {
            if (direction.Equals("up"))
            {
                player.currentState = new UpMovingLinkState(player);
            }
            else if (direction.Equals("right"))
            {
                player.currentState = new RightMovingLinkState(player);
            }
            else if (direction.Equals("left"))
            {
                player.currentState = new LeftMovingLinkState(player);
            }
            else if (direction.Equals("idle"))
            {
                player.currentState = new DownIdleLinkState(player);
            }
        }

        public Vector2 ChangePosition(Vector2 location)
        {
            location.Y++;
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
        }

        public void UseItem()
        {
            throw new NotImplementedException();
        }

        public void UseSword()
        {
            player.currentState = new DownSwordLinkState(player);
        }

        public void TakeDamage()
        {
            player.currentState = new LinkDamageState(player);
        }
    }
}
