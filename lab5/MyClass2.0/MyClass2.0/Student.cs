using System;
using System.Collections.Generic;
using System.Text;

namespace MyClass2._0
{
    class Student : Human
    {
        public enum Universities
        {
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
        public Universities University { get; set; }
        public string Faculty { get; set; }
        public int YearOfEntering { get; set; }
        public virtual void info()
        {
            Console.Write("is a student!!");
        }
    }
}
