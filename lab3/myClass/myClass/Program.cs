<<<<<<< HEAD
﻿using System;

namespace myClass
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

            People men = new People();
            men[0] = Vasya;
            Console.WriteLine("Race: {0}", men[0].Race);
        }
    }
}
=======
﻿using System;

namespace myClass
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

            People men = new People();
            men[0] = Vasya;
            Console.WriteLine("Race: {0}", men[0].Race);
        }
    }
}
>>>>>>> e22244a88eae17cbdd6196ddda69650de07f570a
