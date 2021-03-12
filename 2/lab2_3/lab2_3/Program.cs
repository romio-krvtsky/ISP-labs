using System;
using System.Text;


namespace lab2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            StringBuilder str = new StringBuilder (s);
            StringBuilder strTemp = new StringBuilder(s);
            
            for (int i = 0; i < str.Length; ++i)
            {
                if (i == str.Length - 1)
                {
                    Console.Write(strTemp[i]);
                    break;
                }

                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                {
                    
                    if (str[i + 1] == 'z')
                    {
                        strTemp[i + 1] = 'a';
                    }
                    else strTemp[i + 1]++;
                }
                Console.Write(strTemp[i]);
            }
        }
    }
}
