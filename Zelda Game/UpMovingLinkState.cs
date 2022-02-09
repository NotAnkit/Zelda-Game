using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Zelda_Game.LinkState;

namespace Zelda_Game
{
    public class UpMovingLinkState : ILinkState
    {
        private Link player;
        public UpMovingLinkState(Link link)
        {
            player = link;
        }

        public void ChangeDirection(string direction)
        {
            if (direction.Equals("left"))
            {
                player.currentState = new LeftMovingLinkState(player);
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
