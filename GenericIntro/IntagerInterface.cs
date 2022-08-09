using System;
using System.Collections.Generic;
using System.Text;

namespace GenericIntro
{
    interface IntagerInterface<T>
    {
       public T Add(T a, T b);
       public T Sub(T a, T b);
       public T Mul(T a, T b);
       public T Div(T a, T b);
    }
}
