using System;
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
        public UpIdleLinkState(Link link)
        {
            player = link;
            sprite = LinkSpriteFactory.Instance.LinkUpIdleSprite();
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

        public ISprite UseItem(string itemName)
        {
            if (itemName.Equals("bomb")) item = LinkSpriteFactory.Instance.LinkBombUpAnimationSprite();

            else if (itemName.Equals("blue-arrow")) item = LinkSpriteFactory.Instance.LinkBlueArrowUpAnimationSprite();

            else if (itemName.Equals("fire")) item = LinkSpriteFactory.Instance.LinkFireUpAnimationSprite();

            else if (itemName.Equals("green-arrow")) item = LinkSpriteFactory.Instance.LinkGreenArrowUpAnimationSprite();

            else if (itemName.Equals("green-boomerang")) item = LinkSpriteFactory.Instance.LinkGreenBoomerangUpAnimationSprite();

            else if (itemName.Equals("blue-boomerang")) item = LinkSpriteFactory.Instance.LinkBlueBoomerangUpAnimationSprite();

            return item;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            sprite.Draw(spriteBatch, location);
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