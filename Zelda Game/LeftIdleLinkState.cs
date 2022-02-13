using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Zelda_Game.LinkState;

namespace Zelda_Game
{
    public class LeftIdleLinkState : ILinkState
    {
        private Link player;
        private ISprite sprite;
        public LeftIdleLinkState(Link link)
        {
            player = link;
            sprite = LinkSpriteFactory.Instance.LinkLeftIdleSprite();

        }

        public void ChangeDirection(string direction)
        {
            if (direction.Equals("up"))
            {
                player.currentState = new UpMovingLinkState(player);
            }
            else if (direction.Equals("left"))
            {
                player.currentState = new LeftMovingLinkState(player);
            }
            else if (direction.Equals("down"))
            {
                player.currentState = new DownMovingLinkState(player);
            }
            else if (direction.Equals("right"))
            {
                player.currentState = new RightMovingLinkState(player);
            }

        }

        public void ChangeWeapon()
        {
            throw new NotImplementedException();
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

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            sprite.Draw(spriteBatch, location);
        }

        public Vector2 ChangePosition(Vector2 location)
        {
            return location;
        }

        public void UseSword()
        {
            player.currentState = new LeftSwordLinkState(player);
        }

        public void TakeDamage()
        {
            player.currentState = new LinkDamageState(player);
        }
    }
}