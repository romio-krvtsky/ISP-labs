using System;

namespace fraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Rational f1 = new Rational(3, 9);
            Rational f2 = new Rational(5, 6);
            Rational testF;
            Console.WriteLine("Testing math operations");
            testF = f1 * f2;
            Console.WriteLine($"f1 * f2 = {testF}");
            testF = f1 / f2;
            Console.WriteLine($"f1 / f2 = {testF}");
            testF = f1 + f2;
            Console.WriteLine($"f1 + f2 = {testF}");
            testF = f1 - f2;
            Console.WriteLine($"f1 - f2 = {testF}");
            Console.WriteLine("Testing comparison operations");
            Console.WriteLine($"f1 > f2 = {f1 > f2}");
            Console.WriteLine($"f1 < f2 = {f1 < f2}");
            Console.WriteLine($"f1 >= f2 = {f1 >= f2}");
            Console.WriteLine($"f1 <= f2 = {f1 <= f2}");
            Console.WriteLine($"f1 == f2 = {f1 == f2}");
            Console.WriteLine($"f1 != f2 = {f1 != f2}");
            Console.WriteLine("Testing object to string ");
            Console.WriteLine($"f1 -> ToString(F) = {f1.ToString()}");
            Console.WriteLine($"f1 -> ToString(D) = {f1.ToString("D", null)}");
            Console.WriteLine($"f1 -> ToString(F) = {f1.ToString("D3", null)}");
            Console.WriteLine($"f1 -> ToString(F) = {f1.ToString("F4", null)}");

            try
            {
                f1.ToString("I", null);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Testing string to object");
            testF = Rational.Parse("350/100");
            Console.WriteLine($"testF = 350/150 = {testF}");
            testF = Rational.Parse("1000");
            Console.WriteLine($"testF = 1000 = {testF}");
            testF = Rational.Parse("350.100");
            Console.WriteLine($"testF = 350.150 = {testF}");
            testF = Rational.Parse("350,100");
            Console.WriteLine($"testF = 350,150 = {testF}");
            try
            {
                testF = Rational.Parse("350//100");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
