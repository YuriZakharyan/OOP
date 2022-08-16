using System;

namespace Lesson_9
{
    class Program
    {
        /*
        public static decimal a = 1000;
        public static int b;
        static decimal Calc1(ref decimal Sum)
        {
            Sum -= a;
            return a;
        }
        static decimal Calc2(out decimal Sum, int b)
        {
            Sum = b;
            return Sum;
        }
        */

        static void Main(string[] args)
        {
            decimal k = 50000;
            //Console.WriteLine(Calc1(ref k));
            //Console.WriteLine(k);

            Console.WriteLine(Calc2(out k, 3));
            Console.WriteLine("k = " + k);
        }
    }
}
