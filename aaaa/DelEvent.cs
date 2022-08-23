using System;
using System.Collections.Generic;
using System.Text;

namespace aaaa
{
    public delegate double Call(double a, double b);
    class DelEvent
    {
        public event Call? CallEvent;

        public double Add(double a, double b)
        {
            //Console.Write($"{a} + {b} = ");
            return a + b;
        }
        public double Mul(double a, double b)
        {
            //Console.Write($"{a} * {b} = ");
            return a * b;
        }
        public double Sub(double a, double b)
        {
            //Console.Write($"{a} - {b} = ");
            return a - b;
        }
        public double Div(double a, double b)
        {
            //Console.Write($"{a} / {b} = ");
            return a / b;
        }
        public void Equal(double a, double b)
        {
            if(b == 0)
            {
                Console.WriteLine("????????");
                CallEvent?.Invoke(1,-1);
            }
            else
            {
                CallEvent.Invoke(a, b);
            }
        }
    }
}
