using System;

namespace SyncCalls
{
    class Works
    {
        public static void word()
        {
            Console.WriteLine("Word");

        }
        public static void ppt()
        {
            Console.WriteLine("PPT");
        }
        public static void excel()
        {
            Console.WriteLine("EXcel");
        }
    }
    class Task
    {
        public static void Tasks()
        {
            Console.WriteLine("Started");
            Works.word();
            Works.ppt();
            Works.excel();
            Console.WriteLine("Completed");
        }
    }
    class SyncMain
    {
        static void Main()
        {
            Task.Tasks();
        }
    }
}
