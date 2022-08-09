using System;
using System.Collections.Generic;
using System.Text;

namespace GenericIntro
{
    class IntagersCalc : IntagerInterface<int>
    {
        public int Add(int a, int b)
        {
            Console.Write($"{a} + {b} = ");
            return a + b;
        }

        public int Div(int a, int b)
        {
            try
            {
                Console.Write($"{a} / {b} = ");
                return a / b;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"You cannot divide {a} to zero");
                Console.WriteLine(ex.Message);
            }
            return -1;
        }

        public int Mul(int a, int b)
        {
            Console.Write($"{a} * {b} = ");
            return a * b;
        }

        public int Sub(int a, int b)
        {
            Console.Write($"{a} - {b} = ");
            return a - b;
        }
        
    }
}
