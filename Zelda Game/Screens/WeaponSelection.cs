using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class WeaponSelection
    {
        private readonly Texture2D Texture;
        private readonly Texture2D Texture2;


        Vector2 selectionPosition = new Vector2(230, 100); 

        public WeaponSelection(Game1 game)
        {
            Texture = game.Content.Load<Texture2D>("Inventory");
            Texture2 = game.Content.Load<Texture2D>("LinkSheet");
        }

        public void Update()
        {
            
        }

        public void Draw(SpriteBatch spriteBatch, Link link, InventoryDisplay display)
        {
            Rectangle bombRectangle = new Rectangle(604, 137, 8, 14); // Bomb selection
            Rectangle yellowBoomerangRectangle = new Rectangle(585, 141, 5, 8); // Yellow boomerang selection
            Rectangle blueBoomerangRectangle = new Rectangle(594, 141, 5, 8); // Blue boomerang selection
            Rectangle bowRectangle = new Rectangle(633, 137, 8, 16); // Bow selection
            Rectangle greenArrowRectangle = new Rectangle(617, 137, 5, 16); // Green arrow selection
            Rectangle blueArrowRectangle = new Rectangle(626, 137, 5, 16); // Blue arrow selection
            Rectangle fireRectangle = new Rectangle(191, 181, 16, 32); // Fire selection

            Rectangle selectionRectangle = new Rectangle(519, 137, 16, 16);
            Rectangle selectionDestination = new Rectangle((int)selectionPosition.X, (int)selectionPosition.Y, 30, 30);
            spriteBatch.Draw(Texture, selectionDestination, selectionRectangle, Color.White);

            if (link.inventory.BombState())
            {
                Rectangle bombDestination = new Rectangle(235, 105, 15, 15);
                spriteBatch.Draw(Texture, bombDestination, bombRectangle, Color.White);
                if(selectionPosition.X == 230 && selectionPosition.Y == 100)
                {
                    bombDestination = new Rectangle(115, 105, 20, 20);
                    spriteBatch.Draw(Texture, bombDestination, bombRectangle, Color.White);
                    display.ItemBSlot = "bomb";
                }
                
            }
            if (link.inventory.YellowBoomerangState())
            {
                Rectangle yellowbBoomerangDestination = new Rectangle(275, 105, 15, 15);
                spriteBatch.Draw(Texture, yellowbBoomerangDestination, yellowBoomerangRectangle, Color.White);
                if (selectionPosition.X == 270 && selectionPosition.Y == 100)
                {
                    yellowbBoomerangDestination = new Rectangle(115, 105, 20, 20);
                    spriteBatch.Draw(Texture, yellowbBoomerangDestination, yellowBoomerangRectangle, Color.White);
                    display.ItemBSlot = "green-boomerang";
                }

            }
            if (link.inventory.BlueBoomerangState())
            {
                Rectangle blueBoomerangDestination = new Rectangle(315, 105, 15, 15);
                spriteBatch.Draw(Texture, blueBoomerangDestination, blueBoomerangRectangle, Color.White);
                if (selectionPosition.X == 310 && selectionPosition.Y == 100)
                {
                    blueBoomerangDestination = new Rectangle(115, 105, 20, 20);
                    spriteBatch.Draw(Texture, blueBoomerangDestination, blueBoomerangRectangle, Color.White);
                    display.ItemBSlot = "blue-boomerang";
                }

            }
            if (link.inventory.BowState())
            {
                Rectangle bowDestination = new Rectangle(360, 105, 15, 15);
                spriteBatch.Draw(Texture, bowDestination, bowRectangle, Color.White);
                if (selectionPosition.X == 350 && selectionPosition.Y == 100)
                {
                    bowDestination = new Rectangle(115, 105, 20, 20);
                    spriteBatch.Draw(Texture, bowDestination, bowRectangle, Color.White);
                    display.ItemBSlot = "bow";
                }

            }
            if (link.inventory.GreenArrowState())
            {
                Rectangle greenArrowDestination = new Rectangle(238, 140, 15, 20);
                spriteBatch.Draw(Texture, greenArrowDestination, greenArrowRectangle, Color.White);
                if (selectionPosition.X == 230 && selectionPosition.Y == 135)
                {
                    greenArrowDestination = new Rectangle(115, 105, 20, 25);
                    spriteBatch.Draw(Texture, greenArrowDestination, greenArrowRectangle, Color.White);
                    display.ItemBSlot = "green-arrow";
                }

            }
            if (link.inventory.BlueArrowState())
            {
                Rectangle blueArrowDestination = new Rectangle(278, 140, 15, 20);
                spriteBatch.Draw(Texture, blueArrowDestination, blueArrowRectangle, Color.White);
                if (selectionPosition.X == 270 && selectionPosition.Y == 135)
                {
                    blueArrowDestination = new Rectangle(115, 105, 20, 25);
                    spriteBatch.Draw(Texture, blueArrowDestination, blueArrowRectangle, Color.White);
                    display.ItemBSlot = "blue-arrow";
                }

            }
            if (link.inventory.FireState())
            {
                Rectangle fireDestination = new Rectangle(318, 140, 16, 38);
                spriteBatch.Draw(Texture2, fireDestination, fireRectangle, Color.White);
                if (selectionPosition.X == 310 && selectionPosition.Y == 135)
                {
                    fireDestination = new Rectangle(115, 105, 20, 38);
                    spriteBatch.Draw(Texture2, fireDestination, fireRectangle, Color.White);
                    display.ItemBSlot = "fire";
                }

            }

        }

        public void NextWeapon()
        {
            selectionPosition.X += 40;
            if (selectionPosition.X > 350)
            {
                selectionPosition.X = 230;
                selectionPosition.Y += 35;
            }
            if (selectionPosition.X > 135 && selectionPosition.Y > 135)
            {
                selectionPosition.X = 230;
                selectionPosition.Y -= 70;
            }
        }
    }
}

