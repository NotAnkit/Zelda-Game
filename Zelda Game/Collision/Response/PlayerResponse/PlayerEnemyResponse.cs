using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class PlayerEnemyResponse
    {
        public static void PlayerEnemy(Link player, string direction, IEnemy enemy, Dictionary<Vector2, IEnvironment> blocks)
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
                    for (int i = 0; i <= 10; i++)
                    {
                        if (!(player.position.X < 59))
                        {
                            player.position.X -= player.speed;
                        }
                        foreach (KeyValuePair<Vector2, IEnvironment> block in blocks)
                        {
                            Rectangle linkRectangle = player.LinkRectangle;
                            Rectangle blockRectangle = block.Value.BlockRectangle();
                            direction = CollisionDetection.GetDirection(linkRectangle, blockRectangle);
                            if (direction != "none")
                            {
                                player.position.X += player.speed;
                            }

                        }
                    }
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
                    for (int i = 0; i <= 10; i++)
                    {
                        if (!(player.position.X > 411))
                        {
                            player.position.X += player.speed;
                        }
                        foreach (KeyValuePair<Vector2, IEnvironment> block in blocks)
                        {
                            Rectangle linkRectangle = player.LinkRectangle;
                            Rectangle blockRectangle = block.Value.BlockRectangle();
                            direction = CollisionDetection.GetDirection(linkRectangle, blockRectangle);
                            if (direction != "none")
                            {
                                player.position.X -= player.speed;
                            }

                        }

                    }
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
                    for (int i = 0; i <= 10; i++)
                    {
                        
                        if (!(player.position.Y > 253))
                        {
                            player.position.Y += player.speed;
                        }
                        foreach (KeyValuePair<Vector2, IEnvironment> block in blocks)
                        {
                            Rectangle linkRectangle = player.LinkRectangle;
                            Rectangle blockRectangle = block.Value.BlockRectangle();
                            direction = CollisionDetection.GetDirection(linkRectangle, blockRectangle);
                            if (direction != "none")
                            {
                                player.position.Y -= player.speed;
                            }

                        }
                    }
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
                    for (int i = 0; i <= 10; i++)
                    {
                        
                        if (!(player.position.Y < 61))
                        {
                            player.position.Y -= player.speed;
                        }
                        foreach (KeyValuePair<Vector2, IEnvironment> block in blocks)
                        {
                            Rectangle linkRectangle = player.LinkRectangle;
                            Rectangle blockRectangle = block.Value.BlockRectangle();
                            direction = CollisionDetection.GetDirection(linkRectangle, blockRectangle);
                            if (direction != "none")
                            {
                                player.position.Y += player.speed;
                            }

                        }
                    }
                }
                
            }
        }
    }
}
