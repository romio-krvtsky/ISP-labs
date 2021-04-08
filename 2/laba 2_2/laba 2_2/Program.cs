using System;

namespace laba_2_2
{
    class Program
    {
        public static double ReadDouble()
        {
            double number;
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Wrong format, enter the correct number.\n");
            }
            return number;
        }

        static void Main(string[] args)
        {

            double a, b, c, angleA, angleB, angleC, r, R, S, P;
            double rad = Math.PI / 180;
            Console.WriteLine("What do you know about the triangle? \n" +
                "1. 3 sides \n" +
                "2. 2 sides and 1 angle\n" +
                "3. 1 side and 2 angles\n");
            Console.WriteLine("Your choice:");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("enter the length of side a: "); a = ReadDouble();
                    Console.WriteLine("enter the length of side b: "); b = ReadDouble();
                    Console.WriteLine("enter the length of side c: "); c = ReadDouble();

                    if ((a + b > c) && (a + c > b) && (b + c > a))
                    {
                        P = a + b + c;
                        Console.WriteLine("\nPerimeter = " + P);
                        S = Math.Sqrt(P / 2.0 * (P / 2.0 - a) * (P / 2.0 - b) * (P / 2.0 - c));
                        Console.WriteLine("Square = " + S);
                        R = (a * b * c) / (4 * S);
                        Console.WriteLine("Big radius = " + R);
                        r = 2 * S / P;
                        Console.WriteLine("Small radius = " + r);
                        angleA = Math.Asin(2 * S / (b * c)) / rad;
                        Console.WriteLine("Angle A = {0} degrees ", angleA);
                        angleB = Math.Asin(2 * S / (a * c)) / rad;
                        Console.WriteLine("Angle B = {0} degrees ", angleB);
                        angleC = Math.Asin(2 * S / (b * a)) / rad;
                        Console.WriteLine("Angle C = {0} degrees ", angleC);
                    }
                    else
                    {
                        Console.WriteLine("Error! Such triangle doesn't exist!");
                    }
                    break;

                case "2":
                    Console.WriteLine("enter the length of side 1: "); a = ReadDouble();
                    Console.WriteLine("enter the length of side 2: "); b = ReadDouble();
                    Console.WriteLine("enter the angle (in degrees): "); angleC = ReadDouble();

                    c = Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos(angleC * rad));
                    Console.WriteLine("\nSide 3 = " + c);
                    P = a + b + c;
                    Console.WriteLine("Perimeter = " + P);
                    S = Math.Sqrt(P / 2.0 * (P / 2.0 - a) * (P / 2.0 - b) * (P / 2.0 - c));
                    Console.WriteLine("Square = " + S);
                    R = (a * b * c) / (4 * S);
                    Console.WriteLine("Big radius = " + R);
                    r = 2 * S / P;
                    Console.WriteLine("Small radius = " + r);
                    angleA = Math.Asin(2 * S / (b * c)) / rad;
                    Console.WriteLine("The 2nd angle = {0} degrees ", angleA);
                    angleB = 180 - angleC - angleA;
                    Console.WriteLine("The 3rd angle = {0} degrees ", angleB);

                    break;

                case "3":
                    Console.WriteLine("enter the length of side 1: "); a = ReadDouble();
                    Console.WriteLine("enter the angle 1(in degrees): "); angleB = ReadDouble();
                    Console.WriteLine("enter the angle 2(in degrees): "); angleC = ReadDouble();
                    if ((angleB + angleC) < 180)
                    {
                        angleA = 180 - angleB - angleC;
                        Console.WriteLine("\nThe 3rd angle = {0} degrees ", angleA);
                        b = a * Math.Sin(angleB * rad) / Math.Sin(angleA * rad);
                        Console.WriteLine("Side 2 = " + b);
                        c = a * Math.Sin(angleC * rad) / Math.Sin(angleA * rad);
                        Console.WriteLine("Side 3 = " + c);
                        P = a + b + c;
                        Console.WriteLine("Perimeter = " + P);
                        S = Math.Sqrt(P / 2.0 * (P / 2.0 - a) * (P / 2.0 - b) * (P / 2.0 - c));
                        Console.WriteLine("Square = " + S);
                        R = (a * b * c) / (4 * S);
                        Console.WriteLine("Big radius = " + R);
                        r = 2 * S / P;
                        Console.WriteLine("Small radius = " + r);
                    }
                    else
                    {
                        Console.WriteLine("Error! Such triangle doesn't exist!");
                    }

                    break;

                default:
                    Console.WriteLine("Wrong choice!");
                    break;
            }
        }
    }
}
