using System;
using System.Threading.Tasks;

namespace TasksReal
{
    class TasksReal
    {
        static void CookDish(string dish)
        {
            Console.WriteLine($"{dish} started");
            Task.Delay(2000).Wait(); // Simulate cooking 2 sec
            Console.WriteLine($"{dish} done");
        }

        static void Main()
        {
            Task t1 = Task.Run(() => CookDish("Pasta"));
            Task t2 = Task.Run(() => CookDish("Salad"));

            t1.Wait(); // Wait for Pasta
            t2.Wait(); // Wait for Salad

            Console.WriteLine("All dishes ready!");
        }
    }
}