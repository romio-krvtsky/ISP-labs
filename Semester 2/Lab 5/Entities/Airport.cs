using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace ConsoleApp1.Entities
{
    public static class AirportTicketOffice
        {
            public static MyCustomCollection<Passenger> ClientBase = new();
            public static MyCustomCollection<uint> SoldTickets = new();
            private static uint GetAmountOfPassengers()
            {
                return (uint)ClientBase.Count;
            }

            public static void AmountOfPassengers()
            {
                Console.WriteLine("The amount of passengers of Airport Ticket Office: {0}",GetAmountOfPassengers());
            }
            public static void Profit()
            {
                uint total_sum = 0;
                for (int i = 0; i < SoldTickets.Count; ++i)
                {
                    total_sum += SoldTickets[i];
                }
                Console.WriteLine($"The actual profit of Airport Ticket Office: {total_sum}$");
            }
            
        }
    }
