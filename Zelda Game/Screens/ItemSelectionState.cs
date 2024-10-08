﻿using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class ItemSelectionState
    {
        private readonly Texture2D Texture;
        private readonly Game1 game;
        private readonly MapPauseScreen mapPauseScreen;
        public WeaponSelection weaponSelector;
        private readonly InventoryDisplay display;


        public ItemSelectionState(Game1 game, InventoryDisplay display)
        {
            Texture = game.Content.Load<Texture2D>("Inventory");
            mapPauseScreen = new MapPauseScreen(game);
            weaponSelector = new WeaponSelection(game);
            this.game = game;
            this.display = display;
        }

        public void Update()
        {
            mapPauseScreen.Update();
            display.Update(game.link);
        }

        public void Draw(SpriteBatch spriteBatch, Link link)
        {
            Rectangle sourceRectangle = new Rectangle(1, 11, 256, 88);
            Rectangle sourceRectangle2 = new Rectangle(258, 112, 256, 88);
            Rectangle mapRectangle = new Rectangle(601, 156, 8, 16); // For Map Item
            Rectangle CompassRectangle = new Rectangle(612, 156, 15, 16); // For Compass Item

            Rectangle destinationRectangle = new Rectangle(0, 20, 448, 154);
            Rectangle destinationRectangle2 = new Rectangle(0, 182, 448, 154);

            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.Draw(Texture, destinationRectangle2, sourceRectangle2, Color.White);

            if (link.inventory.MapState())
            {
                Rectangle destinationMap = new Rectangle(78, 213, 24, 48); // For Map Item
                spriteBatch.Draw(Texture, destinationMap, mapRectangle, Color.White);
                mapPauseScreen.Draw(spriteBatch, link);
            }
            if (link.inventory.CompassState())
            {
                Rectangle destinationCompass = new Rectangle(70, 283, 45, 48); // For Compass Item
                spriteBatch.Draw(Texture, destinationCompass, CompassRectangle, Color.White);
            }
            weaponSelector.Draw(spriteBatch, link, display);

            display.Draw(spriteBatch);
        }
    }
}


