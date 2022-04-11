using System.Collections.Generic;

namespace Zelda_Game
{
    public class LinkInventory
    {
        //Turn into proporties
        private int numLives;
        private int numKeys;
        private int rupees;
        private int bombs;
        private bool maps;
        private bool compass;
        private bool bomb;
        private bool boomerang;
        public List<IItem> items;
        public LinkInventory()
        {
            numLives = 4;
            numKeys = 20;
            maps = false;
            compass = false;
            bomb = false; //Created another bomb for weaponselection
            boomerang = false;
            rupees = 24;
            items = new List<IItem>();
        }

        public void LoseLife()
        {
           numLives--;
            if(numLives <= 0)
            {
                numLives = 0;
            }
        }

        public void EarnLife()
        {
            numLives++;
            if(numLives >= 4)
            {
                numLives = 4;
            }
        }

        public int NumLives()
        {
            return numLives;
        }

        public int Keys
        {
            get => numKeys; 
            set => numKeys = value; 
        }

        public int Rupees
        {
            get => rupees; 
            set => rupees = value; 
        }

        public int Bombs
        {
            get => bombs;
            set => bombs = value;
        }

        public void AddItem(IItem item)
        {
            items.Add(item);
        }

        public void RemoveItem(IItem item)
        {
            items.Remove(item);
        }

        public List<IItem> ItemList()
        {
            return items;
        }

        public void CollectMap()
        {
            maps = true;
        }

        public bool MapState()
        {
            return maps;
        }

        public void CollectCompass()
        {
            compass = true;
        }

        public bool CompassState()
        {
            return compass;
        }

        public void CollectBomb() //Added for WeaponSelection file
        {
            bomb = true;
        }

        public bool BombState()
        {
            return bomb;
        }

        public void CollectBoomerang()
        {
            boomerang = true;
        }

        public bool BoomerangState()
        {
            return boomerang;
        }
    }
}
