using System;
using Lab9.Domain;
using System.Collections;
using System.Collections.Generic;
using Serializer;


namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Runway> runwaysRynair = new List<Runway>();
            runwaysRynair.Add(new Runway(1000));
            runwaysRynair.Add(new Runway(2000));
            runwaysRynair.Add(new Runway(3000));

            List<Runway> runwaysLOT = new List<Runway>();
            runwaysLOT.Add(new Runway(1000));
            runwaysLOT.Add(new Runway(2000));
            runwaysLOT.Add(new Runway(3000));

            List<Airport> lst = new List<Airport>();
            lst.Add(new Airport("Rynair", runwaysRynair));
            lst.Add(new Airport("LOT Polish Airlines", runwaysLOT));

            Serializer1 serializer = new Serializer1();
            serializer.SerializeXML(lst, "serxml.xml");
            serializer.SerializeJSON(lst, "serjson.txt");
            serializer.SerializeByLINQ(lst, "serlinq.txt");

            foreach(var el in serializer.DeSerializeXML("serxml.xml"))
            {
                Console.WriteLine($"Airport name:{el.Name}");
                foreach(var rainways in el.Runways)
                {
                    Console.WriteLine($"Rainway length:{rainways.Length}");
                }
            }

            foreach (var el in serializer.DeSerializeJSON("serjson.txt"))
            {
                Console.WriteLine($"Airport name:{el.Name}");
                foreach (var rainways in el.Runways)
                {
                    Console.WriteLine($"Rainway length:{rainways.Length}");
                }
            }

             foreach (var el in serializer.DeSerializeByLINQ("serlinq.txt"))
             {
               Console.WriteLine($"Airport name:{el.Name}");
               foreach (var rainways in el.Runways)
               {
                 Console.WriteLine($"Rainway length:{rainways.Length}");
               }
             }
        }
    }
}