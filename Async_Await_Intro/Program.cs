using System;
using System.IO;
using System.Threading.Tasks;


namespace Async_Await_Intro
{
    class Program
    {
        static async Task Foo1()
        {

            Console.WriteLine("1. Foo1 ...");

            string s = await File.ReadAllTextAsync("Photos.txt");

            Console.WriteLine($"Foo1: \n\n {s}");
        }

        static async Task Foo()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(i);
                }
            });
        }
 
        static void Main(string[] args)
        {
            Foo1();
        }
    }
}
