﻿using System;

namespace MyClass2._0
{
    sealed class Schoolkid: Human
    {
        public enum SchoolStages
        {
            Elementary,
            Middle,
            High,
            Advanced
        }
        public int Grade
        {
            get
            {
                return grade;
            }
            set
            {
                if (value < 0 && value > 11)
                {
                    throw new Exception("Error! Such grade doesn't exist!");
                }
                grade = value;
            }
        }
        public SchoolStages SchoolStage { get; set; } 
        public double AveragePoint
        {
            get
            {
                return averPoint;
            }
            set
            {
                if (value < 0.0 && value > 10.0)
                {
                    throw new Exception("Average point within 0-10 ");
                }
                averPoint = value;
            }
        }
        public bool HasGoldMedal()
        {
            return (AveragePoint >= 9.0);
        }
        public override void Info()
        {
            Console.Write(value: Name);
            Console.WriteLine(" was a schoolkid!"); 
            if (HasGoldMedal())
            {
                Console.WriteLine("He is going to to graduate school with gold medal.");
            }
        }
        private int grade;
        private double averPoint;
    }
}

