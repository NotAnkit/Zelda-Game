using System;
using Microsoft.Xna.Framework;
using Zelda_Game.LinkState;

namespace Zelda_Game
{
    public class Link
    {
        public string direction = "right";
        public ILinkState state;
        private Game1 game;
        public Link(Game1 _game)
        {
            game = _game;
            //state = RightIdleLinkState(Link link);
        }

        public void Update()
        {
            state.ChangeDirection(direction);
        }

        public void useItem()
        {

        }
    }
}
