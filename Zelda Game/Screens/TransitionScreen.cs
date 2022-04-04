using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public class TransitionScreen
    {
        Texture2D rectangle;
        private float opacity;

        public TransitionScreen(Game1 game1)
        {
            rectangle = new Texture2D(game1.GraphicsDevice, 1, 1);
            rectangle.SetData(new[] { Color.White });
            opacity = .02f;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            SpriteEffects s = SpriteEffects.None;
            spriteBatch.Draw(rectangle, new Vector2(0f, 0f), null, new Color(0f, 0f, 0f, opacity), 0f, Vector2.Zero, new Vector2(503f, 345f), s, 0);
        }

        public void Update(bool fadeInOrOut)
        {
            if (fadeInOrOut)
            {
                opacity += .02f;
            }
            else
            {
                opacity -= .02f;
            }
        }
    }
}
