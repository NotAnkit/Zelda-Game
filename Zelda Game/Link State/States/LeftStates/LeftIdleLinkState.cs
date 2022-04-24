﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Zelda_Game.LinkState;

namespace Zelda_Game
{
    public class LeftIdleLinkState : ILinkState
    {
        private readonly Link player;
        private readonly ISprite sprite;
        private IProjectile item;
        public LeftIdleLinkState(Link link)
        {
            player = link;
            sprite = LinkSpriteFactory.Instance.LinkLeftIdleSprite();
            link.LinkRectangle = new Rectangle((int)link.position.X, (int)link.position.Y, 29, 29);
        }

        public void ChangeDirection(string direction)
        {
            if (direction.Equals("up")) player.currentState = new UpMovingLinkState(player);
            
            else if (direction.Equals("left")) player.currentState = new LeftMovingLinkState(player);
            
            else if (direction.Equals("down")) player.currentState = new DownMovingLinkState(player);
            
            else if (direction.Equals("right")) player.currentState = new RightMovingLinkState(player);
            
        }

        public void ChangeWeapon()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            sprite.Update();
            
        }

        public IProjectile UseItem(string itemName, SoundManager soundManager)
        {
            if (itemName.Equals("bomb"))
            {
                item = LinkSpriteFactory.Instance.LinkBombLeftAnimationSprite();
                soundManager.PlayBomb();
            }
            else if (itemName.Equals("blue-arrow"))
            {
                item = LinkSpriteFactory.Instance.LinkBlueArrowLeftAnimationSprite();
                soundManager.PlayArrow();
            }

            else if (itemName.Equals("fire"))
            {
                item = LinkSpriteFactory.Instance.LinkFireLeftAnimationSprite();
                soundManager.PlayFire();
            }

            else if (itemName.Equals("green-arrow"))
            {
                item = LinkSpriteFactory.Instance.LinkGreenArrowLeftAnimationSprite();
                soundManager.PlayArrow();
            }

            else if (itemName.Equals("green-boomerang"))
            {
                item = LinkSpriteFactory.Instance.LinkGreenBoomerangLeftAnimationSprite();
                soundManager.PlayBoomerang();
            }

            else if (itemName.Equals("blue-boomerang"))
            {
                item = LinkSpriteFactory.Instance.LinkBlueBoomerangLeftAnimationSprite();
                soundManager.PlayBoomerang();
            }

            return item;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            sprite.Draw(spriteBatch, location);
            
        }

        public Vector2 ChangePosition(Vector2 location, int speed)
        {
            return location;
        }

        public void UseSword()
        {
            player.currentState = new LeftSwordLinkState(player);
        }

        public void TakeDamage()
        {
            player.currentState = new LeftDamageLinkState(player);
        }
    }
}