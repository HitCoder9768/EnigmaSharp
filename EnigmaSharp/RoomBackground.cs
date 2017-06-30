using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaSharp
{
    class RoomBackground
    {
        public Background Resource { get; private set; }
        public bool Visible { get; private set; }
        public bool Foreground { get; private set; }
        public bool TileHorizontally { get; private set; }
        public bool TileVertically { get; private set; }
        public bool Stretch { get; private set; }
        public int HorizontalOffset { get; private set; }
        public int VerticalOffset { get; private set; }
    }
}
