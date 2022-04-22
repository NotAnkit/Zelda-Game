using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Zelda_Game.LinkState;

namespace Zelda_Game
{
    public class UpMovingLinkState : ILinkState
    {
        private readonly Link player;
        private readonly ISprite sprite;
        private IProjectile item;
        public UpMovingLinkState(Link link)
        {
            player = link;
            sprite = LinkSpriteFactory.Instance.LinkUpAnimationSprite();
            link.LinkRectangle = new Rectangle((int)link.position.X, (int)link.position.Y, 29, 29);
        }

        public void ChangeDirection(string direction)
        {
            if (direction.Equals("left")) player.currentState = new LeftMovingLinkState(player);
            
            else if (direction.Equals("right")) player.currentState = new RightMovingLinkState(player);
            
            else if (direction.Equals("down")) player.currentState = new DownMovingLinkState(player);
            
            else if (direction.Equals("idle")) player.currentState = new UpIdleLinkState(player);
        }

        public Vector2 ChangePosition(Vector2 location, int speed)
        {
            location.Y -= speed;
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
            
        }

        public IProjectile UseItem(string itemName, SoundManager soundManager)
        {
            bool temp;
            if (itemName.Equals("bomb"))
            {
                item = LinkSpriteFactory.Instance.LinkBombUpAnimationSprite();
                temp = soundManager.PlayBomb;
            }
            else if (itemName.Equals("blue-arrow"))
            {
                item = LinkSpriteFactory.Instance.LinkBlueArrowUpAnimationSprite();
                temp = soundManager.PlayArrow;
            }

            else if (itemName.Equals("fire"))
            {
                item = LinkSpriteFactory.Instance.LinkFireUpAnimationSprite();
                temp = soundManager.PlayFire;
            }

            else if (itemName.Equals("green-arrow"))
            {
                item = LinkSpriteFactory.Instance.LinkGreenArrowUpAnimationSprite();
                temp = soundManager.PlayArrow;
            }

            else if (itemName.Equals("green-boomerang"))
            {
                item = LinkSpriteFactory.Instance.LinkGreenBoomerangUpAnimationSprite();
                temp = soundManager.PlayBoomerang;
            }

            else if (itemName.Equals("blue-boomerang"))
            {
                item = LinkSpriteFactory.Instance.LinkBlueBoomerangUpAnimationSprite();
                temp = soundManager.PlayBoomerang;
            }
            return item;
        }

        public void UseSword()
        {
            player.currentState = new UpSwordLinkState(player);
        }

        public void TakeDamage()
        {
            player.currentState = new UpDamageLinkState(player);
        }
    }
}
