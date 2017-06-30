using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaSharp
{
    class Tile
    {
        public struct TilesetProperty
        {
            public Background Resource;
            public int X, Y;
        }
        public bool Locked { get; private set; }
        public TilesetProperty Tileset { get; private set; }
        public Point Position { get; private set; }
        public int Layer { get; private set; }
    }
}
