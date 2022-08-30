using System;

namespace Anonymous_Methods
{
    class Program
    {
        public delegate void Print(int value);
        public delegate int Calc(int value);

        static void Main(string[] args)
        {

            Print print = delegate (int value)
            {
                Console.WriteLine($"Value: {value}");
            };
            print(100);



            Calc fact = delegate (int value)
            {
                int fact = 1;
                while (value != 0)
                {
                    fact *= value;
                    value--;
                }
                return fact;
            };
            Console.WriteLine(fact(3));




        }
    }
}
