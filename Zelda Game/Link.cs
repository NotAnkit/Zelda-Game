using System;
using Microsoft.Xna.Framework;
using Zelda_Game.LinkState;

namespace Zelda_Game
{
    public class Link
    {
        public string direction = "right";
        public ILinkState state;
        public Game1 game;
        public ISprite link;
        public Link(Game1 _game)
        {
            game = _game;
            state = new RightIdleLinkState(this);
        }

        public void Update()
        {
            //state.ChangeDirection(direction);
        }

        public void useItem()
        {

        }

        public void draw()
        {
            link.Draw(game._spriteBatch, game.spritePosition);
        }
    }
}
