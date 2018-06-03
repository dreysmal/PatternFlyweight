using System;

namespace Flyweight_MilitaryBase
{
    class Soldier : Technic
    {
        internal protected Soldier()
        {
            Texture_Path = @"..\..\Images\Soldier.jpg";
            Speed = 20;
            Power = 10;
        }
        public override void Show(Int32[] coordinates)
        {
            Coordinates = coordinates;
        }
    }
}
