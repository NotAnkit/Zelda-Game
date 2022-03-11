using Microsoft.Xna.Framework;
namespace Zelda_Game
{
    public static class PlayerItemResponse
    {
        public static void PlayerItem(Game1 Game, Vector2 itemLocation, IItem item)
        {
            //List<IItem> itemList;

            Game.link.currentState = new HoldingItemState(Game.link);
           
            itemLocation.X = Game.link.position.X + 8;
            itemLocation.Y = Game.link.position.X + 32;


        }    

    }   
}
