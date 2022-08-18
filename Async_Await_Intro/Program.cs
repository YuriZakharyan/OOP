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
 
        static void Main(string[] args)
        {
            Foo1();
        }
    }
}
