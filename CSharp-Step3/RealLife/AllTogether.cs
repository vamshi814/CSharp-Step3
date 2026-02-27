using System;
using System.Threading.Tasks;

namespace AlltogetherReal
{
    class AllTogetherReal
    {
        static async Task CookDishAsync(string dish, int time)
        {
            Console.WriteLine($"{dish} started");
            await Task.Delay(time); // cooking time
            Console.WriteLine($"{dish} done");
        }

        static async Task Main()
        {
            Console.WriteLine("Kitchen open!");

            Task pasta = CookDishAsync("Pasta", 2000);
            Task salad = CookDishAsync("Salad", 1000);
            Task soup = CookDishAsync("Soup", 3000);

            // Wait all dishes asynchronously
            await Task.WhenAll(pasta, salad, soup);

            Console.WriteLine("All dishes ready to serve!");
        }
    }
}
