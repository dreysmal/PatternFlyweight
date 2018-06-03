using System;

namespace Flyweight_MilitaryBase
{
    public delegate void myvoidstringdelegate(String str);
    interface Imilitary
    {
        Int32[] Coord { get; set; }
        String Name_path { get; set; }
        Int32 Speed { get; set; }
        Int32 Power { get; set; }

        event myvoidstringdelegate SetUnit;
    }
}
