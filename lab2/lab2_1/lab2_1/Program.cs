using System;
using System.Text;

namespace lab2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string d = Console.ReadLine();
            string[] words = d.Split(' ');
            for (int i = words.Length - 1; i >= 0; i--)
            {
                Console.Write("{0} ", words[i]);
            }
        }
    }
}
