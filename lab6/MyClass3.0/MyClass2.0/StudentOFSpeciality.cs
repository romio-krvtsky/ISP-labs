using System;


namespace MyClass2._0
{
    sealed class StudentOfSpeciality : Student, IComparable<StudentOfSpeciality>, IMaster
    {
        public enum Degrees
        {
            undefined,
            Bachelor,
            Master,
            Graduate
        }
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

        public int CompareTo(StudentOfSpeciality other)
        {
            if (Group > other.Group)
                return 1;
            else if (Group < other.Group)
                return -1;
            else
                return 0;
        }

        public enum AcademicPermonances
        {
            undefined,
            awful,
            bad,
            average,
            good,
            excellent
        }
        public string Speciality { get; set; }
        public int Group { get; set; }
        public AcademicPermonances AcademicPerformance { get; set; }
        public Degrees Degree { get; set; }

        public bool WillBeDeducted()
        {
            return AcademicPerformance == AcademicPermonances.awful;
        }

        public bool IsHeadman(string answer)
        {
            return (answer == "yes");
        }
        public override void Info()
        {
            base.Info();
            if(AcademicPerformance == AcademicPermonances.undefined)
            {
                Console.WriteLine("A student without marks");
            }
            if (IsHeadman(Answer))
            {
                Console.WriteLine("Also he(she) is a Headman of the group!");
            }
            if (WillBeDeducted())
            {
                Console.Write("Unfortunately ");
                Console.Write(value: Name);
                Console.WriteLine(" will be deducted because of awful academic perfomance.");
            }
            if (Degree == Degrees.Master)
            {
                Console.WriteLine("This student is getting Master degree.");
            }
        }
        public string Answer { get; set; }
    }
}
