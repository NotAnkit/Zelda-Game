namespace Zelda_Game
{
    public class Collisions
    {
        private readonly RoomManager manager;
        private readonly Link player;
        private readonly Game1 game;

        public Collisions(RoomManager manager, Link player, Game1 game1)
        {
            this.manager = manager;
            this.player = player;
            game = game1;
        }

        public void Collide(Room room)
        {
            PlayerEnemyLoop.EnemyLoop(room.enemyList, player, room.blockList, room.doorList, game);

            PlayerBlockLoop.BlockLoop(room.blockList, player, manager);

            room.itemList = ItemResponseLoop.ItemLoop(room.itemList, player);

            room.doorList = PlayerProjectileLoop.ProjectileLoop(player, room.doorList, manager.roomLocation, game, manager);

            room.doorList = PlayerDoorLoop.PlayerLoop(room, game, manager);

        }
    }
}