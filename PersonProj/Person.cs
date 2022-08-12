using System;
using System.Collections.Generic;
using System.Text;

namespace PersonProj
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
                if(age<16 || age > 100)
                {
                    age = -1;
                }
            }
        }
        public void DisplayInfo()
        {
            foreach(var item in Enum.GetValues(typeof(ChooseEnum)))
            {
                Console.WriteLine($"{item}   \t{(int)item}");
            }
        }
        private string phoneNumber;
        public string FirstName
        {
            get
            {
                Console.Write("First Name: ");
                return firstName;
            }
            set
            {
                try
                {
                    firstName = value;
                    if (firstName[0] <= 64 || firstName[0] >= 91)
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your name must start with a capital letter");
                    firstName = "?";
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
        public string LastName
        {
            get
            {

                Console.Write("Last Name: ");
                return lastName;
            }
            set
            {
                try
                {
                    lastName = value;
                    if (lastName[0] <= 64 || lastName[0] >= 91)
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your lastname must start with a capital letter");
                    lastName = "?";
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
        public string PhoneNumber
        {
            get
            {
                Console.Write("Phone Number: ");
                return phoneNumber;
            }
            set
            {
                try
                {
                    phoneNumber = value;
                    if (phoneNumber.Length != 12 || phoneNumber[0] != '+')
                    {
                        throw new Exception();
                    }
                    for (int i = 1; i < phoneNumber.Length; i++)
                    {
                        if (phoneNumber[i] < 48 || phoneNumber[i] > 57)
                        {
                            throw new Exception();
                        }
                    }
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your phone number must start with + and after that contain 11 digits.");
                    Console.WriteLine("For Example: +37499999999");
                    phoneNumber = "?";
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}
