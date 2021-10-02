using System;
using ConsoleApp1.Collections;

namespace ConsoleApp1.Entities
{
    public class Passenger
    {
        private string Name;
        private string Surname;
        private string PassportNumber { get; set; }
        private MyCustomCollection<Tariff> Orders = new();

        public Passenger(string n, string sn)
        {
            Name = n;
            Surname = sn;
        }

        public void InputPassportData()
        {
            Console.WriteLine("Enter passport number of {0} {1}:", Name, Surname);
            var num = Console.ReadLine();
            PassportNumber = num;
        }

        private void GetPassangerInfo()
        {
            Console.WriteLine($"{Orders.Count} orders  of {Name} {Surname}:");
            Console.WriteLine($"Passport Number: {PassportNumber}");
        }

        public void Order(params Tariff[] ticket)
        {
            if (PassportNumber == null)
            {
                throw new Exception("Person can't order the ticket without passport data!!");
            }

            for (int i = 0; i < ticket.Length; ++i)
            {
                Orders.Add(ticket[i]);
            }

            GetPassangerInfo();
            for (int i = 0; i < ticket.Length; ++i)
            {
                Console.WriteLine("\nTicket {0}", i+1);
                ticket[i].TarrifInfo();
            }

        }

        public uint GetAmountOfTickets()
        {
            return (uint) Orders.Count;
        }

        public uint PersonalTotalSum()
        {
            uint sum = 0;
            for (int i = 0; i < GetAmountOfTickets(); ++i)
            {
                sum += Orders[i].Price;
            }

            Console.WriteLine($"\n\tTotal sum for {Name}'s {Surname} {GetAmountOfTickets()} orders: {sum} $");
            return sum;
        }
    }
}