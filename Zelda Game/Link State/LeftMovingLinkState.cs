using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game.LinkState
{
    public class LeftMovingLinkState : ILinkState
    {
        private Link player;
        private ISprite sprite;
        public LeftMovingLinkState(Link link)
        {
            player = link;
            sprite = LinkSpriteFactory.Instance.LinkLeftAnimationSprite();
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

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            sprite.Draw(spriteBatch, location);
        }

        public Vector2 ChangePosition(Vector2 location)
        {
            location.X--;
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
            sprite = LinkSpriteFactory.Instance.LinkWoodSwordLeftAnimationSprite();
        }
    }
}