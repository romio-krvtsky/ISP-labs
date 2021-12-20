namespace Lab10
{
    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool HasAnExperience { get; set; }
        
        public Employee(string name,int age,bool has)
        {
            Name = name;
            Age = age;
            HasAnExperience = has;
        }
        
    }
   
}