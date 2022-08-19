using System;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Thread_Task
{
    class Program
    {   
        /*
        static void Print1()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("\t\t"  + 1);
                Thread.Sleep(1000);
            }
        }
        */

        /*
        static void Print2()
        {
            Thread thread = Thread.CurrentThread;
            thread.Name = "Print2";
            Console.WriteLine($"Thread ID: {thread.Name} -> {thread.GetHashCode()}");
            for(int i = 0; i<10; i++)
            {
                Console.WriteLine("\t\t" + 2);
                Thread.Sleep(1000);
            }
        }
        */
        static void Calculate()
        {
            Task.Run(() =>
            {
                Calc1();
            });
            Task.Run(() =>
            {
                Calc2();
            });

            Task.Run(() =>
            {
                Calc3();
            });

        }
        static int Calc1()
        {
            Thread.Sleep(4000);
            Console.WriteLine("Calc1");
            return 100;
        }
        static int Calc2()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Calc2");
            return 200;
        }
        static int Calc3()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Calc3");
            return 300;
        }
        static void Main(string[] args)
        {
            
            Calculate();

            Console.ReadLine();
            /*
            Thread thread1 = Thread.CurrentThread;
            thread1.Name = "Firstt";
            Console.WriteLine($"Thread ID: {thread1.Name}  -> {thread1.GetHashCode()}");

            Thread thread2 = new Thread(Print2);
            thread2.Start();

            for(int i = 0; i<10; i++)
            {
                Console.WriteLine("\t\t\t\t\t" + 1);
                Thread.Sleep(1000);
            }

            */
            //Thread thread1 = new Thread(Print1);
            //Thread thread2 = new Thread(Print2);
            //thread1.Start();
            //thread2.Start();


            //ThreadStart thread = new ThreadStart(Print1);
            //
            //Thread thread1 = new Thread(thread);
            //thread1.Start();
            //int i = 0;
            //while (i<3000)
            //{
            //    Console.WriteLine("22222");
            //    i++;
            //}

        }
    }
}
