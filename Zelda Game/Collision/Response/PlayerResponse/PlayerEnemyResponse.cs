namespace Zelda_Game
{
    public class PlayerEnemyResponse
    {
        public static void PlayerEnemy(Link player, string direction, IEnemy enemy)
        {
            if (direction == "left-right")
            {
                if(player.currentState is RightSwordLinkState)
                {
                    enemy.DecreaseHealth();
                }
                else
                {
                    player.TakeDamage();
                    for (int i = 0; i <= 70; i++)
                    {

                    }
                    player.speed = 2;
                }
                

            }
            if (direction == "right-left")
            {
                if (player.currentState is LeftSwordLinkState)
                {
                    enemy.DecreaseHealth();
                }
                else
                {
                    player.TakeDamage();
                    for (int i = 0; i <= 70; i++)
                    {

                    }
                    player.speed = 2;
                }
                
            }
            if (direction == "top-bottom")
            {
                if (player.currentState is UpSwordLinkState)
                {
                    enemy.DecreaseHealth();
                }
                else
                {
                    player.TakeDamage();
                    for (int i = 0; i <= 70; i++)
                    {

                    }
                    player.speed = 2;
                }
                
            }
            if (direction == "bottom-top")
            {
                if (player.currentState is DownSwordLinkState)
                {
                    enemy.DecreaseHealth();
                }
                else
                {
                    player.TakeDamage();
                    for (int i = 0; i <= 70; i++)
                    {

                    }
                    player.speed = 2;
                }
                
            }
        }
    }
}
