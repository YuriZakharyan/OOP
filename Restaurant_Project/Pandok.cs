using System;
//using System.Timers;
using System.Threading;
namespace Restaurant_Project
{
    class Pandok : Restaurant,IConditions
    {
        //public object[] Foods = new object[] { new BBQ(), new Burger(), new Pizza() }; 
        private Timer timer = null;
        

        public int[] Foods = new int[] { 1, 2, 4 };
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool isDelivered { get; set; }
        public bool isAvailable { get; set; }
        public void Show()
        {
            Console.WriteLine();
            Console.WriteLine($"Choose what do you want from Pandok:");
            Console.ForegroundColor = ConsoleColor.Red;
            for(int i = 0; i<Foods.Length; i++)
            {
                Console.WriteLine($"{Enum.GetName(typeof(MenuList), Foods[i])}\t-> Press {i + 1}");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
        private static void TimerCallback(Object o)
        {
            // Display the date/time when this method got called.

            //Console.WriteLine("In TimerCallback: " + DateTime.Now);
        }
        public override void Deliver(int foodType)
        {
            //BBQ = 0,
            //Shaurma = 1,
            //Burger = 2,
            //Pizza = 3,
            //Sushi = 4
            Console.WriteLine($"Write count of {Enum.GetName(typeof(MenuList), Foods[foodType - 1])}");
            int n = 0;
            Console.Write("->");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your {n} pcs. {Enum.GetName(typeof(MenuList), Foods[foodType-1])} we will send in 20 minutes");
            //patviruma 13:10
            //patrasta  13:20
            int tempMin = DateTime.Now.Minute;
            Console.WriteLine(DateTime.Now);
            while (DateTime.Now.Minute - tempMin <= 1)
            {
                timer = new Timer(TimerCallback, null, 0, 6000);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(DateTime.Now);
            Console.WriteLine($"Your {Enum.GetName(typeof(MenuList), Foods[foodType-1])} is Ready");
            Console.ReadLine();

            ///int tempMin = DateTime.Now.Minute;
            ///Console.WriteLine(DateTime.Now);
            ///while(DateTime.Now.Minute - tempMin <= 20)
            ///{
            ///    continue;
            ///}
            ///Console.ForegroundColor = ConsoleColor.Green;
            ///Console.WriteLine($"\n{DateTime.Now}");
            ///isAvailable = true;
            ///Console.WriteLine($"Your {Enum.GetName(typeof(MenuList), Foods[foodType] - 1)} is Ready");
            ///Console.ForegroundColor = ConsoleColor.White;
        }

        public override void ReturnFood()
        {
            
        }
    }
}
