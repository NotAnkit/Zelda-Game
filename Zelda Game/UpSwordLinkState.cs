using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Zelda_Game.LinkState;

namespace Zelda_Game
{
    public class UpSwordLinkState : ILinkState
    {
        private Link player;
        private ISprite sprite;
        private int animationCount;
        public UpSwordLinkState(Link link)
        {
            player = link;
            sprite = LinkSpriteFactory.Instance.LinkWoodSwordUpAnimationSprite();
        }

        public void ChangeDirection(string direction)
        {
            if (direction.Equals("up") && animationCount == 60)
            {
                player.currentState = new UpMovingLinkState(player);
            }
            else if (direction.Equals("left") && animationCount == 60)
            {
                player.currentState = new LeftMovingLinkState(player);
            }
            else if (direction.Equals("down") && animationCount == 60)
            {
                player.currentState = new DownMovingLinkState(player);
            }
            else if (direction.Equals("right") && animationCount == 60)
            {
                player.currentState = new RightMovingLinkState(player);
            }
            else if (direction.Equals("idle") && animationCount == 60)
            {
                player.currentState = new UpIdleLinkState(player);
            }

        }

        public Vector2 ChangePosition(Vector2 location)
        {
            return location;
        }

        public void ChangeWeapon()
        {
            throw new NotImplementedException();
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            sprite.Draw(spriteBatch, location);
        }

        public void ThrowItem()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            sprite.Update();
            animationCount++;
        }

        public void UseItem()
        {
            throw new NotImplementedException();
        }

        public void UseSword()
        {
           
        }

        public void TakeDamage()
        {
            player.currentState = new LinkDamageState(player);
        }
    }
}

