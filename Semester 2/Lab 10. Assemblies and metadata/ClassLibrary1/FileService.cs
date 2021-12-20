using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Lab10.Domain
{
    public class FileService<T> : IFileService<T> where T : class
    {
        public IEnumerable<T> ReadFile(string filename) 
        {
            using (StreamReader file = File.OpenText(filename))
            {
                JsonSerializer serializer = new JsonSerializer();
                T[] employees = (T[])serializer.Deserialize(file, typeof(Employee[]));
                return employees;
            }
        }

        public void SaveData(IEnumerable<T> data, string filename)
        {
            using (StreamWriter file = File.CreateText(filename))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, data);
            }
        }
    }
}