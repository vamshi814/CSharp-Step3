using System;
using System.Threading;

namespace MultithreadingReal
{
    class MultithreadingReal
    {
        static void MakeSalad() => Console.WriteLine("Salad ready!");
        static void BoilPasta() => Console.WriteLine("Pasta ready!");

        static void Main()
        {
            Thread t1 = new Thread(MakeSalad);
            Thread t2 = new Thread(BoilPasta);

            t1.Start();
            t2.Start();

            t1.Join(); // Wait for t1 to finish
            t2.Join(); // Wait for t2 to finish

            Console.WriteLine("Meal is ready!");
        }
    }
}