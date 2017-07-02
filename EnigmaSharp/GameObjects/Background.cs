using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaSharp
{
    class Background
    {
        public string Name { get; private set; }
        public Image BackgroundImage { get; private set; }
        public bool SmoothEdges { get; private set; }
        public bool PreloadTexture { get; private set; }
        public bool Transparent { get; private set; }
        public bool UseAsTileSet { get; private set; }
        public Enigma.TileData TileProperties { get; private set; }
    }
}
