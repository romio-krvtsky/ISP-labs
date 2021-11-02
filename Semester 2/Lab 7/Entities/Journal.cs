using System;
using System.Collections.Generic;

namespace Lab7.Entities
{
    public class Event
    {
        public Event(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public string Name { get; set; }
        public string Description { get; set; }
    }
    public class Journal
    {
        private List<Event> Events = new();

        public void AddEvent(string name, string info)
        {
            Events.Add(new Event(name,info));
        }

        public void PrintAllEvents()
        {
            Console.WriteLine("All events:");
            for (int i = 0; i < Events.Count; ++i)
            {
                Console.WriteLine($"{Events[i].Name} {Events[i].Description}");
            }
        }
        
    }
}