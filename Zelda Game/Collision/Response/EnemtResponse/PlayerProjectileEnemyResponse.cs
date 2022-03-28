namespace Zelda_Game
{
    public static class PlayerProjectileEnemyResponse
    {
        public static void PlayerProjectileEnemy(Game1 Game, string direction)
        {
            if (direction == "left-right")
            {
                Game.link.TakeDamage();
                for (int i = 0; i <= 70; i++)
                {
                    if (Game.link.position.X <= 59) Game.link.position.X = 59;
                    Game.link.position.X--;
                }
                Game.link.speed = 2;

            }
        }
    }
}
