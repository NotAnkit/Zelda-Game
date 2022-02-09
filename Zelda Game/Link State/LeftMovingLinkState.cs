using System;
namespace Zelda_Game.LinkState
{
    public class LeftMovingLinkState : ILinkState
    {
        private Link player;
        public LeftMovingLinkState(Link link)
        {
            player = link;
            player.link = new LinkLeftAnimation(player.game);
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