using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Zelda_Game
{
    public class Collision
    {
        private Game1 Game;
        private readonly List<IEnemy> enemyList;
        private readonly List<IEnvironment> blockList;
        private readonly List<IItem> itemList;
        public KeyboardState userInput;

        public Collision(Game1 game)
        {
            Game = game;
            //player loop through enemies
            enemyList = new List<IEnemy>();
            enemyList.Add(new Bat(Game, new Vector2(250, 250)));
            enemyList.Add(new Stalfos(Game, new Vector2(250, 250)));
            enemyList.Add(new Goriya(Game, new Vector2(250, 250)));
            enemyList.Add(new Jelly(Game, new Vector2(250, 250)));
            enemyList.Add(new Hand(Game, new Vector2(250, 250)));
            enemyList.Add(new Dragon(Game, new Vector2(250, 250)));

            /*//player loop through blocks
            blockList = new List<IEnvironment>();
            blockList.Add(new SquareBlock(Game, new Vector2(250, 250)));
            blockList.Add(new BlackBlock(Game, new Vector2(250, 250)));
            blockList.Add(new BlueSand(Game, new Vector2(250, 250)));
            blockList.Add(new BrickBlock(Game, new Vector2(250, 250)));
            blockList.Add(new LadderBlock(Game, new Vector2(250, 250)));
            blockList.Add(new NavyBlueBlock(Game, new Vector2(250, 250)));
            blockList.Add(new PushableBlock(Game, new Vector2(250, 250)));
            blockList.Add(new Stairs(Game, new Vector2(250, 250)));
            blockList.Add(new Statue1(Game, new Vector2(250, 250)));
            blockList.Add(new Statue2(Game, new Vector2(250, 250)));*/

            //player loop through items
            itemList = new List<IItem>();
            itemList.Add(new CompassItem(Game, new Vector2(250, 250)));
            itemList.Add(new MapItem(Game, new Vector2(250, 250)));
            itemList.Add(new KeyItem(game, new Vector2(250, 250)));
            itemList.Add(new HeartContainerItem(Game, new Vector2(250, 250)));
            itemList.Add(new TriforcePieceItem(Game, new Vector2(250, 250)));
            itemList.Add(new BowItem(Game, new Vector2(250, 250)));
            itemList.Add(new HeartItem(Game, new Vector2(250, 250)));
            itemList.Add(new RupeeItem(Game, new Vector2(250, 250)));
            itemList.Add(new ArrowItem(Game, new Vector2(250, 250)));
            itemList.Add(new BombItem(Game, new Vector2(250, 250)));
            itemList.Add(new FairyItem(Game, new Vector2(250, 250)));
            itemList.Add(new ClockItem(Game, new Vector2(250, 250)));
        }

        public void Collide(Room room)
        {
            String direction;
            String linkstate;
            
            //player loop through enemies
            foreach (KeyValuePair<Vector2, IEnemy> enemy in room.enemyList)
            {
                Rectangle linkRectangle = Game.link.LinkRectangle;
                Rectangle enemyRectangle = enemy.Value.enemyRectangle();
                direction = CollisionDetection.getDirection(linkRectangle, enemyRectangle);
                //call response method here
            }

            //player loop through blocks
            foreach (KeyValuePair<Vector2, IEnvironment> block in room.blockList)
            {
                Rectangle linkRectangle = Game.link.LinkRectangle;
                Rectangle blockRectangle = block.Value.blockRectangle();
                direction = CollisionDetection.getDirection(linkRectangle, blockRectangle);
                PlayerBlockResponse.PlayerBlock(Game, direction);
            }

            foreach (KeyValuePair<Vector2, IItem> item in room.itemList)
            {
                Rectangle linkRectangle = Game.link.LinkRectangle;
                Rectangle blockRectangle = item.Value.itemRectangle();
                //direction = CollisionDetection.getDirection(linkRectangle, itemRectangle);
                //call response method here
            }

            //player loop through items
            //call response method here
        }
    }
}
