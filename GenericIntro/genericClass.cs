using System;
using System.Collections.Generic;
using System.Text;

namespace GenericIntro
{
    class genericClass
    {
        public static T Sum<T, C>(T a, T b) where C : IntagerInterface<T>, new()
        {
            C calc1 = new C();
            return calc1.Add(a, b);
        }
        public static T Mul<T, C>(T a, T b) where C : IntagerInterface<T>, new()
        {
            C calc2 = new C();

            return calc2.Mul(a, b);
        }
        public static T Sub<T, C>(T a, T b) where C : IntagerInterface<T>, new()
        {
            C calc3 = new C();
            return calc3.Sub(a, b);
        }
        public static T Div<T, C>(T a, T b) where C : IntagerInterface<T>, new()
        {
            C calc4 = new C();
            return calc4.Div(a, b);
        }

        public static T Suum<T>(T a, T b)
        {
            dynamic a1 = a;
            dynamic b1 = b;
            return a1 + b1;
        }


        public static string Compare<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) > 0 ? $"{a}>{b}" : $"{a}<={b}";
        }
    }
}
