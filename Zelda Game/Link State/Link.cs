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
        private readonly List<IProjectile> removeItems;
        public ILinkState currentState;     
        private bool useItem;
        private IProjectile item;
        public LinkInventory inventory;
        private Rectangle hitbox;
        public SoundManager soundManager;
        private bool hurtSound;

        public Rectangle LinkRectangle
        {
            get => hitbox;
            set => hitbox = value;
        }

        public Link(Vector2 location, SoundManager soundManager)
        {
            hurtSound = false;
            this.soundManager = soundManager;
            position = location;
            itemPosition = location;
            useItem = false;
            currentState = new UpIdleLinkState(this);
            items = new Dictionary<IProjectile, Vector2>();
            items2 = new Dictionary<IProjectile, Vector2>();
            removeItems = new List<IProjectile>();
            inventory = new LinkInventory();
            hitbox = new Rectangle((int)position.X, (int)position.Y, 29, 29);
            direction = "idle";
        }

        public void Update()
        {
            hitbox = new Rectangle((int)position.X, (int)position.Y, 29, 29);
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
            if(itemName.Equals("sword"))
            {
                UseSword();
            }
            else if(itemName.Equals("bomb") && !(inventory.Bombs > 0))
            {
                
            }
            else if (itemName.Equals("blank-projectile"))
            {
            }
            else
            {
                if (itemName.Equals("bomb"))
                {
                    inventory.Bombs--;
                }
                itemPosition = position;
                itemPositionStart = position;
                item = currentState.UseItem(itemName, soundManager);
                items.Add(item, itemPosition);
                items2.Add(item, itemPositionStart);
            }
        }

        public void UseSword()
        {
            bool temp = soundManager.PlaySword;
            currentState.UseSword();
        }

        public void TakeDamage()
        {
            hurtSound = !hurtSound;
            if(hurtSound)
            {
                //bool temp = soundManager.PlayHurt;
            }
            
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

        public void ClearItems()
        {
            items = new Dictionary<IProjectile, Vector2>();
            items2 = new Dictionary<IProjectile, Vector2>();
        }
    }
}
