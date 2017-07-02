using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnigmaSharp.GameObjects;

namespace EnigmaSharp
{
    class Project
    {
        public List<Sprite> Sprites { get; private set; }
        public List<Script> Scripts { get; private set; }
        public List<Entity> Objects { get; private set; }
        public List<GameFont> Fonts { get; private set; }
        public List<Room> Rooms { get; private set; }
        public List<Background> Backgrounds { get; private set; }
    }
}
