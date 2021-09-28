using System;
using System.Drawing;
using ConsoleApp1.Entities;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* test of my custom collection
            var lst = new MyCustomCollection<int>();
            for (int i = 0; i < 30; i += 5)
            {
                lst.Add(i);
            }
            lst.Print();
            Console.WriteLine($"\nSize = {lst.Count}");
            lst.Reset();
            for (int i = 0; i < 4; ++i)
            {
                lst.Next();    
            }
            Console.WriteLine(lst.Current());
            lst.Print();
            Console.WriteLine(lst.RemoveCurrent());
            Console.WriteLine($"\nSize = {lst.Count}");
            lst.Print();
            lst.Reset();
            Console.WriteLine($"\n{lst.Current()}");
            Console.WriteLine(lst[2]);
            lst[4] = 213;
            lst.Print();
            */
            
            //Creation of airport ticket office
            Passenger pass1 = new("Neymar", "JR", Passenger.Sexs.Male);
            pass1.InputPassportData();
            pass1.Order(135,"Paris",Tariff.AirTicketClasses.Business);
            pass1.Order(155, "LA", Tariff.AirTicketClasses.Ecomony);
            pass1.Order(500, "Kyiv", Tariff.AirTicketClasses.First);
            pass1.PersonalTotalSum();

            Passenger pass2 = new("Jessica", "Alba", Passenger.Sexs.Female);
            pass2.InputPassportData();
            pass2.Order(120,"Warsaw",Tariff.AirTicketClasses.Ecomony);
            pass2.Order(1000,"Lisbon",Tariff.AirTicketClasses.Business);
            pass2.PersonalTotalSum();
            
            AirportTicketOffice.AmountOfPassengers();
            AirportTicketOffice.Profit();
        }
    }
}