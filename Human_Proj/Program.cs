using System;

namespace Human_Proj
{
    class Program
    {
        static void Main(string[] args)
        {
            //Human obj = new Human();
            //
            //Action action = new Action(obj.Eat);
            //action += obj.WakeUp;
            //action += obj.Tooth;
            //action += obj.Smocking;
            //action.Invoke();
            //
            int a = 0;
            HumanWork ob = new HumanWork();
            DelegateWork delegateWork = new DelegateWork(out ob.BreakTime); //1
            delegateWork += new DelegateWork(out ob.CoffeTime);       //3
            delegateWork += new DelegateWork(out ob.SmockingTime);    //2
            delegateWork.Invoke(out a);
            Console.WriteLine(a);
            
        }
    }
}
