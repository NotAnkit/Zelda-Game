using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Zelda_Game.LinkState;

namespace Zelda_Game
{
    public class RightMovingLinkState : ILinkState
    {
        private Link player;
        private ISprite sprite;
        private SpriteBatch _SpriteBatch;
        private Vector2 position;
        public RightMovingLinkState(Link link)
        {
            player = link;
            sprite = LinkSpriteFactory.Instance.LinkRightAnimationSprite();
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
            else if(direction.Equals("idle"))
            {
                player.currentState = new RightIdleLinkState(player);
            }
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            _SpriteBatch = spriteBatch;
            position = location;
            sprite.Draw(spriteBatch, location);
        }

        public Vector2 ChangePosition(Vector2 location)
        {
            location.X++;
            return location;
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

        public void UseSword()
        {
            player.currentState = new RightSwordLinkState(player);

        }
    }
}
