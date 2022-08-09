using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GenericIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            ArrayList arrayList = new ArrayList();
            arrayList.Add(5);
            arrayList.Add("Hello");
            int value = (int)arrayList[1];      //run time error    (string to int)
            */
            Console.Write("Input a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( genericClass.Compare<int>(a, b));
            
            Console.WriteLine(genericClass.Sum<int, IntagersCalc>(a,b));
            Console.WriteLine(genericClass.Sub<int, IntagersCalc>(a, b));
            Console.WriteLine(genericClass.Mul<int, IntagersCalc>(a, b));
            Console.WriteLine(genericClass.Div<int, IntagersCalc>(a, b));


            Console.WriteLine(genericClass.Suum<double>(a, b));
            Console.Write("Type: ");
            Console.WriteLine(genericClass.Suum<double>(a, b).GetType());

        }
    }
}
