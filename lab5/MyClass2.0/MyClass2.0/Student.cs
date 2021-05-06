using System;

namespace MyClass2._0
{
    class Student : Human
    {
        public enum Universities
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
        public Universities University { get; set; }
        public string Faculty { get; set; }
        public int YearOfEntering { get; set; }
        public override void Info()
        {
            base.Info();
            if (University == Universities.undefined)
            {
                Console.WriteLine("A student of unknown university");
            }
            else
            {
                Console.Write(" A student of ");
                Console.WriteLine(value: University);
            }
        }
    }
}
