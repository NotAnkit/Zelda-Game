namespace Zelda_Game
{
    public class Collision
    {
        private RoomManager manager;
        private Link player;
        private Game1 game;

        public Collision(RoomManager manager, Link player, Game1 game1)
        {
            this.manager = manager;
            this.player = player;
            game = game1;
        }

        public void Collide(Room room)
        {
            
            PlayerEnemyLoop.EnemyLoop(room.enemyList, player, room.blockList, room.doorList, game);

            PlayerBlockLoop.BlockLoop(room.blockList, player);

            room.itemList = ItemResponseLoop.ItemLoop(room.itemList, player);

            room.doorList = PlayerProjectileLoop.ProjectileLoop(player, room.doorList, manager.roomLocation, game, manager);

            room.doorList = PlayerDoorLoop.PlayerLoop(room, game, manager);

        }
    }
}
