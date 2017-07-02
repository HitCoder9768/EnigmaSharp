using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaSharp
{
    class Sprite
    {
        public string Name { get; private set; }
        public int AnimationSpeed { get; private set; }
        public bool SmoothEdges { get; private set; }
        public bool PreloadTexture { get; private set; }
        public bool TransparencyPixel { get; private set; }
        public bool SeparateMasks { get; private set; }
        public Point Origin { get; private set; }
        public Enigma.SpriteMaskShapes CollisionCheckingMode { get; private set; }
        public Enigma.SpriteBoundingBoxMode BoundingBoxType { get; private set; }
        public Enigma.Box BoundingBox { get; private set; }
        public byte AlphaTolerance { get; private set; }
        public List<Image> Frames { get; private set; }
    }
}
