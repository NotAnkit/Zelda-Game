using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;

namespace Zelda_Game
{
    public class MapPauseScreen
    {
        public Texture2D Texture;
        public SpriteFont Font;
        Texture2D rectangle;

        public MapPauseScreen(Game1 game)
        {
            rectangle = new Texture2D(game.GraphicsDevice, 1, 1);
            rectangle.SetData(new[] { Color.White });
            Texture = game.Content.Load<Texture2D>("Inventory");
        }

        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch, Link link)
        {
            Rectangle sourceRoom1 = new Rectangle(528, 108, 8, 8);
            Rectangle sourceRoom2 = new Rectangle(618, 108, 8, 8);
            Rectangle sourceRoom3 = new Rectangle(537, 108, 8, 8);
            Rectangle sourceRoom4 = new Rectangle(627, 108, 8, 8);
            Rectangle sourceRoom5 = new Rectangle(600, 108, 8, 8);
            Rectangle sourceRoom6 = new Rectangle(582, 108, 8, 8);
            Rectangle sourceRoom7 = new Rectangle(528, 108, 8, 8);
            Rectangle sourceRoom8 = new Rectangle(582, 108, 8, 8);
            Rectangle sourceRoom9 = new Rectangle(618, 108, 8, 8);
            Rectangle sourceRoom10 = new Rectangle(546, 108, 8, 8);
            Rectangle sourceRoom11 = new Rectangle(609, 108, 8, 8);
            Rectangle sourceRoom12 = new Rectangle(627, 108, 8, 8);
            Rectangle sourceRoom13 = new Rectangle(555, 108, 8, 8);
            Rectangle sourceRoom14 = new Rectangle(537, 108, 8, 8);
            Rectangle sourceRoom15 = new Rectangle(609, 108, 8, 8);
            Rectangle sourceRoom16 = new Rectangle(528, 108, 8, 8);
            Rectangle sourceRoom17 = new Rectangle(537, 108, 8, 8);



            Rectangle destinationRoom1 = new Rectangle(260, 294, 16, 16);
            Rectangle destinationRoom2 = new Rectangle(274, 294, 16, 16);
            Rectangle destinationRoom3 = new Rectangle(290, 294, 16, 16);
            Rectangle destinationRoom4 = new Rectangle(274, 278, 16, 16);
            Rectangle destinationRoom5 = new Rectangle(260, 262, 16, 16);
            Rectangle destinationRoom6 = new Rectangle(274, 262, 16, 16);
            Rectangle destinationRoom7 = new Rectangle(244, 246, 16, 16);
            Rectangle destinationRoom8 = new Rectangle(260, 246, 16, 16);
            Rectangle destinationRoom9 = new Rectangle(274, 246, 16, 16);
            Rectangle destinationRoom10 = new Rectangle(290, 246, 16, 16);
            Rectangle destinationRoom11 = new Rectangle(306, 246, 16, 16);
            Rectangle destinationRoom12 = new Rectangle(274, 230, 16, 16);
            Rectangle destinationRoom13 = new Rectangle(306, 230, 16, 16);
            Rectangle destinationRoom14 = new Rectangle(274, 214, 16, 16);
            Rectangle destinationRoom15 = new Rectangle(290, 262, 16, 16);
            Rectangle destinationRoom16 = new Rectangle(260, 214, 16, 16);
            Rectangle destinationRoom17 = new Rectangle(320, 230, 16, 16);

            Rectangle sourceTriForce = new Rectangle(633, 86, 3, 3);
            Rectangle destinationTriForce = new Rectangle(326, 233, 9, 9);

            if (link.inventory.MapState())
            {
            
                spriteBatch.Draw(Texture, destinationRoom1, sourceRoom1, Color.White);
                spriteBatch.Draw(Texture, destinationRoom2, sourceRoom2, Color.White);
                spriteBatch.Draw(Texture, destinationRoom3, sourceRoom3, Color.White);
                spriteBatch.Draw(Texture, destinationRoom4, sourceRoom4, Color.White);
                spriteBatch.Draw(Texture, destinationRoom5, sourceRoom5, Color.White);
                spriteBatch.Draw(Texture, destinationRoom6, sourceRoom6, Color.White);
                spriteBatch.Draw(Texture, destinationRoom7, sourceRoom7, Color.White);
                spriteBatch.Draw(Texture, destinationRoom8, sourceRoom8, Color.White);
                spriteBatch.Draw(Texture, destinationRoom9, sourceRoom9, Color.White);
                spriteBatch.Draw(Texture, destinationRoom10, sourceRoom10, Color.White);
                spriteBatch.Draw(Texture, destinationRoom11, sourceRoom11, Color.White);
                spriteBatch.Draw(Texture, destinationRoom12, sourceRoom12, Color.White);
                spriteBatch.Draw(Texture, destinationRoom13, sourceRoom13, Color.White);
                spriteBatch.Draw(Texture, destinationRoom14, sourceRoom14, Color.White);
                spriteBatch.Draw(Texture, destinationRoom15, sourceRoom15, Color.White);
                spriteBatch.Draw(Texture, destinationRoom16, sourceRoom16, Color.White);
                spriteBatch.Draw(Texture, destinationRoom17, sourceRoom17, Color.White);

                if (link.inventory.CompassState())
                {
                    SpriteEffects s = SpriteEffects.None;
                    spriteBatch.Draw(rectangle, new Vector2(326, 236), null, new Color(1f, 1f, 1f, 1), 0f, Vector2.Zero, new Vector2(5, 5), s, 0);
                    
                }
            }
        }
    }
}
