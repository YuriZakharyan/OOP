using System;
using System.Collections.Generic;
using System.Text;

namespace aaaa
{
    #region abstract class can have a abstract derived class
    abstract class A
    {
        public abstract void Fo();
    }
    abstract class B : A
    {
        public override void Fo()
        {
            Console.WriteLine("B");
        }
    }
#endregion

    //abstract
    class Animal  // Base class (parent) 
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }
    /*abstract class B : Animal
    {
        public void Foo()
        {
            Console.WriteLine("Hii");
        }
    }*/

    class Pig : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }
}
