using System;
using System.Collections.Generic;
using ConsoleApp1.Entities;
using System.Linq;
namespace Lab7.Entities
{
    public class Passenger
    {
        private string Name;
        private string Surname;
        private string PassportNumber { get; set; }
        private List<Tariff> Orders = new();

        public delegate void ChangedTickets(string name, string discription);
        public event ChangedTickets NewTicket;
        
        public Passenger(string n, string sn)
        {
            Name = n;
            Surname = sn;
        }

        public string GetName()
        {
            return Name;
        }
        
        public string GetSurname()
        {
            return Surname;
        }
        public void InputPassportData()
        {
            Console.WriteLine("Enter passport number of {0} {1}:", Name, Surname);
            var num = Console.ReadLine();
            PassportNumber = num;
        }

        public IEnumerable<(string, long)> GetEachDirectionWithSpentSum()
        {
            var sortedOrders = Orders.GroupBy(order => order.GetDirection())
                .Select(group => (group.Key, group.Sum(or => or.GetPrice()) ) )
                .ToList();
            return sortedOrders;
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
                NewTicket?.Invoke($"New ticket({i+1})",$"was bought by {this.Name} {this.Surname}");
            }

            GetPassangerInfo();
            for (int i = 0; i < ticket.Length; ++i)
            {
                Console.WriteLine("\nTicket {0}", i + 1);
                ticket[i].TarrifInfo();
            }
            PrintPersonalTotalSum();
        }

        public uint GetAmountOfTickets()
        {
            return (uint) Orders.Count;
        }

        public long PersonalTotalSum()
        {
            long sum = 0;
            for (int i = 0; i < GetAmountOfTickets(); ++i)
            {
                sum += Orders[i].GetPrice();
            }
            return sum;
        }

        public void PrintPersonalTotalSum()
        {
            Console.WriteLine($"\n\tTotal sum for {Name}'s {Surname} {GetAmountOfTickets()} orders: {this.PersonalTotalSum()} $");
        }
    }
}