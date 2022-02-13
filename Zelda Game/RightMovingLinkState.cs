﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Zelda_Game.LinkState;

namespace Zelda_Game
{
    public class RightMovingLinkState : ILinkState
    {
        private Link player;
        private ISprite sprite;
        private ISprite item;
        private Boolean useItem;
        private int animationCount;
        public RightMovingLinkState(Link link)
        {
            player = link;
            sprite = LinkSpriteFactory.Instance.LinkRightAnimationSprite();
        }

        public void ChangeDirection(string direction)
        {
            if (direction.Equals("up"))
            {
                player.currentState = new UpMovingLinkState(player);
            }
            else if (direction.Equals("left"))
            {
                player.currentState = new LeftMovingLinkState(player);
            }
            else if (direction.Equals("down"))
            {
                player.currentState = new DownMovingLinkState(player);
            }
            else if(direction.Equals("idle"))
            {
                player.currentState = new RightIdleLinkState(player);
            }
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            sprite.Draw(spriteBatch, location);
            if (useItem) item.Draw(spriteBatch, location);
        }

        public Vector2 ChangePosition(Vector2 location)
        {
            location.X++;
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
                item = LinkSpriteFactory.Instance.LinkBombRightAnimationSprite();
                useItem = true;
            }
            else if (itemName.Equals("blue-arrow"))
            {
                item = LinkSpriteFactory.Instance.LinkBlueArrowRightAnimationSprite();
                useItem = true;
            }
            else if (itemName.Equals("fire"))
            {
                item = LinkSpriteFactory.Instance.LinkFireRightAnimationSprite();
                useItem = true;
            }
            else if (itemName.Equals("green-arrow"))
            {
                item = LinkSpriteFactory.Instance.LinkGreenArrowRightAnimationSprite();
                useItem = true;
            }
            else if (itemName.Equals("boomerang"))
            {
                item = LinkSpriteFactory.Instance.LinkFireRightAnimationSprite();
                useItem = true;
            }
        }

        public void UseSword()
        {
            player.currentState = new RightSwordLinkState(player);

        }
        public void TakeDamage()
        {
            player.currentState = new LinkDamageState(player);
        }
    }
}
