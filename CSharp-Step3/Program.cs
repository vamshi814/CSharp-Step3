using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskDelay
{
    class Taskss
    {
        public static async Task Fun1()
        {
            //it is blocking the code
            //Thread.Sleep(8000);

            //waits but executes further statements in this method
            //Task.Delay(4000);

            //inthis method statements blocked
            await Task.Delay(4000);
            Console.WriteLine("Fun1 Ccompleted");
        }
    }
     class TaskDelay
    {
        static void Main(string[] args)
        {
            Taskss.Fun1();
            Console.WriteLine("Main Program");
            Console.ReadLine();
            Console.WriteLine("Main Program");

        }
    }
}
