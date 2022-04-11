using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class WeaponSelection
    {
        public readonly Texture2D Texture;
        private readonly MapPauseScreen mapPauseScreen;

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
            Rectangle bombRectangle = new Rectangle(604, 137, 8, 14); // For bomb item
            Rectangle boomerangRectangle = new Rectangle(585, 141, 5, 8); // For boomerang item

            //Rectangle destinationBomb = new Rectangle(90, 90, 20, 20); // Change values
            //Rectangle destinationBoomerang = new Rectangle(100, 100, 20, 20); // Fill with something

            //spriteBatch.Draw(Texture, destinationBomb, bombRectangle, Color.White);
            //spriteBatch.Draw(Texture, destinationBoomerang, boomerangRectangle, Color.White);
            //mapPauseScreen.Draw(spriteBatch, link);

            if (link.inventory.BombState())
            {
                Rectangle destinationBomb = new Rectangle(90, 90, 20, 20); // For Map Item
                spriteBatch.Draw(Texture, destinationBomb, bombRectangle, Color.White);
                mapPauseScreen.Draw(spriteBatch, link);
            }
            if (link.inventory.BoomerangState())
            {
                Rectangle destinationBoomerang = new Rectangle(100, 100, 20, 20); // For Map Item
                spriteBatch.Draw(Texture, destinationBoomerang, boomerangRectangle, Color.White);
                mapPauseScreen.Draw(spriteBatch, link);
            }
        }
    }
}
