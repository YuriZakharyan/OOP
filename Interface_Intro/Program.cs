using System;

namespace Interfaces_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Burger bur = new Burger();
            bur.Price();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
