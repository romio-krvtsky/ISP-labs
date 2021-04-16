using System;
using System.Collections.Generic;

namespace MyClass2._0
{
    public class Students
    {
        List<Student> students;
        public Students()
        {
            students = new List<Student>();
            amount = 0;
        }


        public Student this[int index]
        {
            get
            {
                if (index < 0 || index >= amount)
                {
                    throw new Exception("There is no such index");
                }
                return students[index];
            }
            set
            {
                students.Insert(index, value);
                ++amount;
            }
        }

        private int amount;
    }
}
}
