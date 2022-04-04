using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public class RoomManager
    {
        private Game1 game1;
        private TransitionScreen screenFade;
        private int count;
        private bool fade;

        public RoomManager(Game1 game1)
        {
            this.game1 = game1;
            screenFade = new TransitionScreen(game1);
            count = 0;
            fade = true;
        }

        public void ChangeRoom(KeyValuePair<int, int> currentRoom, KeyValuePair<int, int> roomLocation, Vector2 position)
        {
            game1.roomLocation = roomLocation;
            game1.link.position = position;
            game1.roomData = game1.roomList[game1.roomLocation];
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            screenFade.Draw(spriteBatch);
            if (count == 100)
            {
                game1.tansitionState = false;
                game1.tansitionStateFinished = false;
                fade = true;
                count = 0;
            }
        }

        public void Update()
        {
            screenFade.Update(fade);
            count++;
            if (count == 50)
            {
                game1.tansitionStateFinished = true;
                fade = false;
            }
        }
    }
}
