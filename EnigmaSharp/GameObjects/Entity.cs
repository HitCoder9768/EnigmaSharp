using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaSharp
{
    class Entity
    {
        public string Name { get; private set; }
        public Sprite LocalSprite { get; private set; }
        public Sprite Mask { get; private set; }
        public int Depth { get; private set; }
        public bool Visible { get; private set; }
        public bool Persistent { get; private set; }
        public bool Solid { get; private set; }
        public bool Physics { get; private set; }

    }
}
