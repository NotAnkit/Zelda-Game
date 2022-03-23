using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Zelda_Game.LinkState;

namespace Zelda_Game
{
    public class Link
    {
        public string direction;
        public Vector2 position;
        private Vector2 itemPositionStart;
        private Vector2 itemPosition;
        public int speed = 2;
        public Dictionary<IProjectile, Vector2> items;
        private Dictionary<IProjectile, Vector2> items2;
        private List<IProjectile> removeItems;
        public ILinkState currentState;     
        private bool useItem;
        private IProjectile item;
        public List<IItem> inventory;


        public Rectangle LinkRectangle
        {
            get { return new Rectangle((int)position.X, (int)position.Y, 29, 29); }
        }

        public Link(Vector2 location)
        {
            position = location;
            itemPosition = location;
            useItem = false;
            currentState = new RightIdleLinkState(this);
            items = new Dictionary<IProjectile, Vector2>();
            items2 = new Dictionary<IProjectile, Vector2>();
            removeItems = new List<IProjectile>();
            inventory = new List<IItem>();
        }

        public void Update()
        {
            position = currentState.ChangePosition(position, speed);
            currentState.Update();
            currentState.ChangeDirection(direction);

            if (direction == "right" && position.X > 411)
            {
                currentState.ChangeDirection("idle");
            }
            else if (direction == "left" && position.X < 59)
            {
                currentState.ChangeDirection("idle");
            }
            else if (direction == "down" && position.Y > 253)
            {
                currentState.ChangeDirection("idle");
            }
            else if(direction == "up" && position.Y < 61)
            {
                currentState.ChangeDirection("idle");
            }

            foreach (KeyValuePair<IProjectile, Vector2> item in items2)
            {
                items[item.Key] = item.Key.Update(items[item.Key], item.Value);
            }

            foreach(IProjectile item in removeItems)
            {
                items.Remove(item);
                items2.Remove(item);
            }
         
        }

        public void UseItem(string itemName)
        {
            itemPosition = position;
            itemPositionStart = position;
            item = currentState.UseItem(itemName);
            items.Add(item, itemPosition);
            items2.Add(item, itemPositionStart);

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

            foreach (KeyValuePair<IProjectile, Vector2> item in items)
            {
                useItem = item.Key.Draw(spriteBatch, item.Value, items2[item.Key]);
                if (useItem) removeItems.Add(item.Key);
            }
        }
    }
}
