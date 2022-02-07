using System;
namespace Zelda_Game.LinkState
{
    public class LeftMovingLinkState : ILinkState
    {
        public LeftMovingLinkState()
        {
        }

        public void ChangeDirection(string direction)
        {
            if (direction.Equals("up"))
            {
                //blank.state = new UpMovingLinkState();
            }
            else if (direction.Equals("right"))
            {
                //blank.state = new RightMovingLinkState();
            }
            else if (direction.Equals("down"))
            {
                //blank.state = new DownMovingLinkState();
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