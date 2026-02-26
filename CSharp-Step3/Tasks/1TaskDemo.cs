using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace TaskNamespace
{
    class Task1
    {
        public static void word()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Word");

        }
        public static void ppt()
        {
            Thread.Sleep(3000);
            Console.WriteLine("PPT");
        }
        public static void excel()
        {
            Thread.Sleep(2000);
            Console.WriteLine("EXcel");
        }
    }
    class TaskRunning
    {
        public static void Tasks()
        {
            Console.WriteLine("Started");
            Task.Run(() => { Task1.word(); });
            Task.Run( () => { Task1.ppt(); });
            Task.Run(() => { Task1.excel();  });
            Console.WriteLine("Completed");
        }
        public static void Emergency()
        {
            Console.WriteLine("Emergency work is doing!");
        }
    }
    class TaskMain
    {
        static void Main()
        {
            Stopwatch sw =  Stopwatch.StartNew();
            TaskRunning.Tasks();
            TaskRunning.Emergency();
            sw.Stop();
            Console.WriteLine(sw.Elapsed.TotalMilliseconds);
            Console.ReadLine();
        }
    }
}
