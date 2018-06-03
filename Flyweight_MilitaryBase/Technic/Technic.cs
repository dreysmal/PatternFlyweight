using System;

namespace Flyweight_MilitaryBase
{
    abstract class Technic
    {
        internal protected String Texture_Path;
        internal protected Int32 Speed;
        internal protected Int32 Power;
        internal protected Int32[] Coordinates = new Int32[2];
        public abstract void Show(Int32[] coordinates);
    }
}
