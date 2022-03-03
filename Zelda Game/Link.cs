﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Zelda_Game.LinkState;

namespace Zelda_Game
{
    public class Link
    {
        public string direction = "right";
        //public Rectangle PushableRectangle;
        private Vector2 position;
        private Vector2 itemPosition;
        public ILinkState currentState;     
        private bool useItem;
        private int animationCount;
        private ISprite item;

        public object Rectangle { get; internal set; }

        public Rectangle LinkRectangle
        {
            get { return new Rectangle((int)position.X, (int)position.Y, 32, 32); }
        }

        public Link(Vector2 location)
        {
            position = location;
            itemPosition = location;
            useItem = false;
            currentState = new RightIdleLinkState(this);
        }

        public void Update()
        {
            position = currentState.ChangePosition(position);
            currentState.Update();
            currentState.ChangeDirection(direction);
            if (useItem)
            {
                item.Update();
                animationCount++;
                if (animationCount == 60)
                {
                    useItem = false;
                    animationCount = 0;
                    itemPosition = position;
                }

            }

            //if (LinkRectangle.Intersects(PushableRectangle)) {
            //    position.X = 0;
            //    position.Y = 0;
            
            //}
        }

        public void UseItem(string itemName)
        {
            itemPosition = position;
            item = currentState.UseItem(itemName);
            useItem = true;
        }

        public void UseSword()
        {
            currentState.UseSword();
        }

        public void TakeDamage()
        {
            currentState.TakeDamage();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            currentState.Draw(spriteBatch, position);
            if (useItem) item.Draw(spriteBatch, itemPosition);
        }
    }
}
