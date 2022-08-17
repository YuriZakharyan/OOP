using System;
using System.Collections.Generic;
using System.Text;

namespace Human_Proj
{
    public delegate void Action();
    class Human
    {
        public void WakeUp()
        {
            Console.WriteLine("Wake Up");
        }
        public void Tooth()
        {
            Console.WriteLine("Washing Tooths");
        }
        public void Smocking()
        {
            Console.WriteLine("Smocking");
        }
        public void Eat()
        {
            Console.WriteLine("Eating");
        }


    }
}
