using System;
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
                player.state = new LeftMovingLinkState(player);
            }
            else if (direction.Equals("right"))
            {
                player.state = new RightMovingLinkState(player);
            }
            else if (direction.Equals("down"))
            {
                player.state = new DownMovingLinkState(player);
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
