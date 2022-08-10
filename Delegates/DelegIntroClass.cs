using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public delegate void CallDeleg(string s);

    //Generic Delegate
    public delegate T MyDelegate<T>(T a, T b);      
    public delegate T Add<T>(T a, T b);

    //Func delegate 
    public delegate TResult Func<in T1, in T2, out TResult>(T1 arg1, T2 arg2);

    //Action delegate
    public delegate void PrintDelegate<T>(T arg);
    //Predicate delegate
    public delegate bool PredicateDelagate<in T>(T obj);

    class DelegIntroClass
    {
        
        //target methods
        public static int Mul(int a, int b)
        {
            return a * b;
        }
        public static int Sub(int a, int b)
        {
            return a - b;
        }

        public static void Print(string s)
        {
            Console.WriteLine(s);
        }

        public static T Sum<T>(T a, T b)
        {
            dynamic a1 = a;
            dynamic b1 = b;
            return a1 + b1;
        }
        public static T Mul<T>(T a, T b)
        {
            dynamic a1 = a;
            dynamic b1 = b;
            return a1 * b1;
        }
        public static string Concat1(string s1, string s2)
        {
            Console.WriteLine("Concat 1");
            return s1 + s2;
        }
        public static string Concat2(string s1, string s2)
        {
            Console.WriteLine("Concat 2");
            return s1 + s2;
        }
        public static int Sum(int s1, int s2)
        {
            return s1 + s2;
        }

        public double Foo(int x1, int x2)
        {
            Console.WriteLine("Hello Malmo");
            return x1 + x2;
        }

        public void PrintValue<T>(T arg)
        {
            Console.WriteLine($"Value of {arg}: " + arg);

        }

        public void PrintType<T>(T arg)
        {
            Console.WriteLine($"Type of {arg}:  " + arg.GetType().Name);
        }

        public bool IsUpperCase(string arg)
        {
            Console.WriteLine($"Value: {arg}");

            return arg.ToUpper() == arg;
        }

        public bool isIntager<T>(T value)
        {
            Console.WriteLine($"Value: {value}");
            return (value.GetType().ToString() == "System.Int32");
        }
    }
}
