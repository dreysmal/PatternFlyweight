using System;

namespace Flyweight_MilitaryBase
{
    class Transport : Technic
    {
        internal protected Transport()
        {
            Texture_Path = @"..\..\Images\transport.jpg";
            Speed = 20;
            Power = 10;
        }

        public override void Show(Int32[] coordinates)
        {
            Coordinates = coordinates;
        }
    }
}
