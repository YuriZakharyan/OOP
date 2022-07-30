using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Intro
{
    public class Person
    {
        public string firstName;

        public string lastName;
        public string phoneNumber;
        public int age;

        public Person()
        {
            Console.WriteLine("Constructor");
            Console.WriteLine();
        }
        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}