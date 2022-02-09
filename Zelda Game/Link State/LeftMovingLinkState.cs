using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game.LinkState
{
    public class LeftMovingLinkState : ILinkState
    {
        private Link player;
        public LeftMovingLinkState(Link link)
        {
            player = link;
            //player.link = new LinkLeftAnimation(player.game);
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
            else if (direction.Equals("down"))
            {
                player.currentState = new DownMovingLinkState(player);
            }
            else
            {
                //Nothing
            }
        }

        public Vector2 ChangePosition(Vector2 location)
        {
            throw new NotImplementedException();
        }

        public void ChangeWeapon()
        {
            throw new NotImplementedException();
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            throw new NotImplementedException();
        }

        public void ThrowItem()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void UseItem()
        {
            throw new NotImplementedException();
        }
    }
}