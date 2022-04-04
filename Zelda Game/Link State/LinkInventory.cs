using System;
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
        public List<IItem> items;
        public LinkInventory()
        {
            numLives = 4;
            numKeys = 0;
            maps = false;
            compass = false;
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

        public void UseKey()
        {
            numKeys--;
        }

        public void AddKey()
        {
            numKeys++;
        }

        public int NumKeys()
        {
            return numKeys;
        }

        public void UseRupees()
        {
            rupees--;
        }

        public void AddRupees()
        {
            numKeys++;
        }

        public int NumRupees()
        {
            return rupees;
        }

        public void UseBomb()
        {
            bombs--;
        }

        public void AddBomb()
        {
            bombs++;
        }

        public int NumBombs()
        {
            return bombs;
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
    }
}
