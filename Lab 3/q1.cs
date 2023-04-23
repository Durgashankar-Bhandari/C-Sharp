//Write a C# program using async and wait  for long process.
using System;
using System.Threading.Tasks;

namespace AsyncAwaitExample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Starting long process...");
            await LongProcessAsync(); 
            Console.WriteLine("Long process completed.");
            Console.ReadLine();
        }

        static async Task LongProcessAsync()
        {
            Console.WriteLine("Long process started.");
            await Task.Delay(5000);
            Console.WriteLine("Long process completed.");
        }
    }
}
