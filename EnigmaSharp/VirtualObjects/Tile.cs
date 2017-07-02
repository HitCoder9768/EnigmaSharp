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
        public bool Locked { get; private set; }
        public Enigma.TilesetProperty Tileset { get; private set; }
        public Point Position { get; private set; }
        public int Layer { get; private set; }
    }
}
