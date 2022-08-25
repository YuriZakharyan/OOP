using System;
using System.Collections.Generic;
using System.Text;

namespace aaaa
{
    abstract class AA
    {
        public abstract void Print();
        
    }
    class BB: AA
    {
        public override void Print()
        {
            Console.WriteLine("Hiii");
        }
    }
}
