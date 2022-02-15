using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game.LinkState
{
    public class LeftMovingLinkState : ILinkState
    {
        private Link player;
        private ISprite sprite;
        private ISprite item;
        private Boolean useItem;
        private int animationCount;
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
            else if (direction.Equals("idle"))
            {
                player.currentState = new LeftIdleLinkState(player);
            }
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            sprite.Draw(spriteBatch, location);
            if (useItem) item.Draw(spriteBatch, location);
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
                item = LinkSpriteFactory.Instance.LinkBombLeftAnimationSprite();
                useItem = true;
            }
            else if (itemName.Equals("blue-arrow"))
            {
                item = LinkSpriteFactory.Instance.LinkBlueArrowLeftAnimationSprite();
                useItem = true;
            }
            else if (itemName.Equals("fire"))
            {
                item = LinkSpriteFactory.Instance.LinkFireLeftAnimationSprite();
                useItem = true;
            }
            else if (itemName.Equals("green-arrow"))
            {
                item = LinkSpriteFactory.Instance.LinkGreenArrowLeftAnimationSprite();
                useItem = true;
            }
            else if (itemName.Equals("green-boomerang"))
            {
                item = LinkSpriteFactory.Instance.LinkGreenBoomerangLeftAnimationSprite();
                useItem = true;
            }
            else if (itemName.Equals("blue-boomerang"))
            {
                item = LinkSpriteFactory.Instance.LinkBlueBoomerangLeftAnimationSprite();
                useItem = true;
            }
        }

        public void UseSword()
        {
            player.currentState = new LeftSwordLinkState(player);
        }

        public void TakeDamage()
        {
            player.currentState = new LinkDamageState(player);
        }
    }
}