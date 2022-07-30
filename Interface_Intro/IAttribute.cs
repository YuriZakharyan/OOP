using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Intro
{
    public interface IAttribute
    {
        public static int price { get; set; }
        public static string size { get; set; }
        public static bool isDiet { get; set; }
        public static string foods { get; set; }

        public static DateTime dt = new DateTime();

        public void Composition();

        public decimal Price(string foods)
        {
            decimal price = 1000;
            if (foods.ToLower().Contains("cheese"))
            {
                Console.WriteLine("Cheese: +500");
                price += 500;
            }
            if (foods.ToLower().Contains("meat"))
            {
                Console.WriteLine("Meat: +1000");
                price += 1000;
            }
            return price;

        }
    }
}
