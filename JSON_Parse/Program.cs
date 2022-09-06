using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace JSON_Parse
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student()
            {
                ID = 100,
                Name = "Yuri",
                Age = 21,
                Hobbies = new List<string>()
                {
                    "Reading",
                    "Programming"
                }
            };
            Student student2 = new Student()
            {
                ID = 101,
                Name = "Harut",
                Age = 23,
                Hobbies = new List<string>()
                {
                    "Reading",
                    "Programming"
                }
            };
            
            string text1 = JsonConvert.SerializeObject(student1);       //Parse json
            string text2 = JsonConvert.SerializeObject(student2);
            Console.WriteLine(text1);
            Console.WriteLine(text2);

            File.WriteAllText(@"D:\Yuri.txt", text1);       //write json in .txt file 
            File.WriteAllText(@"D:\Harut.txt", text2);
        }
    }
}
