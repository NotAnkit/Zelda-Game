using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class ItemSelectionState
    {
        private readonly Texture2D Texture;
        private readonly MapPauseScreen mapPauseScreen;

        public ItemSelectionState(Game1 game)
        {
            Texture = game.Content.Load<Texture2D>("Inventory");
            //Font = game.Content.Load<SpriteFont>("SpriteFont");
            mapPauseScreen = new MapPauseScreen(game);
        }

        public void Update()
        {
            mapPauseScreen.Update();
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

            //Code below added for weaponselection file testing purposes

            Rectangle bombRectangle = new Rectangle(604, 137, 8, 14); // For bomb item
            Rectangle boomerangRectangle = new Rectangle(585, 141, 5, 8); // For boomerang item

            //Rectangle destinationBomb = new Rectangle(90, 90, 20, 20); // Change values
            //Rectangle destinationBoomerang = new Rectangle(100, 100, 20, 20); // Fill with something

            //spriteBatch.Draw(Texture, destinationBomb, bombRectangle, Color.White);
            //spriteBatch.Draw(Texture, destinationBoomerang, boomerangRectangle, Color.White);
            //mapPauseScreen.Draw(spriteBatch, link);

            if (link.inventory.BombState())
            {
                Rectangle destinationBomb = new Rectangle(285, 110, 15, 20); // For Map Item
                spriteBatch.Draw(Texture, destinationBomb, bombRectangle, Color.White);
                mapPauseScreen.Draw(spriteBatch, link);
            }
            if (link.inventory.BoomerangState())
            {
                Rectangle destinationBoomerang = new Rectangle(230, 110, 15, 20); // For Map Item
                spriteBatch.Draw(Texture, destinationBoomerang, boomerangRectangle, Color.White);
                mapPauseScreen.Draw(spriteBatch, link);
            }

        }
    }
}
