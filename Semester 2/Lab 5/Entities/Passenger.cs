using System;

namespace ConsoleApp1.Entities
{
    public class Passenger
    {
        private string Name;
        private string Surname;
        private Sexs Sex;
        private string PassportNumber { get; set; }
        private MyCustomCollection<Tariff> Orders = new();

        public enum Sexs
        {
            Undefined,
            Male,
            Female
        }

        public Passenger(string n, string sn, Sexs sex)
        {
            Name = n;
            Surname = sn;
            Sex = sex;
        }

        public void InputPassportData()
        {
            Console.WriteLine("Enter passport number of {0} {1}:", Name, Surname);
            var num = Console.ReadLine();
            PassportNumber = num;
            AirportTicketOffice.ClientBase.Add(this);
        }

        private void GetPassangerInfo()
        {
            Console.WriteLine($"Order {Orders.Count} of {Name} {Surname}");
            Console.WriteLine($"Sex: {Sex}");
            Console.WriteLine($"Passport Number: {PassportNumber}");

        }

        public void Order(uint pr, string dir, Tariff.AirTicketClasses airTicketClass)
        {
            if (PassportNumber == null)
            {
                throw new Exception("Person can't order the ticket without passport data!!");
            }
            Tariff ticket = new(pr, dir, airTicketClass);
            Orders.Add(ticket);
            GetPassangerInfo();
            ticket.TarrifInfo(); 
            
        }

        public uint GetAmountOfTickets()
        {
            return (uint) Orders.Count;
        }

        public uint PersonalTotalSum()
        {
            uint sum=0;
            for (int i=0; i < this.GetAmountOfTickets(); ++i)
            {
                sum += Orders[i].Price;
                AirportTicketOffice.SoldTickets.Add(Orders[i].Price);
            }
            Console.WriteLine($"\n\tTotal sum for {Name}'s {Surname} {GetAmountOfTickets()} orders: {sum} $");
            return sum;
        }


    }
}