using System;
using System.Collections.Generic;

namespace Flyweight_MilitaryBase
{
    class TechnicFactory
    {
        private Dictionary<String, Technic> Angar = new Dictionary<string, Technic>();

        public TechnicFactory()
        {
            Angar.Add("Soldier", new Soldier());
            Angar.Add("Transport", new Transport());
            Angar.Add("Light", new Light());
            Angar.Add("Heavy", new Heavy());
            Angar.Add("Avia", new Avia());
        }

        public Technic GetTechnic(String key)
        {
            if(Angar.ContainsKey(key))
            {
                return Angar[key];
            }
            else
            {
                return null;
            }
        }
    }
}
