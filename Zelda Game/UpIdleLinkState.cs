﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Zelda_Game.LinkState;

namespace Zelda_Game
{
    public class UpIdleLinkState : ILinkState
    {
        private Link player;
        private ISprite sprite;
        private ISprite item;
        private Boolean useItem;
        private int animationCount;
        public UpIdleLinkState(Link link)
        {
            player = link;
            sprite = LinkSpriteFactory.Instance.LinkUpIdleSprite();

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
            else if (direction.Equals("right"))
            {
                player.currentState = new RightMovingLinkState(player);
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
                item = LinkSpriteFactory.Instance.LinkBombUpAnimationSprite();
                useItem = true;
            }
            else if (itemName.Equals("blue-arrow"))
            {
                item = LinkSpriteFactory.Instance.LinkBlueArrowUpAnimationSprite();
                useItem = true;
            }
            else if (itemName.Equals("fire"))
            {
                item = LinkSpriteFactory.Instance.LinkFireUpAnimationSprite();
                useItem = true;
            }
            else if (itemName.Equals("green-arrow"))
            {
                item = LinkSpriteFactory.Instance.LinkGreenArrowUpAnimationSprite();
                useItem = true;
            }
            else if (itemName.Equals("boomerang"))
            {
                item = LinkSpriteFactory.Instance.LinkFireUpAnimationSprite();
                useItem = true;
            }
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            sprite.Draw(spriteBatch, location);
            if (useItem) item.Draw(spriteBatch, location);
        }

        public Vector2 ChangePosition(Vector2 location)
        {
            return location;
        }

        public void UseSword()
        {
            player.currentState = new UpSwordLinkState(player);
        }

        public void TakeDamage()
        {
            player.currentState = new LinkDamageState(player);
        }
    }
}