using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Zelda_Game.LinkState;

namespace Zelda_Game
{
    public class RightMovingLinkState : ILinkState
    {
        private readonly Link player;
        private readonly ISprite sprite;
        private IProjectile item;
        public RightMovingLinkState(Link link)
        {
            player = link;
            sprite = LinkSpriteFactory.Instance.LinkRightAnimationSprite();
            link.hitbox = new Rectangle((int)link.position.X, (int)link.position.Y, 29, 29);
        }

        public void ChangeDirection(string direction)
        {
            if (direction.Equals("up")) player.currentState = new UpMovingLinkState(player);
            
            else if (direction.Equals("left")) player.currentState = new LeftMovingLinkState(player);
            
            else if (direction.Equals("down")) player.currentState = new DownMovingLinkState(player);
            
            else if(direction.Equals("idle")) player.currentState = new RightIdleLinkState(player);
            
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            sprite.Draw(spriteBatch, location);
        }

        public Vector2 ChangePosition(Vector2 location, int speed)
        {
            location.X += speed;
            return location;
        }

        public void ChangeWeapon()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            sprite.Update();
            
        }

        public IProjectile UseItem(string itemName)
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
            player.currentState = new RightSwordLinkState(player);

        }
        public void TakeDamage()
        {
            player.currentState = new LinkDamageState(player);
        }
    }
}
