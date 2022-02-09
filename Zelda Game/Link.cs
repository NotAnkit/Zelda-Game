using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Zelda_Game.LinkState;

namespace Zelda_Game
{
    public class Link
    {
        public string direction = "right";
        public ILinkState currentState;
        public Game1 game;
        public Link(Game1 _game, Texture2D texture)
        {
            game = _game;
            currentState = new RightIdleLinkState(this);
        }

        public void Update()
        {
            currentState.ChangeDirection(direction);
        }

        public void useItem()
        {

        }

        public void draw(SpriteBatch spriteBatch, Vector2 location)
        {
            currentState.Draw(spriteBatch, location);
        }
    }
}
