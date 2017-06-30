using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaSharp
{
    class RoomView
    {
        // Structure to store the view's vectors
        public struct Vectors
        {
            public int X, Y, Width, Height;
        }

        public bool VisibleOnRoomStart { get; private set; }
        public Vectors ViewInRoom { get; private set; }
        public Vectors PortOnScreen { get; private set; }
        public Entity ObjectToFollow { get; private set; }
        public short HorizontalBorder { get; private set; }
        public short VerticalBorder { get; private set; }
        public short HorizontalSpeed { get; private set; }
        public short VerticalSpeed { get; private set; }
    }
}
