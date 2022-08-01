using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Intro
{
    class Burger : IAttribute
    {
        public int price { get; set; }

        public bool isDiet { get; set; }


        public int[] foodCounts { get; set; }
        public int size { get; set; }

        public string[] ChickenBurger = new string[] { "Chicken Meat", "Cheese", "Potato", "Cucumber", "Onion", "Tomato", "Pepper" };
        public string[] BeafBurger = new string[] { "Beaf Meat", "Cheese", "Potato", "Cucumber", "Onion", "Tomato", "Pepper" };
        public string[] tempBurger = new string[6];
        public int[] tempBurgerCount = new int[6];
        public string tempSize;
        public Burger(bool a)
        {

        }
        public Burger()
        {

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\tChoose Burger Size\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Big\t---->\tPress 1");
            Console.WriteLine("Medium\t---->\tPress 2");
            Console.WriteLine("Small\t---->\tPress 3");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("->");
            Console.ForegroundColor = ConsoleColor.White;


            size = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            
            switch (size)
            {
                case 1:
                    tempSize = "Big";
                    break;
                case 2:
                    tempSize = "Medium";
                    break;
                case 3:
                    tempSize = "Small";
                    break;
                default:
                    throw new Exception("\n\tInvalid Input\n");
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\tIf you want Beaf Burger Press 1");
            Console.WriteLine("\tIf you want Chicken burger Press 2");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("->");
            Console.ForegroundColor = ConsoleColor.White;
            int temp = Convert.ToInt32(Console.ReadLine());

            if (temp == 1)
            {
                for (int i = 1; i < BeafBurger.Length; i++)
                {
                    tempBurger[i - 1] = BeafBurger[i];
                }
            }
            if (temp == 2)
            {
                for (int i = 1; i < ChickenBurger.Length; i++)
                {
                    tempBurger[i - 1] = ChickenBurger[i];
                }
            }
            else
            {
                throw new Exception("\n\tInvalid Input\n");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            if (temp == 1)
            {
                Console.WriteLine("\tWhat do you want to add your beefBurger. Input Counts");
                Console.ForegroundColor = ConsoleColor.Gray;
                for (int i = 1; i < BeafBurger.Length; i++)
                {
                    Console.Write($"{BeafBurger[i]}:   ");
                    Console.ForegroundColor = ConsoleColor.White;
                    tempBurgerCount[i - 1] = Convert.ToInt32(Console.ReadLine());
                }
            }
            if (temp == 2)
            {
                Console.WriteLine("\tWhat do you want to add your Chicken Burger. Input Counts");
                Console.ForegroundColor = ConsoleColor.Gray;
                for (int i = 1; i < ChickenBurger.Length; i++)
                {
                    Console.Write($"{ChickenBurger[i]}:   ");
                    Console.ForegroundColor = ConsoleColor.White;
                    tempBurgerCount[i - 1] = Convert.ToInt32(Console.ReadLine());
                }
            }
            else
            {
                throw new Exception("\n\tInvalid Input\n");
            }
            //for (int i = 0; i < tempBurgerCount.Length; i++)
            //{
            //    Console.WriteLine(tempBurgerCount[i]);
            //}

        }

        public void Price()
        {
            

            IAttribute obj = new Burger(true);

            int price = 0;


            if (size == 1) price = 1000;
            if (size == 2) price = 750;
            if (size == 3) price = 500;

            for (int i = 0; i < tempBurger.Length; i++)
            {
                if (tempBurger[i] == "Cheese")
                {
                    price += tempBurgerCount[i] * 300;
                }
                if (tempBurger[i] == "Potato")
                {
                    price += tempBurgerCount[i] * 200;
                }
                if (tempBurger[i] == "Cucumber")
                {
                    price += tempBurgerCount[i] * 100;
                }
                if (tempBurger[i] == "Tomato")
                {
                    price += tempBurgerCount[i] * 100;
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            obj.DeliverOrNow();
            

            Console.WriteLine($"Price: {price + obj.Drink()}");
            
        }
    }
}
