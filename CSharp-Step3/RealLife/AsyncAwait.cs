using System;
using System.Diagnostics;
using System.IO.Ports;
using System.Threading.Tasks;

namespace AsyncAwaitReal
{
    class AsyncAwaitReal
    {
        static async Task CookDishAsync(string dish)
        {
            Console.WriteLine($"{dish} started");
            await Task.Delay(2000); // Simulate async cooking
            Console.WriteLine($"{dish} done");
        }

        static async Task Main()
        {
            Console.WriteLine("Cooking started");
            Stopwatch s1= Stopwatch.StartNew();
            
            await CookDishAsync("Pasta"); // Waits without blocking
            s1.Stop();
            
            Console.WriteLine(s1.ElapsedMilliseconds);
            Stopwatch s2 = Stopwatch.StartNew();
            await CookDishAsync("Salad");
            s2.Stop();
            Console.WriteLine(s2.ElapsedMilliseconds);
            Console.WriteLine("All dishes ready!");
        }
    }
}