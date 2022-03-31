namespace Zelda_Game
{
    public class Collision
    {
        private Game1 Game;

        public Collision(Game1 game)
        {
            Game = game;
        }

        public void Collide(Room room)
        {
            
            PlayerEnemyLoop.EnemyLoop(room.enemyList, Game.link, room.blockList);

            PlayerBlockLoop.BlockLoop(room.blockList, Game.link);

            room.itemList = ItemResponseLoop.ItemLoop(room.itemList, Game.link);

            room.doorList = PlayerDoorLoop.PlayerLoop(room, Game);

        }
    }
}
