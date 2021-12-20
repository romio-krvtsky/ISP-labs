using System;
using System.Collections.Generic;
using System.Reflection;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>();
            employees.Add(new Employee("Romio", 18, false));
            employees.Add(new Employee("Naruto", 32, true));
            employees.Add(new Employee("Roksolana", 19, false));
            employees.Add(new Employee("Oleg Vinnyk", 48, true));
            employees.Add(new Employee("Andrzej", 49, true));
            Assembly asm = Assembly.LoadFrom("Lab10.Domain.dll");
            Console.WriteLine(asm.FullName);

            Type[] types = asm.GetTypes();
            Type my = types[0].MakeGenericType(new Type[] {typeof(Employee)});

            object? obj = Activator.CreateInstance(my);

            MethodInfo? saveData = my.GetMethod("Savedata");
            MethodInfo? saveData1 = my.GetMethod("ReadFile");

            saveData?.Invoke(obj, new object[] {employees, "employees.txt"});
            saveData1?.Invoke(obj, new object[] {"employees.txt"});

        }
    }
}