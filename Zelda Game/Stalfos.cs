using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    /*animate and move left/right across screen*/
    public class Stalfos : IEnemy
    {
        public Texture2D Texture;
        private int currentFrame;
        private int totalFrames;
        private float spriteSpeed;
        private int windowHeight;
        private int windowWidth;
        private Vector2 position;

        public Stalfos(Game1 game)
        {
            Texture = game.Content.Load<Texture2D>("ItemSheet");
            currentFrame = 0;
            totalFrames = 2;
            spriteSpeed = 3f;
            windowHeight = game._graphics.PreferredBackBufferHeight;
            windowWidth = game._graphics.PreferredBackBufferWidth;
            position = new Vector2(windowWidth / 2, windowHeight / 2);
        }

        public void Update()
        {
            currentFrame++;
            if (currentFrame == totalFrames)
                currentFrame = 0;

            position.X += spriteSpeed;
            if (position.X > windowWidth)
                position.X = 0;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle = new Rectangle(0, 55, 15, 15);
            Rectangle destinationRectangle = new Rectangle((int)position.X, (int)position.Y, 15, 15);

            if (currentFrame == 0)
                sourceRectangle = new Rectangle(0, 55, 15, 15); /*normal*/
            else
                sourceRectangle = new Rectangle(0, 55, 15, 15); /*flip*/

            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

    }
}
