using System;
namespace Exeptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    ExeptionDemo ob = new ExeptionDemo();
            //    Console.WriteLine(ob.GrandParentGetNumber(9));
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.StackTrace);
            //}



            ///Calculator
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
                    catch (Exception ex)
                    {
                        if (b == 0)
                        {
                            Console.WriteLine("You cannot devide number to zero");
                            Console.WriteLine(ex.Message);
                        }
                    }
                    break;
            }

        }
    }
}
