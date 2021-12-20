using System;
using System.Diagnostics;

namespace ClassLibrary1
{

    public class Calculations
    {
        public delegate void Res(double res);

        public event Res? ShowResult;

        public void ResultInf(double res)
        {
            Console.WriteLine(res);
        }

        public void Integral()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            double x, h;
            double s = 0;
            const double capacity = 0.00000001;
            
            for (x = capacity / 2; x < 1; x += capacity)
            {
                var y = Math.Sin(x);
                s += y * capacity; // Элементарное приращение
            }

            ShowResult?.Invoke(s);
            watch.Stop();
            Console.WriteLine(watch.Elapsed);

        }

    }
}