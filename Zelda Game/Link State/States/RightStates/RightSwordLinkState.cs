﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Zelda_Game.LinkState;

namespace Zelda_Game
{
    public class RightSwordLinkState : ILinkState
    {
        private Link player;
        private ISprite sprite;
        private ISprite item;
        private int animationCount;
        public RightSwordLinkState(Link link)
        {
            player = link;
            sprite = LinkSpriteFactory.Instance.LinkWoodSwordRightAnimationSprite();
        }

        public void ChangeDirection(string direction)
        {
            if (direction.Equals("up") && animationCount == 30) player.currentState = new UpMovingLinkState(player);
            
            else if (direction.Equals("left") && animationCount == 30) player.currentState = new LeftMovingLinkState(player);
            
            else if (direction.Equals("down") && animationCount == 30) player.currentState = new DownMovingLinkState(player);
            
            else if (direction.Equals("right") && animationCount == 30) player.currentState = new RightMovingLinkState(player);
            
            else if (direction.Equals("idle") && animationCount == 30) player.currentState = new RightIdleLinkState(player);
            
        }

        public Vector2 ChangePosition(Vector2 location, int speed)
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

        public void Update()
        {
            sprite.Update();
            animationCount++;
        }

        public ISprite UseItem(string itemName)
        {
            if (itemName.Equals("bomb")) item = LinkSpriteFactory.Instance.LinkBombRightAnimationSprite();

            else if (itemName.Equals("blue-arrow")) item = LinkSpriteFactory.Instance.LinkBlueArrowRightAnimationSprite();

            else if (itemName.Equals("fire")) item = LinkSpriteFactory.Instance.LinkFireRightAnimationSprite();

            else if (itemName.Equals("green-arrow")) item = LinkSpriteFactory.Instance.LinkGreenArrowRightAnimationSprite();

            else if (itemName.Equals("green-boomerang")) item = LinkSpriteFactory.Instance.LinkGreenBoomerangRightAnimationSprite();

            else if (itemName.Equals("blue-boomerang")) item = LinkSpriteFactory.Instance.LinkBlueBoomerangRightAnimationSprite();

            return item;
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