using System;

namespace PersonProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Person ob = new Person();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Input Your First Name: ");
            Console.ForegroundColor = ConsoleColor.White;
            ob.FirstName = Console.ReadLine();
            Console.WriteLine(ob.FirstName);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Input Your Last Name: ");
            Console.ForegroundColor = ConsoleColor.White;
            ob.LastName = Console.ReadLine();
            Console.WriteLine(ob.LastName);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Input Your Phone Number: ");
            Console.ForegroundColor = ConsoleColor.White;
            ob.PhoneNumber = Console.ReadLine();
            Console.WriteLine(ob.PhoneNumber);

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




            ///obj.SalaryOfMonth(num);
            ///
            ///
            ///Console.WriteLine(obj.jobName);
            ///Console.WriteLine(obj.PureSalaryOfMonth(num));


            ///Console.WriteLine(obj.SalaryOfMonth(JobsEnum.programmer));
            ///
            ///
            ///Console.WriteLine(obj.PureSalaryOfMonth(JobsEnum.lecturer));

        }
    }
}
