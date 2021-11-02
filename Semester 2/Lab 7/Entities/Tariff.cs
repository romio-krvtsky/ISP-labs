using System;

namespace ConsoleApp1.Entities
{
    public class Tariff
    {
        private uint Price { get; set; }

        private string Direction { get; set; }
        public AirTicketClasses AirTicketClass { get; }

        public uint GetPrice()
        {
            return Price;
        }

        public string GetDirection()
        {
            return Direction;
        }
        
        public enum AirTicketClasses
        {
            First,
            Ecomony,
            Business
        }

        public Tariff(string direction, uint price, AirTicketClasses airTicketClass)
        {
            Direction = direction;
            Price = price;
            AirTicketClass = airTicketClass;
        }

        public void TarrifInfo()
        {
            Console.WriteLine($"\tAir Ticket Class: {AirTicketClass}");
            Console.WriteLine($"\tPrice: {Price} $");
            Console.WriteLine($"\tTo: {Direction}\n");
        }
    }
}