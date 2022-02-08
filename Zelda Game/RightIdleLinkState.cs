using System;
using Zelda_Game.LinkState;

namespace Zelda_Game
{
    public class RightIdleLinkState : ILinkState
    {
        private Link player;
        public RightIdleLinkState(Link link)
        {
            player = link;
            player.link = new LinkRightIdle(player.game);

        }

        public void ChangeDirection(string direction)
        {
            if (direction.Equals("up"))
            {
                player.state = new UpMovingLinkState(player);
            }
            else if (direction.Equals("left"))
            {
                player.state = new LeftMovingLinkState(player);
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
