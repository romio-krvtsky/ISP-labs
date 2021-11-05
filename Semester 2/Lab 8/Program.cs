using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace lab8
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var workers = new List<Employee>();
            workers.Add(new Employee("Alex", 1200, true));
            workers.Add(new Employee("Ze President", 23000, true));
            workers.Add(new Employee("Romio", 500, false));
            workers.Add(new Employee("Nik", 500, false));
            workers.Add(new Employee("Mr X", 6666, true));

            var fileserv = new FileService();

            fileserv.SaveData(workers, @"D:\JetBrains\Projects\C#Projects\lab8\lab8\File.txt");

            File.Move(@"D:\JetBrains\Projects\C#Projects\lab8\lab8\File.txt",
                @"D:\JetBrains\Projects\C#Projects\lab8\lab8\NewFile.txt", true);

            IEnumerable<Employee> newEmployees = new List<Employee>();

            newEmployees = fileserv.ReadFile(@"D:\JetBrains\Projects\C#Projects\lab8\lab8\NewFile.txt");
            var sortEmployees = newEmployees.OrderBy(employee => employee, new EmployeeComparer());

            foreach (var empl in sortEmployees)
            {
                empl.PrintInfo();
            }
        }
    }
}