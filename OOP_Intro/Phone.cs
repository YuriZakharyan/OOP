using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Intro
{
    class Phone
    {
        public int width;
        public int height;

        public bool hasSensor;

        public string modelName;
        public Person owner;
        public Phone()
        {
        }

        public Phone(int width, int height)
        {
            this.width = width;
            this.height = height;

        }
        public Phone(int width, int height, string modelName) : this(width, height)
        {
            this.modelName = modelName;
            this.width = width;
            this.height = height;
        }
        public void Introduce()
        {
            Console.WriteLine($"Phone Name: {modelName} \nWidth: {width} \nHeight: {height}");
        }

        public void Call(Person person)
        {
            Console.WriteLine($"Calling {person.firstName} {person.lastName}");
        }
    }
}