using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Zelda_Game.LinkState;

namespace Zelda_Game
{
    public class Link
    {
        public string direction = "right";
        private Vector2 position;
        public ILinkState currentState;
        private SpriteBatch _spriteBatch;
        private Game1 game;
        private Boolean useItem;

        public Link(Game1 _game, Vector2 location, SpriteBatch spriteBatch)
        {
            game = _game;
            position = location;
            _spriteBatch = spriteBatch;
            useItem = false;
            currentState = new RightIdleLinkState(this);
        }

        public void Update()
        {
            position = currentState.ChangePosition(position);
            currentState.Update();
            currentState.ChangeDirection(direction);
        }

        public void UseItem(string item)
        {
            currentState.UseItem(item);
        }

        public void useSword()
        {
            currentState.UseSword();
        }

        public void TakeDamage()
        {
            currentState.TakeDamage();
        }

        public void draw(SpriteBatch spriteBatch)
        {
            currentState.Draw(spriteBatch, position);
        }
    }
}
