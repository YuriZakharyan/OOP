using System;

namespace DelegateEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            


            Login ob = new Login();
            Salary obj = new Salary(Login.F1);

            obj += Login.F2;
            obj += Login.F3;
            obj += Login.F4;
            obj += Login.Result;
            Console.WriteLine(obj.Invoke(10000000));
            //Console.WriteLine(obj?.Invoke(100 ));
            //obj.DynamicInvoke


        }
    }
}
