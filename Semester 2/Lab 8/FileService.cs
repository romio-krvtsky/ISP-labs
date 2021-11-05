using System;
using System.Collections.Generic;
using System.IO;

namespace lab8
{
    public class FileService: IFileService

    {
        public IEnumerable<Employee> ReadFile(string fileName)
        {
            if (!File.Exists(fileName)) 
                throw new Exception("Error! No such file!");
            
            using var reader = new BinaryReader(File.Open(fileName,FileMode.Open));
            while (reader.PeekChar() > -1)
            {
                string name = reader.ReadString();
                int salary = reader.ReadInt32();
                bool hasAnExperience = reader.ReadBoolean();

                yield return new Employee(name, salary, hasAnExperience);
            }

            
        }

        public void SaveData(IEnumerable<Employee> data, string fileName)
        {
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            using var writer = new BinaryWriter(File.Open(fileName, FileMode.OpenOrCreate));
            {
                foreach (var emp in data)
                {
                    writer.Write(emp.Name);
                    writer.Write(emp.Salary);
                    writer.Write(emp.HasAnExperience);
                }

            }
        }
    }
}