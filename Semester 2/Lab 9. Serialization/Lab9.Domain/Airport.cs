using System.Collections.Generic;

namespace Lab9.Domain
{
    public class Airport
    {
        public string Name { get; set; }
        public List<Runway> Runways;

        public Airport(string name, List<Runway> rnws)
        {
            Name = name;
            Runways = rnws;
        }

        public Airport(string name)
        {
            Name = name;
        }

    }
}