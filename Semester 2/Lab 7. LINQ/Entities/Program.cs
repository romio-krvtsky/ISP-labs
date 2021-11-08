
using System;

namespace Lab7.Entities
{
    static class Program
    {
        static void Main(string[] args)
        {
            //Creation of Airport Ticket Office
            var journal = new Journal();
            AirportTicketOffice.NewPassenger += journal.AddEvent;
            AirportTicketOffice.NewTariff += journal.AddEvent;
            
            Tariff tar1 = new("Warsaw", 100,Tariff.AirTicketClasses.Ecomony);
            Tariff tar2 = new("Paris",500, Tariff.AirTicketClasses.Business);
            Tariff tar3 = new("Kyiv",1000, Tariff.AirTicketClasses.First);
            Tariff tar4 = new("Lisbon", 350,Tariff.AirTicketClasses.Ecomony);
            Tariff tar5 = new("Monaco", 2000, Tariff.AirTicketClasses.Business);
            
            AirportTicketOffice.AddTariff(tar1,tar2,tar3,tar4,tar5);
            
            var pers1 = new Passenger("Neymar", "Jr");
            pers1.InputPassportData();
            var pers2 = new Passenger("Volodymyr", "Zelensky");
            pers2.InputPassportData();
            var pers3 = new Passenger("Baba", "Valya");
            pers3.InputPassportData();
            var pers4 = new Passenger("VIP", "man");
            pers4.InputPassportData();
            AirportTicketOffice.AddPassenger(pers1, pers2, pers3,pers4);
            AirportTicketOffice.AmountOfTarrifs();
            pers1.NewTicket += journal.AddEvent;
            pers2.NewTicket += journal.AddEvent;
            pers3.NewTicket += journal.AddEvent;
            
            pers1.Order(tar1,tar2,tar3);
            pers2.Order(tar1,tar3,tar5);
            pers3.Order(tar1,tar4);
            pers4.Order(tar5 ,tar5,tar5,tar5);
            AirportTicketOffice.AmountOfPassengers();
            
            //journal.PrintAllEvents();

            var profit = AirportTicketOffice.GetTotalAirportProfit();
            Console.WriteLine($"Total airport profit = {profit} dollars");

            
            Console.WriteLine("List of Tariffs in ascending order:");
            var lst = AirportTicketOffice.GetSortedTariffsByPrice();
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }

            AirportTicketOffice.GetTotalPassengerSum("Volodymyr");

            var maxName = AirportTicketOffice.GetPassengerNamewithMaxSum();
            Console.WriteLine(maxName);

            var SumMore = AirportTicketOffice.GetAmountOfPassengersWithSumMore(2000);
            Console.WriteLine(SumMore);
        }
    }
}