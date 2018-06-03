
namespace Flyweight_MilitaryBase
{
    class Light : Technic
    {
        internal protected Light()
        {
            Texture_Path = @"..\..\Images\Light.jpg";
            Speed = 50;
            Power = 30;
        }

        public override void Show(int[] coordinates)
        {
            Coordinates = coordinates;
        }
    }
}
