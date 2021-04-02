using System;
using System.Collections.Generic;


namespace myClass
{
    public class Human
    {
        public enum Sexs
        {
            male,
            female
        }
        public enum Races
        {
            Caucasian,
            Mongoloid,
            Negroid,
            Australoid
        }
        public enum HairColor
        {
            Black,
            Blonde,
            Brown,
            Fair,
            Grey,
            Ginger,
            Bald
        }

        public string Name { get; set; }
        public string Surname { get; set; }
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
        public Races Race { get; set; }
        public HairColor Hair { get; set; }
    }
}
