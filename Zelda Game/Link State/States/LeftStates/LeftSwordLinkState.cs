using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Zelda_Game.LinkState;

namespace Zelda_Game
{
    public class LeftSwordLinkState : ILinkState
    {
        private Link player;
        private ISprite sprite;
        private IProjectile item;
        private int animationCount;
        public LeftSwordLinkState(Link link)
        {
            player = link;
            sprite = LinkSpriteFactory.Instance.LinkWoodSwordLeftAnimationSprite();
        }

        public void ChangeDirection(string direction)
        {
            if (direction.Equals("up") && animationCount == 30) player.currentState = new UpMovingLinkState(player);

            else if (direction.Equals("left") && animationCount == 30) player.currentState = new LeftMovingLinkState(player);
            
            else if (direction.Equals("down") && animationCount == 30) player.currentState = new DownMovingLinkState(player);
            
            else if (direction.Equals("right") && animationCount == 30) player.currentState = new RightMovingLinkState(player);
            
            else if (direction.Equals("idle") && animationCount == 30) player.currentState = new LeftIdleLinkState(player);

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

        public IProjectile UseItem(string itemName)
        {
            if (itemName.Equals("bomb")) item = LinkSpriteFactory.Instance.LinkBombLeftAnimationSprite();

            else if (itemName.Equals("blue-arrow")) item = LinkSpriteFactory.Instance.LinkBlueArrowLeftAnimationSprite();

            else if (itemName.Equals("fire")) item = LinkSpriteFactory.Instance.LinkFireLeftAnimationSprite();

            else if (itemName.Equals("green-arrow")) item = LinkSpriteFactory.Instance.LinkGreenArrowLeftAnimationSprite();

            else if (itemName.Equals("green-boomerang")) item = LinkSpriteFactory.Instance.LinkGreenBoomerangLeftAnimationSprite();

            else if (itemName.Equals("blue-boomerang")) item = LinkSpriteFactory.Instance.LinkBlueBoomerangLeftAnimationSprite();

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
