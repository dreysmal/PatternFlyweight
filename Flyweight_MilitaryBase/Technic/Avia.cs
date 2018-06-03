namespace Flyweight_MilitaryBase
{
    class Avia : Technic
    {
        internal protected Avia()
        {
            Texture_Path = @"..\..\Images\Avia.jpg";
            Speed = 300;
            Power = 100;
        }

        public override void Show(int[] coordinates)
        {
            Coordinates = coordinates;
        }
    }
}
