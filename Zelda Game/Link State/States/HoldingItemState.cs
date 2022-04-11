using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Zelda_Game.LinkState;

namespace Zelda_Game
{
    public class HoldingItemState : ILinkState
    {
        private readonly Link player;
        private readonly ISprite sprite;
        public HoldingItemState(Link link)
        {
            player = link;
            sprite = LinkSpriteFactory.Instance.LinkItemAnimationSprite();
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
            
        }

        public void Update()
        {
            sprite.Update();
        }

        public IProjectile UseItem(string itemName)
        {
            return null;
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
            
        }

        public void TakeDamage()
        {
            player.currentState = new LinkDamageState(player);
        }
    }
}