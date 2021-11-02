using System;
using System.Collections.Generic;
using ConsoleApp1.Entities;
using System.Linq;
namespace Lab7.Entities
{
    public static class AirportTicketOffice
    {
        public static readonly List<Passenger> ClientBase = new();
        public static readonly Dictionary<string, Tariff> Tariffs = new();

        public static Journal EventJournal { get; set; }

        public delegate void ChangeClientBase(string name, string discription);

        public delegate void ChangeTariff(string name, string discription);

        public static event ChangeClientBase NewPassenger;
        public static event ChangeTariff NewTariff;

        public static IEnumerable<string> GetSortedTariffsByPrice()
        {
            var sortedRates = from tariff in Tariffs
                orderby tariff.Value.GetPrice()
                select tariff.Key;
            return sortedRates;
        }

        public static long GetTotalAirportProfit()
        {
            var totalSum = ClientBase.Sum(passenger => passenger.PersonalTotalSum());
            return totalSum;
        }

        public static void GetTotalPassengerSum(string name)
        {
            var newPassengers = from psngr in ClientBase 
                where psngr.GetName() == name
                select psngr;
            if (newPassengers.Count() == 0)
            {
                throw new NullReferenceException("No such tenant");
            }
            newPassengers.First().PrintPersonalTotalSum();
        }

        public static string GetPassengerNamewithMaxSum()
        {
            var newPassengers = from psngr in ClientBase
                orderby psngr.PersonalTotalSum()
                select psngr;
            return newPassengers.Last().GetName();
        }
        
        public static int GetAmountOfPassengersWithSumMore(int sum)
        {
            int amount = (from pas in ClientBase 
                where pas.PersonalTotalSum() > sum 
                select pas).Count();
            return amount;
        }
        
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
                NewPassenger?.Invoke($"{passenger.GetName()} {passenger.GetSurname()}",
                    "is a new passenger of airport");
            }
        }

        public static void AddTariff(params Tariff[] tariffs)
        {
            foreach (var tariff in tariffs)
            {
                Tariffs.Add(tariff.GetDirection(), tariff);
                NewTariff?.Invoke($"New Tarrif to {tariff.GetDirection()}", "was added to the airport ticket office");
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

        
    }
}
