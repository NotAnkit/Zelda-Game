using System.Collections.Generic;
using Microsoft.Xna.Framework.Input;

namespace Zelda_Game
{
    public class KeyBoardController : IController
    {
        private Dictionary<Keys, ICommand> controllerMappings;
        private KeyboardState userInput;
        private KeyboardState previousState;
        private readonly Game1 game;

        public KeyBoardController(Game1 _game)
        {
            game = _game;
            controllerMappings = new Dictionary<Keys, ICommand>();
            RegisterCommand(Keys.Up, new MoveUp(game));
            RegisterCommand(Keys.Down, new MoveDown(game));
            RegisterCommand(Keys.Left, new MoveLeft(game));
            RegisterCommand(Keys.Right, new MoveRight(game));
            RegisterCommand(Keys.Q, new Exit(game));
            RegisterCommand(Keys.R, new Reset(game));
            RegisterCommand(Keys.P, new Pause(game));
            RegisterCommand(Keys.B, new BButton(game));
            RegisterCommand(Keys.A, new AButton(game));
            RegisterCommand(Keys.H, new HButton(game));
            RegisterCommand(Keys.V, new Idle(game));
        }

        public void RegisterCommand(Keys key, ICommand command)
        {
            controllerMappings.Add(key, command);
        }

        public void Update()
        {

            previousState = userInput;
            userInput = Keyboard.GetState();
            if (userInput.IsKeyDown(Keys.Q))
            {
                controllerMappings[Keys.Q].Execute();
            }
            if (userInput.IsKeyDown(Keys.R))
            {
                controllerMappings[Keys.R].Execute();
            }
            else if (userInput.IsKeyDown(Keys.Up))
            {
                controllerMappings[Keys.Up].Execute();

            }
            else if (userInput.IsKeyDown(Keys.Left))
            {
                controllerMappings[Keys.Left].Execute();

            }
            else if (userInput.IsKeyDown(Keys.Down))
            {
                controllerMappings[Keys.Down].Execute();

            }
            else if (userInput.IsKeyDown(Keys.Right))
            {
                controllerMappings[Keys.Right].Execute();

            }
            else if (userInput.IsKeyDown(Keys.P) && !previousState.IsKeyDown(Keys.P))
            {
                controllerMappings[Keys.P].Execute();
            }
            else if (userInput.IsKeyDown(Keys.B) && !previousState.IsKeyDown(Keys.B))
            {
                controllerMappings[Keys.B].Execute();
            }
            else if (userInput.IsKeyDown(Keys.A) && !previousState.IsKeyDown(Keys.A))
            {
                controllerMappings[Keys.A].Execute();
            }
            else if (userInput.IsKeyDown(Keys.H) && !previousState.IsKeyDown(Keys.H))
            {
                controllerMappings[Keys.H].Execute();
            }
            else if (userInput.IsKeyUp(Keys.Up) || userInput.IsKeyUp(Keys.Down) || userInput.IsKeyUp(Keys.Left) || userInput.IsKeyUp(Keys.Right))
            {
                controllerMappings[Keys.V].Execute();
            }
        }
    }
}
