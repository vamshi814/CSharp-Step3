using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace _3WaitAll
{
    class Works3
    {
        public static void word()
        {
           
            Thread.Sleep(2000);
         
            Console.WriteLine("Word in ");

        }
        public static void ppt()
        {
            Thread.Sleep(4000);
            Console.WriteLine("PPT in " );
        }
    }
    class Doing3
    {
        public static void RnAll()
        {
            Task t1 = Task.Run(() => { Works3.ppt(); });
            Task t2 = Task.Run(() => { Works3.word(); });
            Task.WaitAll(t1, t2);
            Console.WriteLine("Completed tasks");
        }
        public static void Emergency()
        {
            Console.WriteLine("Emergency");
        }
    }

    class ThreadMain1
    {
        public static void Main()
        {
            
            Doing3.RnAll();
            Doing3.Emergency();
            Console.WriteLine("Ended");
            Console.ReadLine();
        }
    }
}