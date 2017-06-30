using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaSharp
{
    class Room
    {
        // Structure for room's grid properties
        // using a structure since we don't need a gridproperties anywhere else
        public struct GridProperties{
            public int HorizontalOffset,VerticalOffset,Width,Height;
        }
        
        // Room settings
        public string Name { get; private set; }
        public string Caption { get; private set; }
        public string CreationCode { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public int Speed { get; private set; }
        public bool Persistent { get; private set; }
        public GridProperties Grid { get; private set; }

        // Room backgrounds
        public bool DrawBackgroundColour { get; private set; }
        public string BackgroundColour { get; private set; }
        public RoomBackground[] Backgrounds { get; private set; }

        // Room views
        public bool EnableViews { get; private set; }
        public bool ClearBackgroundWithWindowColour { get; private set; }
        public RoomView Views { get; private set; }

        // Room physics
        public bool PhysicsWorldEnabled { get; private set; }
        public float PixelsPerMeter { get; private set; }
        public float VerticalGravity { get; private set; }
        public float HorizontalGravity { get; private set; }
    }
}
