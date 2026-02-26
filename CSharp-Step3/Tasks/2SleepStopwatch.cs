using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSleep
{
    class Works
    {
        public static void word()
        {
            Stopwatch sw = Stopwatch.StartNew();
            Thread.Sleep(2000);
            sw.Stop();
            Console.WriteLine("Word in " + sw.Elapsed.TotalSeconds);

        }
        public static void ppt()
        {
            Stopwatch sw = Stopwatch.StartNew();
            Thread.Sleep(4000);
            sw.Stop();
            Console.WriteLine("PPT in " + sw.Elapsed.TotalSeconds);
        }
    }
    class Doing
    {
        public static void RnAll()
        {
            Task t1 = Task.Run(() => { Works.ppt(); });
            Task t2 = Task.Run(() => { Works.word(); });
            
            Console.WriteLine("Completed tasks");
        }
    }
    class ThreadSleepWaitAll
    {
        public static void Main()
        {
            Stopwatch sw = Stopwatch.StartNew();
            Doing.RnAll();
            sw.Stop();
            Console.WriteLine(sw.Elapsed.TotalSeconds);
            Console.ReadLine();
        }
    }
}