using System.Collections.Generic;

namespace Zelda_Game
{
    public class LinkInventory
    {
        private int numLives;
        private int maxLives;
        private int numKeys;
        private int rupees;
        private int bombs;
        private bool maps;
        private bool compass;
        private bool bomb;
        private bool yellowBoomerang;
        private bool blueBoomerang;
        private bool bow;
        private bool greenArrow;
        private bool blueArrow;
        private bool fire;
        private bool triForce;
        public List<IItem> items;
        public LinkInventory()
        {
            maxLives = 4;
            numLives = 3;
            numKeys = 1;
            bombs = 0;
            maps = false;
            compass = false;
            bomb = false;
            yellowBoomerang = false;
            blueBoomerang = false;
            bow = false;
            blueArrow = false;
            greenArrow = false;
            fire = false;
            triForce = false;
            rupees = 10;
            items = new List<IItem>();
        }

        public void LoseLife()
        {
            numLives--;
            if (numLives <= 0)
            {
                numLives = 0;
            }
        }

        public void EarnLife()
        {
            numLives++;
            if (numLives >= maxLives)
            {
                numLives = maxLives;
            }
        }

        public int NumLives()
        {
            return numLives;
        }

        public void SetLives(int lives)
        {
            numLives = lives;
        }

        public int Keys
        {
            get => numKeys;
            set => numKeys = value;
        }

        public int MaxLives
        {
            get => maxLives;
            set => maxLives = value;
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

        public bool TriForce
        {
            get => triForce;
            set => triForce = value;
        }

        public bool SetBombState
        {
            get => bomb;
            set => bomb = value;
        }

        public void AddItem(IItem item)
        {
            if(item is BowItem)
            {
                bow = true;
            }
            if (item is ArrowItem)
            {
                greenArrow = true;
            }
            if (item is ArrowItem2)
            {
                blueArrow = true;
            }
            if (item is GreenBoomerang)
            {
                yellowBoomerang = true;
            }
            if (item is BlueBoomerang)
            {
                blueBoomerang = true;
            }
            if (item is FireItem)
            {
                fire = true;
            }
            if (item is TriforcePieceItem)
            {
                triForce = true;
            }
            items.Add(item);
        }

        public void CollectMap() => maps = true;

        public bool MapState() => maps;

        public void CollectCompass() => compass = true;

        public bool CompassState() => compass;


        public bool BombState()
        {
            return bomb;
        }

        public bool FireState()
        {
            return fire;
        }

        public bool YellowBoomerangState()
        {
            return yellowBoomerang;
        }

        public bool BlueBoomerangState()
        {
            return blueBoomerang;
        }

        public bool BowState()
        {
            return bow;
        }

        public bool GreenArrowState()
        {
            return greenArrow;
        }

        public bool BlueArrowState()
        {
            return blueArrow;
        }
    }
}
