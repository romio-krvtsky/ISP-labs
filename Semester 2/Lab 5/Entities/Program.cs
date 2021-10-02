
namespace ConsoleApp1.Entities
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creation of Airport Ticket Office
            Tariff tar1 = new(100, "Warsaw", Tariff.AirTicketClasses.Ecomony);
            Tariff tar2 = new(500, "Paris", Tariff.AirTicketClasses.Business);
            Tariff tar3 = new(1000, "Kyiv", Tariff.AirTicketClasses.First);
            AirportTicketOffice.AddTariff(tar1,tar2,tar3);
            
            var pers1 = new Passenger("Neymar", "Jr");
            pers1.InputPassportData();
            var pers2 = new Passenger("Volodymyr", "Zelensky");
            pers2.InputPassportData();
            var pers3 = new Passenger("Baba", "Valya");
            pers3.InputPassportData();

            AirportTicketOffice.AddPassenger(pers1, pers2, pers3);
            AirportTicketOffice.AmountOfTarrifs();
            pers1.Order(tar1,tar2,tar3);
            pers2.Order(tar1,tar3);
            pers3.Order(tar1);
            
            AirportTicketOffice.AmountOfPassengers();
            AirportTicketOffice.Profit();

        }
    }
}