using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Zelda_Game
{
    public class CollisionDetector
    {
        private Game1 Game;
        private readonly List<Rectangle> enemyList;
        private readonly List<IEnvironment> blockList;
        private readonly List<IItem> itemList;

        public CollisionDetector(Game1 game)
        {
            Game = game;
            //player loop through enemies
            enemyList = new List<Rectangle>();
            IEnemy bat = new Bat(game, new Vector2(250, 250))
            enemyList.Add(bat.BatRectangle);
            //enemyList.Add(new Stalfos(game, new Vector2(250, 250)));
            //enemyList.Add(new Goriya(game, new Vector2(250, 250)));
            //enemyList.Add(new Jelly(game, new Vector2(250, 250)));
            //enemyList.Add(new Hand(game, new Vector2(250, 250)));
            //enemyList.Add(new Dragon(game, new Vector2(250, 250)));

            //player loop through blocks
            blockList = new List<IEnvironment>();
            blockList.Add(new SquareBlock(Game));
            blockList.Add(new BlackBlock(Game));
            blockList.Add(new BlueSand(Game));
            blockList.Add(new BrickBlock(Game));
            blockList.Add(new LadderBlock(Game));
            blockList.Add(new NavyBlueBlock(Game));
            blockList.Add(new PushableBlock(Game));
            blockList.Add(new Stairs(Game));
            blockList.Add(new Statue1(Game));
            blockList.Add(new Statue2(Game));

            //player loop through items
            itemList = new List<IItem>();
            itemList.Add(new CompassItem(Game));
            itemList.Add(new MapItem(Game));
            itemList.Add(new KeyItem(game));
            itemList.Add(new HeartContainerItem(Game));
            itemList.Add(new TriforcePieceItem(Game));
            itemList.Add(new BowItem(Game));
            itemList.Add(new HeartItem(Game));
            itemList.Add(new RupeeItem(Game));
            itemList.Add(new ArrowItem(Game));
            itemList.Add(new BombItem(Game));
            itemList.Add(new FairyItem(Game));
            itemList.Add(new ClockItem(Game));
        }

        public void Collision()
        {
            //player loop through enemies
            Rectangle linkRectangle;
            Rectangle enemyRectangle;
            foreach (IEnemy enemy in enemyList)
            {
                linkRectangle = Game.link.LinkRectangle;
                Game.enemy.S;

            }
            //player loop through blocks

            //player loop through items
            //can just use Rectangle.Intersects because side doesn't matter
        }
    }
}
