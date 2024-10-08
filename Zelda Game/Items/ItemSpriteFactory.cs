﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Zelda_Game
{
    public class ItemSpriteFactory
    {
        private Texture2D ItemSheet;
        private Texture2D ItemSheet2;

        private static readonly ItemSpriteFactory instance = new ItemSpriteFactory();

        public static ItemSpriteFactory Instance => instance;

        private ItemSpriteFactory()
        {
        }

        public void LoadAllTextures(ContentManager content)
        {
            ItemSheet = content.Load<Texture2D>("WeaponSheet");
            ItemSheet2 = content.Load<Texture2D>("LinkSheet");
        }

        public IItem ArrowItem() => new ArrowItem(ItemSheet);

        public IItem BombItem() => new BombItem(ItemSheet);

        public IItem BowItem() => new BowItem(ItemSheet);

        public IItem ClockItem() => new ClockItem(ItemSheet);

        public IItem CompassItem() => new CompassItem(ItemSheet);

        public IItem FairyItem(Vector2 location) => new FairyItem(ItemSheet, location);

        public IItem HeartContainerItem() => new HeartContainerItem(ItemSheet);

        public IItem HeartItem() => new HeartItem(ItemSheet);

        public IItem KeyItem() => new KeyItem(ItemSheet);

        public IItem MapItem() => new MapItem(ItemSheet);

        public IItem RupeeItem() => new RupeeItem(ItemSheet);

        public IItem TriforcePieceItem() => new TriforcePieceItem(ItemSheet);

        public IItem ArrowItem2() => new ArrowItem2(ItemSheet);

        public IItem BlueBoomerang() => new BlueBoomerang(ItemSheet);

        public IItem GreenBoomerang() => new GreenBoomerang(ItemSheet);

        public IItem Fire() => new FireItem(ItemSheet2);

    }
}
