using System;
using Zelda_Game.LinkState;

namespace Zelda_Game
{
    public class DownMovingLinkState : ILinkState
    {
        private Link player;
        public DownMovingLinkState(Link link)
        {
            player = link;
        }

        public void ChangeDirection(string direction)
        {
            if (direction.Equals("up"))
            {
                player.state = new UpMovingLinkState(player);
            }
            else if (direction.Equals("right"))
            {
                player.state = new RightMovingLinkState(player);
            }
            else if (direction.Equals("left"))
            {
                player.state = new LeftMovingLinkState(player);
            }
            else
            {
                //Nothing
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
            throw new NotImplementedException();
        }

        public void UseItem()
        {
            throw new NotImplementedException();
        }
    }
}
