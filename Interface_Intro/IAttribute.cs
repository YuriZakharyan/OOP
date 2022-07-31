using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Intro
{
    interface IAttribute
    {
        public int price { get; set; }
        public int size { get; set; }
        public bool isDiet { get; set; }

        public void Price();
        public int Drink()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("If you want any drink Press 1");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("->");
            Console.ForegroundColor = ConsoleColor.White;
            int d = Convert.ToInt32(Console.ReadLine());
            if (d == 1)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\tChoose drinks");

                Console.WriteLine("1. Coca Cola \t(press 1)");
                Console.WriteLine("1. Fanta \t(press 2)");
                Console.WriteLine("1. Sprite \t(press 3)");
                Console.WriteLine("1. Pepsi \t(press 4)");
                Console.WriteLine("1. Pulpy \t(press 5)");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write
                    ("->");
                Console.ForegroundColor = ConsoleColor.White;
                int juiceNumber = Convert.ToInt32(Console.ReadLine());
                switch (juiceNumber)
                {
                    case 1:
                        price += 800;
                        Console.WriteLine("You chose Coca Cola");
                        Console.ForegroundColor = ConsoleColor.Green;
                        return price;
                    case 2:
                        price += 500;
                        Console.WriteLine("You chose Fanta");
                        Console.ForegroundColor = ConsoleColor.Green;
                        return price;

                    case 3:
                        price += 500;
                        Console.WriteLine("You chose Sprite");
                        Console.ForegroundColor = ConsoleColor.Green;
                        return price;
                    case 4:
                        price += 500;
                        Console.WriteLine("You chose Pepsy");
                        Console.ForegroundColor = ConsoleColor.Green;
                        return price;
                    case 5:
                        price += 500;
                        Console.WriteLine("You chose Pulpy");
                        Console.ForegroundColor = ConsoleColor.Green;
                        return price;
                    default:
                        Console.WriteLine("Invalid Input");
                        Console.ForegroundColor = ConsoleColor.Green;
                        return 0;
                }
            }
            else
            {
                return 0;
            }
        }
        public void DeliverOrNow()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\tIf you want to eat now press 1");
            Console.WriteLine($"\tIf you want to bring with you press 2");
            Console.WriteLine($"\tIf you want to deliver to the address you wanted press 3");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("->");
            Console.ForegroundColor = ConsoleColor.White;
            int number = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            if (number == 1)
            {
                Console.WriteLine("Your product will be ready in 5 minutes...\nBon Appetit");
            }
            else if (number == 2)
            {
                Console.WriteLine("You can bring your product in 10 minutes...\nBon Appetit");
            }
            else if (number == 3)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Write your address: ");
                Console.ForegroundColor = ConsoleColor.White;
                string address = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"We will send your product in 30 minutes to {address}...\nBon Appetit");
            }
        }

    }
}
