using System;


namespace MyClass2._0
{

    abstract class Human
    {
        public enum Sexs
        {
            undefined,
            male,
            female
        }
        public enum HairColor
        {
            undefined,
            Black,
            Blonde,
            Brown,
            Fair,
            Grey,
            Ginger,
            Bald
        }
        public string Name { get; set; } = "Mr X";
        public string Surname { get; set; }
        public string Citizenship { get; set; }
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("age is a positive number!");
                }
                age = value;
            }
        }
        private int phoneNumber;
        public int PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("age is a positive number!");
                }
                phoneNumber = value;
            }
        }
        private int weight;
        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("weight is a positive number!");
                }
                weight = value;
            }
        }
        private int height;
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("height is a positive number!");
                }
                height = value;
            }
        }
        public Sexs Sex { get; set; }
        public HairColor Hair { get; set; }
        public string NativeCity { get; set; }
        public virtual void Info()
        {
            Console.Write(value: Name);
            Console.Write(" ");
            Console.WriteLine(value: Surname);
            Console.Write("Sex: ");
            Console.WriteLine(value: Sex);
        }
    }
}
