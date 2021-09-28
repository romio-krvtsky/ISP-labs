using System;

namespace ConsoleApp1.Entities
{
    public class Tariff
    {
        internal uint Price { get; set; }
        private string Direction { get; set; }
        public AirTicketClasses AirTicketClass { get; }
   
        public enum AirTicketClasses
        {
            First,
            Ecomony,
            Business
        }

        public Tariff(uint price, string direction, AirTicketClasses airTicketClass)
        {
            Price = price;
            Direction = direction;
            AirTicketClass = airTicketClass;
        }

        public void TarrifInfo()
        {
            Console.WriteLine($"Air Ticket Class: {AirTicketClass}");
            Console.WriteLine($"Price: {Price} $");
            Console.WriteLine($"To: {Direction}\n");
        }
    }
}