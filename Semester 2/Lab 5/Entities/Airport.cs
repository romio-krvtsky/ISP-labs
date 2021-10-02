using System;
using ConsoleApp1.Collections;

namespace ConsoleApp1.Entities
{
    public static class AirportTicketOffice
    {
        public static readonly MyCustomCollection<Passenger> ClientBase = new();
        public static readonly MyCustomCollection<Tariff> Tariffs = new();

        private static uint GetAmountOfPassengers()
        {
            return (uint) ClientBase.Count;
        }

        private static uint GetAmountOfTarrifs()
        {
            return (uint) Tariffs.Count;
        }

        public static void AddPassenger(params Passenger[] passengers)
        {
            foreach (var passenger in passengers)
            {
                ClientBase.Add(passenger);
            }
        }

        public static void AddTariff(params Tariff[] tariffs)
        {
            foreach (var tariff in tariffs)
            {
                Tariffs.Add(tariff);
            }
        }

        public static void AmountOfTarrifs()
        {
            Console.WriteLine("The amount of available tariffs of Airport Ticket Office: {0}", GetAmountOfTarrifs());
        }

        public static void AmountOfPassengers()
        {
            Console.WriteLine("The amount of passengers of Airport Ticket Office: {0}", GetAmountOfPassengers());
        }

        public static void Profit()
        {
            uint totalSum = 0;
            for (int i = 0; i < GetAmountOfPassengers(); ++i)
            {
                totalSum += ClientBase[i].PersonalTotalSum();
            }

            Console.WriteLine($"The actual profit of Airport Ticket Office: {totalSum}$");
        }

    }
}
