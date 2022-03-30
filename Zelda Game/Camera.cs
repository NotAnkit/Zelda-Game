using System;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class Camera
    {
        public Matrix Transform { get; private set; }

        public void Follow(Link player, Game1 game)
        {
            Transform = Matrix.CreateTranslation(
                -player.position.X - (player.LinkRectangle.Width / 2),
                -player.position.Y - (player.LinkRectangle.Height / 2),
                0) * Matrix.CreateTranslation(game.windowWidth / 2, game.windowHeight / 2, 0);
        }

        public Camera()
        {

        }
    }
}
