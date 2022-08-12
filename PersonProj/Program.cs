using System;
using System.IO;
using System.Windows;

namespace PersonProj
{
    class Program
    {
        static void Main(string[] args)
        {


            Person ob = new Person();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Input Your First Name ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("[Tom]: ");

            Console.ForegroundColor = ConsoleColor.White;
            ob.FirstName = Console.ReadLine();
            Console.WriteLine(ob.FirstName);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Input Your Last Name ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("[Smith]: ");

            Console.ForegroundColor = ConsoleColor.White;
            ob.LastName = Console.ReadLine();
            Console.WriteLine(ob.LastName);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Input Your age ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("[From 18, to 100]: ");
            
            Console.ForegroundColor = ConsoleColor.White;
            ob.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ob.Age);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Input Your Phone Number: ");
            Console.ForegroundColor = ConsoleColor.White;
            ob.PhoneNumber = Console.ReadLine();
            Console.WriteLine(ob.PhoneNumber);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Who you are?");
            Console.ForegroundColor = ConsoleColor.White;
            ob.DisplayInfo();
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("->");
            Console.ForegroundColor = ConsoleColor.White;
            try
            {
                int k = Convert.ToInt32(Console.ReadLine());
                if (k == 2)
                {


                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Write the profession in which you work");
                    Console.ForegroundColor = ConsoleColor.White;
                    Worker obj = new Worker();
                    obj.DisplayJobs();

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("->");
                    Console.ForegroundColor = ConsoleColor.White;


                    int num = Convert.ToInt32(Console.ReadLine());


                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Write your Monthly Salary: ");
                    obj.Salary = Convert.ToDecimal(Console.ReadLine());

                    //Console.WriteLine(obj.Salary);
                    Console.ForegroundColor = ConsoleColor.Green;

                    obj.PrintProfession(num);

                    SalaryKinds salaryKinds = new SalaryKinds(obj.SalaryOfMonth);
                    salaryKinds += obj.PureSalaryOfMonth;
                    salaryKinds.Invoke();

                    //obj.SalaryOfMonth();
                    //obj.PureSalaryOfMonth();
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (k == 1)
                {

                    Console.WriteLine("You are Studing");


                }
                else if (k == 3)
                {
                    Console.WriteLine("You are getting a pension");

                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
            }
            //__________________________________________

            //FileStream filestream = new FileStream("out.txt", FileMode.Create);
            //var streamwriter = new StreamWriter(filestream);
            //streamwriter.AutoFlush = true;
            //Console.SetOut(streamwriter);
            //Console.SetError(streamwriter);

        }
    }
}
