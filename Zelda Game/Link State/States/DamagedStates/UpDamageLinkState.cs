using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Zelda_Game.LinkState;

namespace Zelda_Game
{
    public class UpDamageLinkState : ILinkState
    {
        private readonly Link player;
        private readonly ISprite sprite;
        private IProjectile item;
        private int animationCount;
        public UpDamageLinkState(Link link)
        {
            player = link;
            sprite = LinkSpriteFactory.Instance.LinkDamageUpAnimationSprite();
            link.LinkRectangle = new Rectangle((int)link.position.X, (int)link.position.Y, 29, 29);
        }

        public void ChangeDirection(string direction)
        {
            if (direction.Equals("up") && animationCount == 10) player.currentState = new UpMovingLinkState(player);

            else if (direction.Equals("left") && animationCount == 10) player.currentState = new LeftMovingLinkState(player);

            else if (direction.Equals("down") && animationCount == 10) player.currentState = new DownMovingLinkState(player);

            else if (direction.Equals("right") && animationCount == 10) player.currentState = new RightMovingLinkState(player);

            else if (direction.Equals("idle") && animationCount == 10) player.currentState = new UpIdleLinkState(player);
        }

        public void ChangeWeapon()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            sprite.Update();
            animationCount++;
            if (animationCount == 10)
            {
                player.inventory.LoseLife();
            }
        }

        public IProjectile UseItem(string itemName, SoundManager soundManager)
        {
            if (itemName.Equals("bomb"))
            {
                item = LinkSpriteFactory.Instance.LinkBombUpAnimationSprite();
                soundManager.PlayBomb();
            }
            else if (itemName.Equals("blue-arrow"))
            {
                item = LinkSpriteFactory.Instance.LinkBlueArrowUpAnimationSprite();
                soundManager.PlayArrow();
            }

            else if (itemName.Equals("fire"))
            {
                item = LinkSpriteFactory.Instance.LinkFireUpAnimationSprite();
                soundManager.PlayFire();
            }

            else if (itemName.Equals("green-arrow"))
            {
                item = LinkSpriteFactory.Instance.LinkGreenArrowUpAnimationSprite();
                soundManager.PlayArrow();
            }

            else if (itemName.Equals("green-boomerang"))
            {
                item = LinkSpriteFactory.Instance.LinkGreenBoomerangUpAnimationSprite();
                soundManager.PlayBoomerang();
            }

            else if (itemName.Equals("blue-boomerang"))
            {
                item = LinkSpriteFactory.Instance.LinkBlueBoomerangUpAnimationSprite();
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
            player.currentState = new UpSwordLinkState(player);
        }

        public void TakeDamage()
        {
            
        }
    }
}