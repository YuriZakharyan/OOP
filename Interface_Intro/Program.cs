using System;

namespace Interfaces_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hello...\nPlease say what do you want?");
            Console.WriteLine("If you want Burger Press 1");
            Console.WriteLine("If you want Shaurma Press 2");
            Console.WriteLine("If you want Qabab Press 3");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("->");
            Console.ForegroundColor = ConsoleColor.White;
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Burger bur = new Burger();
                    bur.Price();
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }

        }
    }
}
