using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Zelda_Game
{
    public class GamePadController : IController
    {
        private GamePadState userInput;
        private GamePadState previousState;
        private GamePadCapabilities capabilities;
        private Dictionary<Buttons, ICommand> controllerMappings;
        private readonly Game1 game;

        public GamePadController(Game1 _game)
        {
            game = _game;
            capabilities = GamePad.GetCapabilities(PlayerIndex.One);
            controllerMappings = new Dictionary<Buttons, ICommand>();
            RegisterCommand(Buttons.LeftThumbstickLeft, new MoveUp(game));
            RegisterCommand(Buttons.LeftThumbstickRight, new MoveDown(game));
            RegisterCommand(Buttons.RightThumbstickLeft, new MoveLeft(game));
            RegisterCommand(Buttons.RightThumbstickRight, new MoveRight(game));
            RegisterCommand(Buttons.Y, new Exit(game));
            RegisterCommand(Buttons.B, new Reset(game));
            RegisterCommand(Buttons.Start, new Pause(game));
            RegisterCommand(Buttons.X, new BButton(game));
            RegisterCommand(Buttons.A, new AButton(game));
            RegisterCommand(Buttons.RightStick, new HButton(game));
            RegisterCommand(Buttons.LeftShoulder, new Idle(game));
        }

        public void RegisterCommand(Buttons button, ICommand command)
        {
            controllerMappings.Add(button, command);
        }

        public void Update()
        {
            previousState = userInput;
            userInput = GamePad.GetState(PlayerIndex.One);
            if (userInput.IsButtonDown(Buttons.Y) && !previousState.IsButtonDown(Buttons.Y))
            {
                controllerMappings[Buttons.Y].Execute();
            }
            if (userInput.IsButtonDown(Buttons.B) && !previousState.IsButtonDown(Buttons.B))
            {
                controllerMappings[Buttons.B].Execute();
            }
            if (capabilities.HasLeftYThumbStick && capabilities.HasLeftXThumbStick)
            {
                if (userInput.ThumbSticks.Left.Y > 0)
                    controllerMappings[Buttons.LeftThumbstickLeft].Execute();
                else if (userInput.ThumbSticks.Left.Y < 0)
                    controllerMappings[Buttons.LeftThumbstickRight].Execute();
                else if (userInput.ThumbSticks.Left.X < 0)
                    controllerMappings[Buttons.RightThumbstickLeft].Execute();
                else if (userInput.ThumbSticks.Left.X > 0)
                    controllerMappings[Buttons.RightThumbstickRight].Execute();
                else
                    controllerMappings[Buttons.LeftShoulder].Execute();

            }
            if (userInput.IsButtonDown(Buttons.Start) && !previousState.IsButtonDown(Buttons.Start))
            {
                controllerMappings[Buttons.Start].Execute();

            }
            if (userInput.IsButtonDown(Buttons.X) && !previousState.IsButtonDown(Buttons.X))
            {
                controllerMappings[Buttons.X].Execute();
            }
            if (userInput.IsButtonDown(Buttons.RightStick) && !previousState.IsButtonDown(Buttons.RightStick))
            {
                controllerMappings[Buttons.RightStick].Execute();
            }
            if (userInput.IsButtonDown(Buttons.A) && !previousState.IsButtonDown(Buttons.A))
            {
                controllerMappings[Buttons.A].Execute();
            }
          
        }
    }
}
