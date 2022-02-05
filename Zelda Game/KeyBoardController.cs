using Microsoft.Xna.Framework.Input;

namespace Zelda_Game
{
    public class KeyBoardController : IController
    {
        KeyboardState userInput;
        private Game1 game;
        public KeyBoardController(Game1 _game)
        {
            game = _game;
        }
        public void Update()
        {
            userInput = Keyboard.GetState();
            if (userInput.IsKeyDown(Keys.D0) || userInput.IsKeyDown(Keys.NumPad0))
            {

            }
            else if (userInput.IsKeyDown(Keys.D1) || userInput.IsKeyDown(Keys.NumPad1))
            {
                game.sprite = new NonMovingNonAnimated();
            }
            else if (userInput.IsKeyDown(Keys.D2) || userInput.IsKeyDown(Keys.NumPad2))
            {
                game.sprite = new NonMovingAnimated();
            }
            else if (userInput.IsKeyDown(Keys.D3) || userInput.IsKeyDown(Keys.NumPad3))
            {
                game.sprite = new MovingNonAnimated();
            }
            else if (userInput.IsKeyDown(Keys.D4) || userInput.IsKeyDown(Keys.NumPad4))
            {
                game.sprite = new MovingAnimated();


            }
        }
    }
}
