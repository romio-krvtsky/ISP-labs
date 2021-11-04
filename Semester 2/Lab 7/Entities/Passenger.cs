using System;
using System.Collections.Generic;
using System.Linq;
namespace Lab7.Entities
{
    public class Passenger
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        private string PassportNumber { get; set; }
        private List<Tariff> Orders = new();

        public delegate void ChangedTickets(string name, string discription);
        public event ChangedTickets NewTicket;
        
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

        public IEnumerable<(string, long)> GetEachDirectionWithSpentSum()
        {
            var sortedOrders = Orders.GroupBy(order => order.Direction)
                .Select(group => (group.Key, group.Sum(or => or.Price) ) )
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
                sum += Orders[i].Price;
            }
            return sum;
        }

        public void PrintPersonalTotalSum()
        {
            Console.WriteLine($"\n\tTotal sum for {Name}'s {Surname} {GetAmountOfTickets()} orders: {this.PersonalTotalSum()} $");
        }
    }
}