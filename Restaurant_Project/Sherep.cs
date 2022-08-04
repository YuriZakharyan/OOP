using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant_Project
{
    class Sherep : Restaurant,IConditions
    {
        public int[] Foods = new int[] { 1, 5};
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool isDelivered { get; set; }
        public bool isAvailable { get; set; }

        //public void Show()
        //{
        //    for (int i = 0; i < Foods.Length; i++)
        //    {
        //        Console.WriteLine($"{Enum.GetName(typeof(MenuList), Foods[i])}\t-> Press {i}");
        //    }
        //}

        public void Show()
        {
            Console.WriteLine();
            Console.WriteLine($"Choose what do you want from Sherep:");
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < Foods.Length; i++)
            {
                Console.WriteLine($"{Enum.GetName(typeof(MenuList), Foods[i])}\t-> Press {i + 1}");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        public override void Deliver(int foodType)
        {
            Console.WriteLine($"Write count of {Enum.GetName(typeof(MenuList), Foods[foodType - 1])}");
            int n = 0;
            Console.Write("->");
            n = Convert.ToInt32(Console.ReadLine());

            if (Enum.GetName(typeof(MenuList), Foods[foodType - 1]).ToLower() == "sushi")
            {
                Console.WriteLine($"Your {n} pcs. {Enum.GetName(typeof(MenuList), Foods[foodType - 1])} we will send in 40 minutes");
            }
            else
            {
                Console.WriteLine($"Your {n} pcs. {Enum.GetName(typeof(MenuList), Foods[foodType - 1])} we will send in 30 minutes");
            }
        }
        //public override void Deliver(int foodType)
        //{
        //}


        public override void ReturnFood()
        {
        }
    }
}
