using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Zelda_Game
{
    public class Level
    {
        public Vector2 source1;
        public Vector2 source2;
        public Dictionary<Vector2, string> Blocks;
        public Dictionary<Vector2, string> Enemies;
        public Dictionary<Vector2, string> Items;
    }
}
