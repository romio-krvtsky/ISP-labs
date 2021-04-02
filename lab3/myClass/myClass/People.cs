using System;
using System.Collections.Generic;


namespace myClass
{
       public class People
    {
        List<Human> people;
        public People()
        {
            people = new List<Human>();
            amount = 0;
        }

        
        public Human this[int index]
        {
            get
            {
                if (index < 0 || index >= amount)
                {
                    throw new Exception("There is no such index");
                }
                return people[index];
            }
            set
            {
                people.Insert(index, value);
                ++amount;
            }
        }

        private int amount;
    }
}
