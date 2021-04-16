using System;
using System.Collections.Generic;
using System.Text;

namespace MyClass2._0
{
    sealed class StudentOfSpeciality : Student
    {
        public enum AcademicPermonances
        {
            awful,
            bad,
            average,
            good,
            excellent
        }
        public string Speciality { get; set; }
        public int Group { get; set; }
        public AcademicPermonances AcademicPerformance { get; set; }
        public bool IsHeadman(string answer)
        {
            return (answer == "yes");
        }
        public override void info()
        {
            base.info();
            if (IsHeadman(answer))
            {
                Console.WriteLine("Also he(she) is a Headman of the group!");
            }
        }
        public string answer { get; set; }
    }
}
