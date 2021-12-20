using System;
using System.Threading;
using System.IO;
using System.Threading.Tasks;
using ClassLibrary1;
using ClassLibrary2;

namespace Lab11
   
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //Task1
            Calculations calc = new Calculations();
            calc.ShowResult += calc.ResultInf;
            Thread first = new Thread(new ThreadStart(calc.Integral))
            {
                Priority = ThreadPriority.Highest
            };
            Thread second = new Thread(new ThreadStart(calc.Integral))
            {
                Priority = ThreadPriority.Lowest
            };
            first.Start();
            second.Start();
            
            //Task2
            MemoryStream stream = new MemoryStream();
            StreamService service = new StreamService();
            var firstMethod=service.WriteToStream(stream);
            var secondMethod= service.CopyFromStream(stream, "ote.txt");
            //await Task.WhenAll(firstMethod, secondMethod);
            Task.WaitAll(firstMethod, secondMethod);
            Func<LearningCourse, bool> checking = LearningCourse.Checks;
            await service.GetStatisticsAsync("ote.txt",checking);
            
            
        }
    }
}