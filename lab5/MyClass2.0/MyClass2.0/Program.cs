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
                AcademicPerformance = StudentOfSpeciality.AcademicPermonances.average,
                Age = 18,
                Sex = Human.Sexs.male
            };
            Console.WriteLine(Pers1.AcademicPerformance);
            Console.WriteLine(Pers1.Age);

            Pers1.Info();
            Console.WriteLine("Is he a Headman? (yes/no)");
            Pers1.IsHeadman(Pers1.Answer = Console.ReadLine());
            Pers1.Info();

            Console.WriteLine("--------------------------------------------");

            StudentOfSpeciality Pers2 = new StudentOfSpeciality()
            {
                Name = "Lyoha",
                Surname = "Lazy",
                University = Student.Universities.BNTU,
                AcademicPerformance = StudentOfSpeciality.AcademicPermonances.awful
            };
            Pers2.Info();

            Console.WriteLine("--------------------------------------------");

            Human hum = new Student();
            hum.Info();

        }
    }
}

