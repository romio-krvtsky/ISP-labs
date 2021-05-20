using System;

namespace MyClass2._0
{
   
    sealed class Student : Schoolkid, IComparable<Student>, IMaster
    {       
        public Universities University { get; set; }
        public string Faculty { get; set; }
        public int YearOfEntering { get; set; }
        public string Speciality { get; set; }
        public int Group { get; set; }
        public AcademicPermonances AcademicPerformance { get; set; }
        public Degrees Degree { get; set; }
        public int Course { get; set; }

        public void UpDegree()
        {
            if (Course == 4 && AcademicPerformance == AcademicPermonances.excellent)
            {
                if (Degree == Degrees.Bachelor)
                {
                    Degree = Degrees.Master;
                }
                else if (Degree == Degrees.Master)
                {
                    Degree = Degrees.Graduate;
                }
            }
            else
            {
                Console.WriteLine("Fail! Doesn't pass.");
            }
        }

        public int CompareTo(Student other)
        {
            if (YearOfEntering > other.YearOfEntering)
                return 1;
            else if (YearOfEntering < other.YearOfEntering)
                return -1;
            else
                return 0;
        }

        private bool WillBeDeducted()
        {
            return AcademicPerformance == AcademicPermonances.awful;
        }
        public override void Info()
        {
            base.Info();

            if (University == Universities.undefined)
            {
                Console.WriteLine("A student of unknown university");
            }
            else
            {
                Console.WriteLine($"A student of {University}");
            }

            Console.WriteLine($"Academic Perfomance: {AcademicPerformance}");

            if (WillBeDeducted())
            {
                Console.WriteLine($"Unfortunately {Name}  will be deducted because of awful academic perfomance.");
            }

            if (Degree == Degrees.Master)
            {
                Console.WriteLine("This student is getting Master degree.");
            }

            HasSchoolarship?.Invoke(Schoolarship());

            Console.WriteLine("______________________________________________________\n\n");
        }

        public string Schoolarship()
        {
            if (AcademicPerformance == AcademicPermonances.awful || AcademicPerformance == AcademicPermonances.bad)
            {
                return $"{Name} hasn't schoolarship. This stident should study better!";
            }
            else if (AcademicPerformance == AcademicPermonances.average)
            {
                return $"{Name} has minimal schoolarship(80 BYN).";
            }
            else if (AcademicPerformance == AcademicPermonances.good)
            {
                return $"{Name} has standart schoolarship(98 BYN)";
            }
            else if (AcademicPerformance == AcademicPermonances.excellent)
            {
                return $"{Name} has increased scroolarship(125 BYN)";
            }
            else return "no information about scholarship";
        }

        public delegate void StudentSchoolarship(string sclrsh);

        public event StudentSchoolarship HasSchoolarship;
    }

    enum Universities
    {
        undefined,
        BSU,
        BSUIR,
        BNTU,
        BSTU,
        BSEU,
        BSMU,
        BSPU,
        BSUAK,
        BSUPC,
        MSLU,
        MITSO
    }

    enum Degrees
    {
        undefined,
        Bachelor,
        Master,
        Graduate
    }

    enum AcademicPermonances
    {
        undefined,
        awful,
        bad,
        average,
        good,
        excellent
    }

}
