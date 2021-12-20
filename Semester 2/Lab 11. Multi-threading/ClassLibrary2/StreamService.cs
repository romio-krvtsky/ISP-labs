using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Threading;

namespace ClassLibrary2
{
    public class StreamService
    {
        private readonly object locker = new object();

        public Task WriteToStream(Stream stream)
        {
            return Task.Run(() =>
                {
                    var rand = new Random();
                    lock (locker)
                    {
                        Console.WriteLine($"Writing to stream [{Thread.CurrentThread.ManagedThreadId}]");
                        var streamWriter = new StreamWriter(stream) {AutoFlush = true};
                        for (byte i = 0; i < 100; i++)
                            streamWriter.WriteLine(i + "\nCar Model #{" + i + "}\n" + rand.Next(0, 1));
                        Console.WriteLine($"Writing to stream end [{Thread.CurrentThread.ManagedThreadId}]");

                    }

                }
            );
        }

        public Task CopyFromStream(Stream stream, string fileName)
        {

            return Task.Run(() =>
            {
                lock (locker)
                {
                    Console.WriteLine($"Copying from stream... [{Thread.CurrentThread.ManagedThreadId}]");
                    stream.Seek(0, SeekOrigin.Begin);
                    if (File.Exists(fileName)) File.Delete(fileName);
                    using var fileStream = File.Open(fileName, FileMode.Create);
                    stream.CopyTo(fileStream);
                    Console.WriteLine($"Copying from stream end [{Thread.CurrentThread.ManagedThreadId}]");
                }

            });
        }

        public async Task<int> GetStatisticsAsync(string filename, Func<LearningCourse, bool> filter) =>
            await Task.Run(() => GetStatistics(filename, filter));

        public async Task<int> GetStatistics(string fileName, Func<LearningCourse, bool> filter)
        {
            int count = 0;
            Console.WriteLine($"Calculating stats... [{Thread.CurrentThread.ManagedThreadId}]");
            var streamReader = new StreamReader(File.Open(fileName, FileMode.Open));
            var lstCourses = new List<LearningCourse>();
            for (var i = 0; i < 100; i++)
            {

                lstCourses.Add(new LearningCourse(Convert.ToByte(await streamReader.ReadLineAsync()),
                    await streamReader.ReadLineAsync(), Convert.ToInt32(await streamReader.ReadLineAsync())));
                if (filter(lstCourses[i])) count++;
                Console.WriteLine(lstCourses[i].Subject);

            }

            streamReader.Dispose();
            Console.WriteLine($"Calculating stats end [{Thread.CurrentThread.ManagedThreadId}]");
            return count;

        }
    }
}