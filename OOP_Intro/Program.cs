using System;

namespace OOP_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone(2, 4, "Sony");
            phone.Introduce();
            Console.WriteLine();

            Person person = new Person();

            Console.WriteLine("aaaaaaaa");
            Phone phone1 = new Phone()

            {
                hasSensor = true,
                modelName = "Samsung",
                width = 5,
                height = 100
            };
            phone1.Introduce();
        }
    }
}