using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaSharp
{
    class Instance
    {
        public Entity Type { get; private set; }
        public bool Locked { get; private set; }
        public string Name { get; private set; }
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public float Rotation { get; private set; }
        public byte Alpha { get; private set; }
        public string Colour { get; private set; }
        public string CreationCode { get; private set; }
    }
}
