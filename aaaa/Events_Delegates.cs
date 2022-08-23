using System;
using System.Collections.Generic;
using System.Text;

namespace aaaa
{
    public delegate void Print(int a, int b);
    
    
    public delegate void Morning();
    public delegate void Evening();


    public class Events_Delegates
    {

        public event Morning morningEvent;
        public event Evening eveningEvent;
        public Events_Delegates()
        {
            this.morningEvent += new Morning(this.Foo);
            this.eveningEvent += new Evening(this.Foo);
        }

        public void Foo()
        {
            Console.WriteLine("Hello");
        }
        //morning
        public void Wash() => Console.WriteLine("Washing");
        public void Tooth() => Console.WriteLine("Clean Tooth");
        public void Break() => Console.WriteLine("Break");
        //evening
        public void Gym() => Console.WriteLine("Go to Gym");
        public void Fresh() => Console.WriteLine("Drink Fresh");
        public void Sleep() => Console.WriteLine("Sleep");

    }
}
