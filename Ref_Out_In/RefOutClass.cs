using System;
using System.Collections.Generic;
using System.Text;

namespace Ref_Out_In
{
    static class RefOutClass
    {

        public static int Foo(int a)
        {
            a *= 5;
            return a;
        }
        public static int Foo(ref int a)
        {
            a *= 5;
            return a;
        }
        public static int Foo1(out int a)
        {
            a = 100;
            a += 10;
            return a;
        }

    }
}
