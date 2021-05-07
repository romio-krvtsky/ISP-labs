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
                YearOfEntering = 2020,
                AcademicPerformance = StudentOfSpeciality.AcademicPermonances.excellent,
                Age = 18,
                Sex = Human.Sexs.male,
                Degree = StudentOfSpeciality.Degrees.Bachelor,
                Course = 4

            };
            Console.WriteLine(Pers1.AcademicPerformance);
            Console.WriteLine(Pers1.Age);

            Pers1.Info();

            Console.WriteLine("--------------------------------------------");

            StudentOfSpeciality Pers2 = new StudentOfSpeciality()
            {
                Name = "Lyoha",
                Surname = "Lazy",
                University = Student.Universities.BNTU,
                YearOfEntering = 2018,
                AcademicPerformance = StudentOfSpeciality.AcademicPermonances.awful
            };
            Pers2.Info();

            Console.WriteLine("--------------------------------------------");

            Human hum = new Student();
            hum.Info();
            
            Pers2.YearOfEntering.CompareTo(Pers1.YearOfEntering);

            IMaster master = new StudentOfSpeciality();
            master = Pers1;

            Console.WriteLine("----------------");
            Pers1.UpDegree();
            Pers1.Info();
                       

        }
    }
}

