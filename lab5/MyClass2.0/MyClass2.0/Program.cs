using System;

namespace MyClass2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentOfSpeciality Pers1 = new StudentOfSpeciality() 
            {
                Name = "Roman",
                University = Student.Universities.BSUIR,
                Race = Human.Races.Caucasian,
                AcademicPerformance = StudentOfSpeciality.AcademicPermonances.average,
                Age = 18,
            };
            Console.WriteLine(Pers1.Race);
            Console.WriteLine(Pers1.AcademicPerformance);
            Console.WriteLine(Pers1.Age);

            Pers1.Info();
            Console.WriteLine("Are you a Headman? (yes/no)");         
            Pers1.IsHeadman(Pers1.Answer = Console.ReadLine());
            Pers1.Info();

            StudentOfSpeciality Pers2 = new StudentOfSpeciality()
            {
                Name = "Lyoha",
                University = Student.Universities.BNTU,
                AcademicPerformance = StudentOfSpeciality.AcademicPermonances.awful
            };
            Pers2.Info();
        }
    }
}

