using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateEvent
{
    public delegate decimal Salary(decimal n); 
    class Login
    {
        public static decimal[] arr = new decimal[4];
        public static List<decimal> aaa = new List<decimal>();
        //public static decimal Add()
        //{
        //}
        //
        public Salary salary { get; set; }
        public static decimal F1( decimal n)
        {
            aaa.Add((n * 3) / 100);
            Console.WriteLine(((n * 3) / 100));
            return 0;
        }
        public static decimal F2( decimal n)
        {
            aaa.Add((n * 4) / 100);
            Console.WriteLine(((n * 4) / 100));
            return 0;
        }
        public static decimal F3( decimal n)
        {
            aaa.Add(n - 1000);
            Console.WriteLine((n - 1000));
            return 0;
        }
        public static decimal F4( decimal n)
        {
            aaa.Add((n * 7) / 100);
            Console.WriteLine(((n * 7) / 100));
            Console.WriteLine("____________________");
            return 0;
        }
        public static decimal Result(decimal n)
        {
            foreach (decimal item in aaa)
            {
                Console.WriteLine(item);
            }
            return 0;
        }
    }
}
