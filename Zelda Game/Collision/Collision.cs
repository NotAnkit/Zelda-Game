using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace Zelda_Game
{
    public class Collision
    {
        private Game1 Game;

        private List<Vector2> deleteEnemy;

        public Collision(Game1 game)
        {
            Game = game;
            deleteEnemy = new List<Vector2>();
        }

        public void Collide(Room room)
        {
            string direction = "none";
            string previousDirection;

            PlayerEnemyLoop.EnemyLoop(room.enemyList, Game.link, room.blockList);

            PlayerBlockLoop.BlockLoop(room.blockList, Game.link);

            room.itemList = ItemResponseLoop.ItemLoop(room.itemList, Game.link);
            //Player Door Collision
            foreach (IDoor door in room.doorList)
            {
                Rectangle linkRectangle = Game.link.LinkRectangle;
                Rectangle doorRectangle = door.DoorRectangle();
                previousDirection = direction;
                direction = CollisionDetection.GetDirection(linkRectangle, doorRectangle);
                if (direction == "right-left" && previousDirection != "right-left")
                {
                    Game.currentRoom++;
                    if (Game.currentRoom >= Game.roomList.Count)
                        Game.currentRoom = 0;
                    Game.link.position = new Vector2(70, 155);
                    Game.roomData = Game.roomList[Game.currentRoom];
                }
                if (direction == "left-right" && previousDirection != "left-right")
                {
                    Game.currentRoom--;
                    if (Game.currentRoom < 0)
                        Game.currentRoom = Game.roomList.Count - 1;
                    Game.link.position = new Vector2(379, 155);
                    Game.roomData = Game.roomList[Game.currentRoom];
                }
                if (Game.currentRoom == 16)
                {
                    Game.currentRoom = 0;
                }
            }

        }
    }
}
