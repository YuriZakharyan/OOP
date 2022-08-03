using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant_Project
{
    abstract class Restaurant
    {

        public abstract void Deliver(int foodType);
        public abstract void ReturnFood();
        public void EatHere() 
        { 
        }


        
    }
}
