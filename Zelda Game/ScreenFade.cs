using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public class ScreenFade
    {
        private readonly TransitionScreen screenFade;
        private int count;
        private bool fade;
        private readonly Game1 game1;

        public ScreenFade(Game1 game1)
        {
            this.game1 = game1;
            screenFade = new TransitionScreen(game1);
            count = 0;
            fade = true;
        }

        public bool Draw(SpriteBatch spriteBatch)
        {
            bool returnValue = true;
            screenFade.Draw(spriteBatch);
            if (count == 100)
            {
                fade = true;
                count = 0;
                returnValue = false;
            }
            return returnValue;
        }

        public bool Update()
        {
            screenFade.Update(fade);
            count++;
            if (count == 50)
            {
                fade = false;
                return true;
            }

            return false;
        }
    }
}
