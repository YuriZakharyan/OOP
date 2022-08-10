using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyDelegate del = new MyDelegate(DelegIntroClass.Print);
            //del.Invoke("Hello World");




            //MyDelegate<int> del1 = new MyDelegate<int>(DelegIntroClass.Sum);
            //del1 += DelegIntroClass.Sum;
            //Console.WriteLine(del1(3, 6));
            //del1 += DelegIntroClass.Mul;
            //Console.WriteLine(del1(3, 6));



            //del1.Invoke(5,4);
            //del1(3, 6);

            ///  ??????????????????????????????????????
            ///CallDeleg del2 = DelegIntroClass.Print;
            ///del2 += DelegIntroClass.Print;
            ///del2.Invoke("Hii");        


            ///MyDelegate<int> del3 = DelegIntroClass.Sub;
            ///MyDelegate<int> del4 = DelegIntroClass.Sum;
            ///MyDelegate<int> d = del3 + del4;
            ///
            ///Console.WriteLine(d.Invoke(6,8));

            /*
            ///Generic Delegate 

            Add<int> add1 = new Add<int>(DelegIntroClass.Sum);
            Add<string> add2 = new Add<string>(DelegIntroClass.Concat1);
            add2 += DelegIntroClass.Concat2;
            
            Console.WriteLine(add2.DynamicInvoke("Hello ", "World"));
            
            */

            /*
            //Func Delegate             (in, out)

            DelegIntroClass ob = new DelegIntroClass();
            Func<int, int, double> obj = new Func<int, int, double>(ob.Foo);
            obj += ob.Foo;
            Console.WriteLine(obj(2, 3));

            */

            /*
            //Action Delegate           ->doesn't return value  (void)

            DelegIntroClass ob1 = new DelegIntroClass();
            PrintDelegate<int> d1 = new PrintDelegate<int>(ob1.PrintValue);
            d1 += ob1.PrintType;
            d1.Invoke(100);
            Console.WriteLine("_________________");
            d1 -= ob1.PrintValue;
            d1(5);
            */




        }
    }
}
