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

        public LinkInventory()
        {
            maxLives = 4;
            numLives = 4;
            numKeys = 5;
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
        }

        public void LoseLife()
        {
            numLives--;
            if (numLives <= 0)
            {
                numLives = 0;
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

        public bool TriForce
        {
            get => triForce;
            set => triForce = value;
        }

        public void AddItem(IItem item)
        {
            if (item is KeyItem) numKeys++;
            
            else if (item is MapItem) maps = true;
            
            else if (item is CompassItem) compass = true;
            
            else if (item is RupeeItem) rupees++;
            
            else if (item is BombItem)
            {
                bomb = true;
                bombs++;
            }
            else if (item is FairyItem) numLives = maxLives;
            
            else if (item is HeartContainerItem) maxLives++;
            
            else if (item is HeartItem)
                numLives++;
                if (numLives >= maxLives) numLives = maxLives;
                
            if (item is BowItem) bow = true;
            
            if (item is ArrowItem) greenArrow = true;
            
            if (item is ArrowItem2) blueArrow = true;
            
            if (item is GreenBoomerang) yellowBoomerang = true;
            
            if (item is BlueBoomerang) blueBoomerang = true;
            
            if (item is FireItem) fire = true;
            
            if (item is TriforcePieceItem) triForce = true;
            
        }

        public bool MapState() => maps;

        public bool CompassState() => compass;

        public bool BombState() => bomb;

        public bool FireState() => fire;

        public bool YellowBoomerangState() => yellowBoomerang;

        public bool BlueBoomerangState() => blueBoomerang;

        public bool BowState() => bow;

        public bool GreenArrowState() => greenArrow;

        public bool BlueArrowState() => blueArrow;
    }
}
