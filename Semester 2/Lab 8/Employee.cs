using System;

namespace lab8
{
    public class Employee
    {
        public string Name { get; set; }
        
        public int Salary { get; set; }
        
        public bool HasAnExperience { get; set; }

        public Employee(string name, int salary, bool hasAnExperience)
        {
            Name = name;
            Salary = salary;
            HasAnExperience = hasAnExperience;
        }
        
        public void PrintInfo()
        {
            Console.WriteLine($"Name:{Name} Salary:{Salary} Has an experince:{HasAnExperience}");
           
        }
    }
    
    
}