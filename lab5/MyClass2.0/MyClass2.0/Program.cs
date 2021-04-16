using System;

namespace MyClass2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentOfSpeciality Vasya = new StudentOfSpeciality();
            Vasya.Race = Human.Races.Caucasian;
            Console.WriteLine(Vasya.Race);
            Vasya.AcademicPerformance = StudentOfSpeciality.AcademicPermonances.average;
            Console.WriteLine(Vasya.AcademicPerformance);
            Vasya.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Vasya.Age);

            Vasya.info();
            Vasya.answer = "yes";
            Vasya.IsHeadman(Vasya.answer);
            Vasya.info();
        }
    }
}
