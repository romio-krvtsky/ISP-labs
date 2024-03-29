﻿using System;


namespace MyClass2._0
{
    abstract class Human
    {
        public string Name { get; set; } = "Mr X";
        public string Surname { get; set; }
        public Sexs Sex { get; set; }
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
        public HairColor Hair { get; set; }
        public string NativeCity { get; set; }
        public Countries Citizenship { get; set; }
        public virtual void Info()
        {
            Console.WriteLine($"\t{Name} {Surname}");
            Console.WriteLine($"Sex: {Sex}");
            if (Age == 0)
            {
                Console.WriteLine("Age: unknown");
            }
            else
            {
                Console.WriteLine($"Age: {Age}");
            }
            if (PhoneNumber == 0)
            {
                Console.WriteLine("Phone number: unknown");
            }
            else
            {
                Console.WriteLine($"Phone number: {PhoneNumber}");
            }
            Console.WriteLine($"Citizenship: {Citizenship}");
        }
    }

    enum Countries
    {
        undefined,
        UA,
        BY,
        EU,
        US,
        UK,
        KZ,
        RU,      
        SU
    }

    enum Sexs
    {
        undefined,
        male,
        female
    }

    enum HairColor
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

}
