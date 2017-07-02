using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaSharp.GameObjects
{
    class GameFont
    {
        public string Name { get; private set; }
        public string Font { get; private set; }
        public byte Size { get; private set; }
        public Enigma.FontAntiAliasLevel AntialiasLevel { get; private set; }
        public bool Bold { get; private set; }
        public bool Italic { get; private set; }
        public int CharacterRangeMin { get; private set; }
        public int CharacterRangeMax { get; private set; }
    }
}
