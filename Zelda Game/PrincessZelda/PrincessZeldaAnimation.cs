﻿//using System.Collections.Generic;
//using Microsoft.Xna.Framework;
//using Microsoft.Xna.Framework.Graphics;
//using System;

// DISCONTINUED PLAYER 2

//namespace Zelda_Game.PrincessZelda
//{
//    public class PrincessZeldaAnimation
//    {
//        public PrincessZeldaAnimation()
//        {
//        }
//        namespace Zelda_Game
//    {
//        public class Link
//        {
//            public string direction;
//            public Vector2 position;
//            private Vector2 itemPosition;
//            public int speed = 2;
//            public Dictionary<IProjectile, Vector2> items;
//            private Dictionary<IProjectile, Vector2> items2;
//            private readonly List<IProjectile> removeItems;
//            private bool useItem;
//            private IProjectile item;
//            public LinkInventory inventory;
//            private Rectangle hitbox;
//            public SoundManager soundManager;

//            public Rectangle LinkRectangle
//            {
//                get => hitbox;
//                set => hitbox = value;
//            }

//            public PrincessZelda(Vector2 location, SoundManager soundManager)
//            {
//                this.soundManager = soundManager;
//                position = location;
//                itemPosition = location;
//                useItem = false;
//                currentState = new UpIdleLinkState(this);
//                items = new Dictionary<IProjectile, Vector2>();
//                items2 = new Dictionary<IProjectile, Vector2>();
//                removeItems = new List<IProjectile>();
//                inventory = new LinkInventory();
//                hitbox = new Rectangle((int)position.X, (int)position.Y, 29, 29);
//                direction = "idle";
//            }

//            public void Update()
//            {
//                if (direction == "up" || direction == "down")
//                {
//                    hitbox = new Rectangle((int)position.X, (int)position.Y, 28, 28);
//                }
//                else
//                {
//                    hitbox = new Rectangle((int)position.X, (int)position.Y, 27, 27);
//                }
//                position = currentState.ChangePosition(position, speed);
//                currentState.Update();
//                currentState.ChangeDirection(direction);

//                if (direction == "right" && position.X > 411)
//                {
//                    currentState.ChangeDirection("idle");
//                }
//                else if (direction == "left" && position.X < 59)
//                {
//                    currentState.ChangeDirection("idle");
//                }
//                else if (direction == "down" && position.Y > 253)
//                {
//                    currentState.ChangeDirection("idle");
//                }
//                else if (direction == "up" && position.Y < 61)
//                {
//                    currentState.ChangeDirection("idle");
//                }

//                foreach (KeyValuePair<IProjectile, Vector2> item in items2)
//                {
//                    items[item.Key] = item.Key.Update(items[item.Key], item.Value);
//                }

//                foreach (IProjectile item in removeItems)
//                {
//                    items.Remove(item);
//                    items2.Remove(item);
//                }

//            }

//        }
//    }
//}
