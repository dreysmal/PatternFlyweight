using System;


namespace Flyweight_MilitaryBase
{
    class Presenter
    {
        protected readonly Imilitary imilitary;
        private Model_ClientFlyweight model_ClientFlyweight = new Model_ClientFlyweight();
        public Presenter(Imilitary imilitary)
        {
            this.imilitary = imilitary;
            imilitary.SetUnit += SetUnit;
        }

        public void SetUnit(String str)
        {
            switch (str)
            {
                case "Soldier":
                    Technic vehicle1 = model_ClientFlyweight.GetSoldier(imilitary.Coord);
                    imilitary.Coord = vehicle1.Coordinates;
                    imilitary.Speed = vehicle1.Speed;
                    imilitary.Power = vehicle1.Power;
                    imilitary.Name_path = vehicle1.Texture_Path;
                    break;
                case "Transport":
                    Technic vehicle2 = model_ClientFlyweight.GetTransport(imilitary.Coord);
                    imilitary.Coord = vehicle2.Coordinates;
                    imilitary.Speed = vehicle2.Speed;
                    imilitary.Power = vehicle2.Power;
                    imilitary.Name_path = vehicle2.Texture_Path;
                    break;
                case "Light":
                    Technic vehicle3 = model_ClientFlyweight.GetLight(imilitary.Coord);
                    imilitary.Coord = vehicle3.Coordinates;
                    imilitary.Speed = vehicle3.Speed;
                    imilitary.Power = vehicle3.Power;
                    imilitary.Name_path = vehicle3.Texture_Path;
                    break;
                case "Heavy":
                    Technic vehicle4 = model_ClientFlyweight.GetHeavy(imilitary.Coord);
                    imilitary.Coord = vehicle4.Coordinates;
                    imilitary.Speed = vehicle4.Speed;
                    imilitary.Power = vehicle4.Power;
                    imilitary.Name_path = vehicle4.Texture_Path;
                    break;
                case "Avia":
                    Technic vehicle5 = model_ClientFlyweight.GetAvia(imilitary.Coord);
                    imilitary.Coord = vehicle5.Coordinates;
                    imilitary.Speed = vehicle5.Speed;
                    imilitary.Power = vehicle5.Power;
                    imilitary.Name_path = vehicle5.Texture_Path;
                    break;
                default:
                    break;
            }
        }
    }
}
