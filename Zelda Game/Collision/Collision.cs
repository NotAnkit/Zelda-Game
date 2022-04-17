using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class Collisions
    {
        private readonly RoomManager manager;
        private readonly Link player;
        private readonly Game1 game;
        private List<Vector2> deleteEnemies;
        private List<Vector2> deleteItems;

        public Collisions(RoomManager manager, Link player, Game1 game1)
        {
            this.manager = manager;
            this.player = player;
            game = game1;
            deleteEnemies = new List<Vector2>();
            deleteItems = new List<Vector2>();
        }

        public void Collide(Room room)
        {
            Remove.RemoveRoomObjects(deleteEnemies, deleteItems, room.enemyList, room.itemList);

            deleteEnemies = PlayerEnemyLoop.EnemyLoop(room.enemyList, player, room.blockList, room.doorList, room.itemList, game);

            PlayerBlockLoop.BlockLoop(room.blockList, player, manager);

            deleteItems = ItemResponseLoop.ItemLoop(room.itemList, player, room.enemyList);

            room.doorList = PlayerProjectileLoop.ProjectileLoop(player, room.doorList, manager.roomLocation, game, manager);

            room.doorList = PlayerDoorLoop.PlayerLoop(room, game, manager);

        }

    }
}