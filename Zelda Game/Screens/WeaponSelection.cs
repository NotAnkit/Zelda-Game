using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class WeaponSelection
    {
        private readonly Texture2D Texture;
        private readonly MapPauseScreen mapPauseScreen;

        Vector2 selectionPosition = new Vector2(235, 100); // MOVE TO WEAPONSELECTION FILE

        public WeaponSelection(Game1 game)
        {
            Texture = game.Content.Load<Texture2D>("Inventory");
            mapPauseScreen = new MapPauseScreen(game);
        }

        public void Update()
        {
            mapPauseScreen.Update();
        }

        public void Draw(SpriteBatch spriteBatch, Link link)
        {
            Rectangle bombRectangle = new Rectangle(604, 137, 8, 14); // Bomb selection
            Rectangle yellowBoomerangRectangle = new Rectangle(585, 141, 5, 8); // Yellow boomerang selection
            Rectangle blueBoomerangRectangle = new Rectangle(594, 141, 5, 8); // Blue boomerang selection
            Rectangle bowRectangle = new Rectangle(633, 137, 8, 16); // Bow selection
            Rectangle greenArrowRectangle = new Rectangle(617, 137, 5, 16); // Green arrow selection
            Rectangle blueArrowRectangle = new Rectangle(626, 137, 5, 16); // Blue arrow selection

            //Code below for weapon selection rectangle
            Rectangle selectionRectangle = new Rectangle(519, 137, 16, 16);
            Rectangle selectionDestination = new Rectangle((int)selectionPosition.X, (int)selectionPosition.Y, 30, 30);
            spriteBatch.Draw(Texture, selectionDestination, selectionRectangle, Color.White);

            if (link.inventory.BombState())
            {
                Rectangle bombDestination = new Rectangle(235, 105, 15, 20);
                spriteBatch.Draw(Texture, bombDestination, bombRectangle, Color.White);
                mapPauseScreen.Draw(spriteBatch, link);
            }
            if (link.inventory.YellowBoomerangState())
            {
                Rectangle yellowbBoomerangDestination = new Rectangle(275, 105, 12, 18);
                spriteBatch.Draw(Texture, yellowbBoomerangDestination, yellowBoomerangRectangle, Color.White);
                mapPauseScreen.Draw(spriteBatch, link);
            }
            if (link.inventory.BlueBoomerangState())
            {
                Rectangle blueBoomerangDestination = new Rectangle(310, 105, 12, 18);
                spriteBatch.Draw(Texture, blueBoomerangDestination, blueBoomerangRectangle, Color.White);
                mapPauseScreen.Draw(spriteBatch, link);
            }
            if (link.inventory.BowState())
            {
                Rectangle bowDestination = new Rectangle(350, 105, 15, 20);
                spriteBatch.Draw(Texture, bowDestination, bowRectangle, Color.White);
                mapPauseScreen.Draw(spriteBatch, link);
            }
            if (link.inventory.GreenArrowState())
            {
                Rectangle greenArrowDestination = new Rectangle(235, 135, 15, 25);
                spriteBatch.Draw(Texture, greenArrowDestination, greenArrowRectangle, Color.White);
                mapPauseScreen.Draw(spriteBatch, link);
            }
            if (link.inventory.BlueArrowState())
            {
                Rectangle blueArrowDestination = new Rectangle(275, 135, 15, 25);
                spriteBatch.Draw(Texture, blueArrowDestination, blueArrowRectangle, Color.White);
                mapPauseScreen.Draw(spriteBatch, link);
            }

        }

        public void nextWeapon()
        {
            selectionPosition.X += 35;
            if (selectionPosition.X > 350)
            {
                selectionPosition.X = 235;
                selectionPosition.Y += 35;
            }
            if (selectionPosition.X > 135 && selectionPosition.Y > 135)
            {
                selectionPosition.X = 235;
                selectionPosition.Y -= 70;
            }
        }
    }
}

