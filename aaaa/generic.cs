using System;
using System.Collections.Generic;
using System.Text;

namespace aaaa
{
    class generic<T>
    {
        public T Num1 { get; set; }
        public T Num2 { get; set; }
        public void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
