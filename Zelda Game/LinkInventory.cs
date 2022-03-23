using System;
using System.Collections.Generic;

namespace Zelda_Game
{
    public class LinkInventory
    {
        private int numKeys;
        private int rupees;
        public List<IItem> items;
        public LinkInventory()
        {
            numKeys = 0;
            rupees = 24;
            items = new List<IItem>();
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
    }
}
