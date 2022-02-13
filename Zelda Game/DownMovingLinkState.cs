using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Zelda_Game.LinkState;

namespace Zelda_Game
{
    public class DownMovingLinkState : ILinkState
    {
        private Link player;
        private ISprite sprite;
        private ISprite item;
        private Boolean useItem;
        private int animationCount;
        public DownMovingLinkState(Link link)
        {
            player = link;
            sprite = LinkSpriteFactory.Instance.LinkDownAnimationSprite();
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
            else if (direction.Equals("left"))
            {
                player.currentState = new LeftMovingLinkState(player);
            }
            else if (direction.Equals("idle"))
            {
                player.currentState = new DownIdleLinkState(player);
            }
        }

        public Vector2 ChangePosition(Vector2 location)
        {
            location.Y++;
            return location;
        }

        public void ChangeWeapon()
        {
            throw new NotImplementedException();
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            sprite.Draw(spriteBatch, location);
            if (useItem) item.Draw(spriteBatch, location);
        }

        public void ThrowItem()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            sprite.Update();
            if (useItem)
            {
                item.Update();
                animationCount++;
                if (animationCount == 60)
                {
                    useItem = false;
                    animationCount = 0;
                }

            }
        }

        public void UseItem(string itemName)
        {
            if (itemName.Equals("bomb"))
            {
                item = LinkSpriteFactory.Instance.LinkBombDownAnimationSprite();
                useItem = true;
            }
            else if (itemName.Equals("blue-arrow"))
            {
                item = LinkSpriteFactory.Instance.LinkBlueArrowDownAnimationSprite();
                useItem = true;
            }
            else if (itemName.Equals("fire"))
            {
                item = LinkSpriteFactory.Instance.LinkFireDownAnimationSprite();
                useItem = true;
            }
            else if (itemName.Equals("green-arrow"))
            {
                item = LinkSpriteFactory.Instance.LinkGreenArrowDownAnimationSprite();
                useItem = true;
            }
            else if (itemName.Equals("boomerang"))
            {
                item = LinkSpriteFactory.Instance.LinkFireDownAnimationSprite();
                useItem = true;
            }
        }

        public void UseSword()
        {
            player.currentState = new DownSwordLinkState(player);
        }

        public void TakeDamage()
        {
            player.currentState = new LinkDamageState(player);
        }
    }
}
