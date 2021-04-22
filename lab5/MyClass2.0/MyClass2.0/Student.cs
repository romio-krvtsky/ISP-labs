using System;

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
        public override void Info()
        {
            Console.Write(value: Name);
            Console.Write(" is a student of ");
            Console.WriteLine(value: University);
        }
    }
}
