using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public static class GetWeapons
    {
        public static void DropWeapons(RoomManager manager)
        {
            if (manager.roomLocation.Key == 3 && manager.roomLocation.Value == 5 && !manager.roomData.itemPickedUp)
            {
                manager.roomData.itemList.Add(new Vector2(300, 100), ItemSpriteFactory.Instance.BowItem());
                manager.roomData.itemPickedUp = true;
            }
            if (manager.roomLocation.Key == 2 && manager.roomLocation.Value == 4 && !manager.roomData.itemPickedUp)
            {
                manager.roomData.itemList.Add(new Vector2(300, 100), ItemSpriteFactory.Instance.ArrowItem());
                manager.roomData.itemPickedUp = true;
            }
            if (manager.roomLocation.Key == 1 && manager.roomLocation.Value == 3 && !manager.roomData.itemPickedUp)
            {
                manager.roomData.itemList.Add(new Vector2(300, 100), ItemSpriteFactory.Instance.ArrowItem2());
                manager.roomData.itemPickedUp = true;
            }
            if (manager.roomLocation.Key == 1 && manager.roomLocation.Value == 2 && !manager.roomData.itemPickedUp)
            {
                manager.roomData.itemList.Add(new Vector2(300, 100), ItemSpriteFactory.Instance.BlueBoomerang());
                manager.roomData.itemPickedUp = true;
            }
            if (manager.roomLocation.Key == 0 && manager.roomLocation.Value == 2 && !manager.roomData.itemPickedUp)
            {
                manager.roomData.itemList.Add(new Vector2(300, 100), ItemSpriteFactory.Instance.GreenBoomerang());
                manager.roomData.itemPickedUp = true;
            }
            if (manager.roomLocation.Key == 2 && manager.roomLocation.Value == 1 && !manager.roomData.itemPickedUp)
            {
                manager.roomData.itemList.Add(new Vector2(70, 162), ItemSpriteFactory.Instance.HeartContainerItem());
                manager.roomData.itemPickedUp = true;

            }
        }
    }
}
