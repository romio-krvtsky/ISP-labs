using System.Collections.Generic;

namespace lab8
{
    public interface IFileService
    {
        IEnumerable<Employee> ReadFile(string fileName);
        void SaveData(IEnumerable<Employee> data, string fileName);
    }
}