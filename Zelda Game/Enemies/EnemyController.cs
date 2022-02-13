using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Zelda_Game
{
    public class EnemyController : IController
    {
        KeyboardState state;
        public Game1 Game;
        private int numberOfEnemies = 7;
        public int currentEnemyValue = 0;

        private List<IEnemy> enemyList;

        public EnemyController(Game1 game)
        {
            Game = game;
            enemyList = new List<IEnemy>();
            enemyList.Add(new Bat(Game));
            enemyList.Add(new Stalfos(Game));
            enemyList.Add(new Goriya(Game));
            enemyList.Add(new Jelly(Game));
            enemyList.Add(new Hand(Game));
            enemyList.Add(new Dragon(Game));
            enemyList.Add(new Trap(Game));
        }

        public void Update()
        {
            state = Keyboard.GetState();
            if (state.IsKeyDown(Keys.O))
            {
                currentEnemyValue--;
                if (currentEnemyValue < 0)
                    currentEnemyValue = numberOfEnemies - 1;
                Game.enemy = enemyList[currentEnemyValue];
            }
            if (state.IsKeyDown(Keys.P))
            {
                currentEnemyValue++;
                if (currentEnemyValue >= numberOfEnemies)
                    currentEnemyValue = 0;
                Game.enemy = enemyList[currentEnemyValue];
            }

        }
    }
}
