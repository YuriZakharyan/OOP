using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyDelegate del = new MyDelegate(DelegIntroClass.Print);
            //del.Invoke("Hello World");
            //
            MyDelegate<int> del1 = new MyDelegate<int>(DelegIntroClass.Sum);
            del1 += DelegIntroClass.Sum;
            Console.WriteLine(del1(3, 6));
            del1 += DelegIntroClass.Mul;
            Console.WriteLine(del1(3, 6));
            del1 += DelegIntroClass.Sum;
            Console.WriteLine(del1(3, 6));
            del1 += DelegIntroClass.Sub;
            Console.WriteLine(del1(3, 6));


        }
    }
}
