using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaSharp
{
    class Enigma
    {
        // The way in which the bounding box of the object is generated.
        public enum SpriteBoundingBoxMode
        {
            Auto, Full, Manual
        }
        // Shapes for collision detection of sprites
        public enum SpriteMaskShapes
        {
            Precise, Rectangle, Disk, Diamond, Polygon
        }
        // The "kind" of sound in the engine
        public enum SoundKind
        {
            Normal, Background, Spatial, Multimedia
        }
        // The type of sound (channels)
        public enum SoundType
        {
            Mono, Stereo, ThreeDimentional
        }
        // A box (eg for a bounding box property)
        public struct Box
        {
            public int Left, Right, Top, Bottom;
        }
        // Data for a tile in a room
        public struct TileData
        {
            public int Width, Height, HorizontalOffset, VerticalOffset, HorizontalPadding, VerticalPadding;
        }
        // Structure for room's grid properties
        // using a structure since we don't need a gridproperties anywhere else
        public struct GridProperties
        {
            public int HorizontalOffset, VerticalOffset, Width, Height;
        }
        // Properties for a tile set
        public struct TilesetProperty
        {
            public Background Resource;
            public int X, Y;
        }
        // Conventional way to store antialiasing level
        public enum FontAntiAliasLevel
        {
            Off, One, Two, Three
        }
    }
}
