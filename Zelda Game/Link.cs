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
        private Game1 game;

        public Link(Game1 _game, Vector2 location)
        {
            game = _game;
            position = location;
            currentState = new RightIdleLinkState(this);
        }

        public void Update()
        {
            position = currentState.ChangePosition(position);
            currentState.Update();
            currentState.ChangeDirection(direction);
        }

        public void useItem()
        {

        }

        public void draw(SpriteBatch spriteBatch)
        {
            currentState.Draw(spriteBatch, position);
        }
    }
}
