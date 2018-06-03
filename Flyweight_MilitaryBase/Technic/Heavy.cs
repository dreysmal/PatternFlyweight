namespace Flyweight_MilitaryBase
{
    class Heavy : Technic
    {
        internal protected Heavy()
        {
            Texture_Path = @"..\..\Images\Heavy.jpg";
            Speed = 15;
            Power = 150;
        }

        public override void Show(int[] coordinates)
        {
            Coordinates = coordinates;
        }
    }
}
