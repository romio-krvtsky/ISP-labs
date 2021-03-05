using System;
using System.Numerics;

namespace cubic_equation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, p, q, D;

            Complex x1, x2, x3, y1, y2, y3;

            Console.WriteLine("\t Solution of cubic equation");
            Console.WriteLine("\t General view:   ax^3 + bx^2 + cx + d = 0 ");
            //input of coefficients
            Console.WriteLine("Enter a:"); a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter b:"); b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter c:"); c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter d:"); d = Convert.ToDouble(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("Error! This is not a cubic equation!");
            }
            else
            {
                //make 3 changes of variables: x = y - b / 3a
                p = (3 * a * c - Math.Pow(b, 2)) / (3 * Math.Pow(a, 2));
                q = (2 * Math.Pow(b, 3.0) - 9 * a * b * c + 27 * Math.Pow(a, 2.0) * d) / (27 * Math.Pow(a, 3));
                //now view of equation is  y^3 + py + q = 0

                //one more change of variable:
                D = Math.Pow(p / 3, 3) + Math.Pow(q / 2, 2);

                if (D == p)
                { //triple angle cosine method
                    double pi = Math.PI;
                    double k = Math.Sqrt((-4 * p) / 3);
                    double angle = (-q * Math.Sqrt(27.0)) / (2 * Math.Sqrt(-Math.Pow(p, 3.0)));
                    double cos1 = Math.Cos((1.0 / 3.0 * Math.Acos(angle)));
                    double cos2 = Math.Cos((1.0 / 3.0 * Math.Acos(angle)) + 2 * pi / 3);
                    double cos3 = Math.Cos((1.0 / 3.0 * Math.Acos(angle)) + 4 * pi / 3);
                    y1 = k * cos1;
                    y2 = k * cos2;
                    y3 = k * cos3;
                    x1 = y1 - b / (3 * a);
                    x2 = y2 - b / (3 * a);
                    x3 = y3 - b / (3 * a);
                    Console.WriteLine("The roots of equation are :");
                    Console.WriteLine("x1 = " + x1);
                    Console.WriteLine("x2 = " + x2);
                    Console.WriteLine("x3 = " + x3);
                }
                else
                {
                    //finding the roots by Cardano Formula
                    // 2 extra variables:

                    Complex D_i = Complex.Sqrt(D);
                    Complex q_i = q / 2.0;
                    Complex i = new Complex(0, 1);

                    Complex z = Complex.Pow(Complex.Add(-q_i, D_i), (1.0 / 3.0));
                    Complex t = Complex.Pow(Complex.Add(-q_i, -D_i), (1.0 / 3.0));

                    y1 = Complex.Add(z, t);
                    y2 = -y1 / 2 + (Complex.Add(z, -t) * Math.Sqrt(3.0) / 2) * i;
                    y3 = -y1 / 2 - (Complex.Add(z, -t) * Math.Sqrt(3.0) / 2) * i;

                    x1 = y1 - b / (3.0 * a);
                    x2 = y2 - b / (3.0 * a);
                    x3 = y3 - b / (3.0 * a);

                    Console.WriteLine("x1 = " + x1);
                    Console.WriteLine("x2 = " + x2);
                    Console.WriteLine("x3 = " + x3);
                }
            }
        }
    }
}
