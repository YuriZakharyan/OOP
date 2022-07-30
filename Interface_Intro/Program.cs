using System;

namespace Interface_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Burger burger = new Burger("Big", true, "Potato, Meat, Cheese, Cucumber");
            burger.Composition();
        }
    }
}

