using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public delegate T MyDelegate<T>(T a, T b);
    class DelegIntroClass
    {

        //target method
        public static T Sum<T>(T a, T b)
        {
            dynamic a1 = a;
            dynamic b1 = b;
            return a1 + b1;
        }
        public static int Mul(int a, int b)
        {
            return a * b;
        }
        public static int Sub(int a, int b)
        {
            return a - b;
        }


    }
}
