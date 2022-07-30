using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Intro
{
    class Burger : IAttribute
    {
        public string size;
        public bool isDiet;
        public string foods;
        public Burger()
        {

        }
        public Burger(string size, bool isDiet, string foods)
        {

            this.size = size;
            this.isDiet = isDiet;
            this.foods = foods;
        }

        public void Composition()
        {
            if (isDiet)
            {
                Console.Write("Your Burger is Dietic, which ");
            }
            else
            {
                Console.Write("Your Burger isn't dietic, which ");
            }
            Console.WriteLine($"size is {size}.");
            Console.WriteLine($"Burger contains: {foods}");

            IAttribute obj = new Burger();                  //connect interface method, which have a body
            Console.WriteLine($"Price: {obj.Price(foods)}");
        }
    }
}