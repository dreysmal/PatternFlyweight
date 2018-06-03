using System;

namespace Flyweight_MilitaryBase
{
    class Model_ClientFlyweight
    {
        TechnicFactory technicFactory = new TechnicFactory();
        public Technic GetSoldier(Int32[] coord) 
        {
            Technic solder = technicFactory.GetTechnic("Soldier");
            solder.Show(coord);
            return solder;
        }
        public Technic GetTransport(Int32[] coord)
        {
            Technic transport = technicFactory.GetTechnic("Transport");
            transport.Show(coord);
            return transport;
        }
        public Technic GetLight(Int32[] coord)
        {
            Technic light = technicFactory.GetTechnic("Light");
            light.Show(coord);
            return light;
        }

        public Technic GetHeavy(Int32[] coord)
        {
            Technic heavy = technicFactory.GetTechnic("Heavy");
            heavy.Show(coord);
            return heavy;
        }

        public Technic GetAvia(Int32[] coord)
        {
            Technic avia = technicFactory.GetTechnic("Avia");
            avia.Show(coord);
            return avia;
        }
    }
}
