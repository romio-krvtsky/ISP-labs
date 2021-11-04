using System;

namespace Lab7.Entities
{
    public class Tariff
    {
        public uint Price { get; private set; }
        public string Direction { get; private set; }
        private AirTicketClasses AirTicketClass { get; }


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