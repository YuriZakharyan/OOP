using System;
using System.Diagnostics;
namespace Ref_Out_In
{
    class Program
    {
        struct Point
        {
            public float a;
            public float b;
            public float c;
        }
        static void Foo1(Point value)
        {
        }
        static void Foo2(in Point value)
        {
        }


        
        static void Main(string[] args)
        {
            int a = 1;
            Console.WriteLine(RefOutClass.Foo(ref a));

            Console.WriteLine(RefOutClass.Foo(ref a));
            Console.WriteLine(RefOutClass.Foo1(out a));
            Console.WriteLine(RefOutClass.Foo1(out a));

            ///Point ob = new Point();
            ///Stopwatch sw = Stopwatch.StartNew();
            ///for(int i = 0; i<int.MaxValue; i++)
            ///{
            ///    Foo1(ob);
            ///}
            ///sw.Stop();
            ///Console.WriteLine($"Foo1:   {sw.ElapsedMilliseconds}");
            ///
            ///sw.Restart();
            ///for(int i = 0; i<int.MaxValue; i++)
            ///{
            ///    Foo2(ob);
            ///}
            ///
            ///sw.Stop();
            ///Console.WriteLine($"Foo2:   {sw.ElapsedMilliseconds}");
        }
    }
}
