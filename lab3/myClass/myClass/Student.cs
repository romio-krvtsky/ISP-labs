using System;
using System.Collections.Generic;


namespace myClass
{
    class Student : Human
    {
        public string University { get; set; }
        public int YearOfEntering { get; set; }
        public string Faculty { get; set; }
    }

    class StudentOfSpeciality : Student
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
        public string Subject { get; set; }
    }

}
