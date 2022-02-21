using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Zelda_Game
{
    public class ItemController : IController
    { 
        private KeyboardState currentState;
        private KeyboardState previousState;
        public Game1 Game;
        private List<IItem> itemList;
        public int currentItemValue = 0;

        public ItemController(Game1 game)
        {
            Game = game;
            itemList = new List<IItem>();
            itemList.Add(new CompassItem(Game));
            itemList.Add(new MapItem(Game));
            itemList.Add(new KeyItem(game));
            itemList.Add(new HeartContainerItem(Game));
            itemList.Add(new TriforcePieceItem(Game));
            itemList.Add(new BowItem(Game));
            itemList.Add(new HeartItem(Game));
            itemList.Add(new RupeeItem(Game));
            itemList.Add(new ArrowItem(Game));
            itemList.Add(new BombItem(Game));
            itemList.Add(new FairyItem(Game));
            itemList.Add(new ClockItem(Game));
        }

        public void Update()
        {
            previousState = currentState;
            currentState = Keyboard.GetState();
            if (currentState.IsKeyDown(Keys.U) && !previousState.IsKeyDown(Keys.U))
            {
                currentItemValue++;
                if (currentItemValue >= itemList.Count)
                {
                    currentItemValue = 0;
                }
                Game.item = itemList[currentItemValue];

            }
            else if (currentState.IsKeyDown(Keys.I) && !previousState.IsKeyDown(Keys.I))
            {
                currentItemValue--;
                if (currentItemValue < 0)
                {
                    currentItemValue = itemList.Count - 1;
                }
                Game.item = itemList[currentItemValue];
            }
        }
    }
}
