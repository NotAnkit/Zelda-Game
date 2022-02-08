using Microsoft.Xna.Framework.Input;

namespace Zelda_Game
{
    public class EnemyController : IController
    {
        /*fix so that pressing the key makes the event happen only once - not continuously*/
        public Game1 Game;
        private int numberOfEnemies = 6;
        public int currentEnemyValue = 0;

        public EnemyController(Game1 game)
        {
            Game = game;
        }

        public void Update()
        {
            KeyboardState state = Keyboard.GetState();
            if (state.IsKeyDown(Keys.O))
            {
                currentEnemyValue--;
                if (currentEnemyValue == 0)
                    currentEnemyValue = numberOfEnemies - 1;
            }
            if (state.IsKeyDown(Keys.P))
            {
                currentEnemyValue++;
                if (currentEnemyValue == numberOfEnemies)
                    currentEnemyValue = 0;
            }

            switch (currentEnemyValue)
            {
                case 0:
                    Game.enemy = new Bat(Game);
                    break;
                case 1:
                    Game.enemy = new Stalfos(Game);
                    break;
                case 2:
                    Game.enemy = new Goriya(Game);
                    break;
                case 3:
                    Game.enemy = new Jelly(Game);
                    break;
                case 4:
                    Game.enemy = new Hand(Game);
                    break;
                case 5:
                    Game.enemy = new Dragon(Game);
                    break;
            }
        }
    }
}
