using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant_Project
{
    abstract class Restaurant
    {
       
        public object CreateObject(string restName) 
        {
            Type t = Type.GetType(restName); 
            return Activator.CreateInstance(t);
        }
        public abstract void Deliver(int foodType);
        public abstract void ReturnFood();
        public void EatHere() 
        { 
        }


        
    }
}
