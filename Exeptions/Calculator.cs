using System;
using System.Collections.Generic;
using System.Text;

namespace Exeptions
{
    class Calculator
    {
        public void Calc()
        {
            Console.Write("Input a: ");
            bool b1 = int.TryParse(Console.ReadLine(), out int a);
            Console.Write("Input a: ");
            bool b2 = int.TryParse(Console.ReadLine(), out int b);
            Console.Write("Input operation (+, -, *, /) :  ");
            bool b3 = char.TryParse(Console.ReadLine(), out char sign);

            if (b1 == false || b2 == false || b3 == false)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            switch (sign)
            {
                case '+':
                    Console.WriteLine($"{a} + {b} = {a + b}");
                    break;
                case '-':
                    Console.WriteLine($"{a} - {b} = {a - b}");
                    break;
                case '*':
                    Console.WriteLine($"{a} * {b} = {a * b}");
                    break;
                case '/':
                    try
                    {
                        Console.WriteLine($"{a} / {b} = {a / b}");
                    }
                    catch (DivideByZeroException ex1)
                    {
                        if (b == 0)
                        {
                            Console.WriteLine("You cannot devide number to zero");
                            Console.WriteLine(ex1.Message);
                        }
                    }
                    catch (IndexOutOfRangeException ex2)
                    {
                        Console.WriteLine(ex2.Message);
                    }
                    finally
                    {
                        Console.WriteLine("Finally");
                    }
                    break;
            }
        }
    }
}
