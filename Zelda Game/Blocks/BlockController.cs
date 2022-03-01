using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Zelda_Game
{
    public class BlockController : IController
    { 
        private KeyboardState currentState;
        private KeyboardState previousState;
        public Game1 Game;
        private readonly List<IEnvironment> blockList;
        public int currentBlockValue = 0;

        public BlockController(Game1 game)
        {
            Game = game;
            blockList = new List<IEnvironment>();
            blockList.Add(new SquareBlock(Game));
            blockList.Add(new BlackBlock(Game));
            blockList.Add(new BlueSand(Game));
            blockList.Add(new BrickBlock(Game));
            blockList.Add(new LadderBlock(Game));
            blockList.Add(new NavyBlueBlock(Game));
            blockList.Add(new PushableBlock(Game));
            blockList.Add(new Stairs(Game));
            blockList.Add(new Statue1(Game));
            blockList.Add(new Statue2(Game));
        }

        public void Update()
        {
            previousState = currentState;
            currentState = Keyboard.GetState();
            if (currentState.IsKeyDown(Keys.T) && !previousState.IsKeyDown(Keys.T))
            {
                currentBlockValue++;
                if (currentBlockValue >= blockList.Count)
                {
                    currentBlockValue = 0;
                }
                Game.environment = blockList[currentBlockValue];

            }
            if (currentState.IsKeyDown(Keys.Y) && !previousState.IsKeyDown(Keys.Y))
            {
                currentBlockValue--;
                if (currentBlockValue < 0)
                {
                    currentBlockValue = blockList.Count - 1;
                }
                Game.environment = blockList[currentBlockValue];
            }
        }
    }
}
