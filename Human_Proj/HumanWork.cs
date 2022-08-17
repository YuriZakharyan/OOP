using System;
using System.Collections.Generic;
using System.Text;

namespace Human_Proj
{
    public delegate int DelegateWork(out int a);
    class HumanWork
    {
        public int k = 0;
        public int BreakTime(out int a) //1
        {
            a = 10;
            Console.WriteLine($"-> {a-1}");
            k = a;
            return a;

        }
        public int SmockingTime(out int a)  //2
        {
;           a = BreakTime(out k);
            Console.WriteLine($"->  {a-=2}");
            return a;
        }
        public int CoffeTime(out int a)
        {
            a = SmockingTime(out k);
            Console.WriteLine($"->  {a-=3}");
            return a;
        }

    }
}
