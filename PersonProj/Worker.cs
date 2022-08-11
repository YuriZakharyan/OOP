using System;
using System.Collections.Generic;
using System.Text;

namespace PersonProj
{
    public delegate void SalaryKinds();

    class Worker : Person, IWorker
    {

        public Enum jobName;

        public decimal salary;
        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }
        public void DisplayJobs()
        {
            foreach (var item in Enum.GetValues(typeof(JobsEnum)))
            {
                Console.WriteLine($"{item}    \t{(int)item}");
            }
        }
        
        public void PrintProfession(int num)
        {
            jobName = (JobsEnum)num;
            Console.WriteLine($"You are {jobName}");
        }

        public void SalaryOfMonth()
        {
            //jobName = (JobsEnum)num;
            //Console.WriteLine($"You are {jobName}");
            Console.WriteLine($"Your Monthly medium salary is: {Salary}");
            ///jobName = (JobsEnum)num;
            ///salary = Convert.ToDecimal(Console.ReadLine());
            ///return Salary;
            ///switch (num)
            ///{
            ///    case (int)JobsEnum.Programmer:
            ///        //Console.Write("Write your Monthly Salary: ");
            ///        //salary = Convert.ToDecimal(Console.ReadLine());
            ///        return salary;
            ///    case (int)JobsEnum.Lawyer:
            ///        Console.Write("Monthly salary of a lawyer: ");
            ///        return 800000;
            ///    case (int)JobsEnum.Dentist:
            ///        Console.Write("Monthly salary of a dentist: ");
            ///        return 700000;
            ///    case (int)JobsEnum.Economist:
            ///        Console.Write("Monthly salary of a economist: ");
            ///        return 600000;
            ///    case (int)JobsEnum.Teacher:
            ///        Console.Write("Mothly salary of a teacher: ");
            ///        return 150000;
            ///    case (int)JobsEnum.Surgeon:
            ///        Console.Write("Mothly salary of a Surgeron: ");
            ///        return 900000;
            ///    case (int)JobsEnum.Lecturer:
            ///        Console.Write("Mothly salary of a lecturer: ");
            ///        return 650000;
            ///}
            ///return 0;
        }

        public void PureSalaryOfMonth()
        {
            //Console.Write("Pure Salary of Month: ");
            decimal price = Salary * 80 / 100;
            Console.WriteLine($"Your Monthly pure salary is: {price}");
        }

        public decimal SalaryOfYear()
        {
            return 0;
        }

    }
}
