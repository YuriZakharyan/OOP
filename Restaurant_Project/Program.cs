using System;

namespace Restaurant_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Choose which restaurant do you want");
            
            Console.ForegroundColor = ConsoleColor.Blue;
            for(int i = 0; i < Enum.GetNames(typeof(RestaurantList)).Length; i++)
            {
                Console.WriteLine($"{Enum.GetName(typeof(RestaurantList), i + 1)}\t\t->Press {i + 1}");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("->");
            int restNum = Convert.ToInt32(Console.ReadLine());


            int nameFood;

            // Type t = Type.GetType("Restaurant_Project.Pandok");
            // object ob = Activator.CreateInstance(t);
            // 
            // ob.Show();

            switch (restNum)
            {
                case 1:
                    Karas obj1 = new Karas();
                    break;
                case 2:
                    KFC obj2 = new KFC();
                    break;
                case 3:
                    Pandok obj3 = new Pandok();
                    obj3.Show();
                    Console.Write("->");
                    nameFood = Convert.ToInt32(Console.ReadLine());
                    obj3.Deliver(nameFood);
                    
                    break;
                case 4:

                    PitStop obj4 = new PitStop();
                    break;


                case 5:
                    Sherep obj5 = new Sherep();
            
                    obj5.Show();
                    Console.Write("->");
                    nameFood = Convert.ToInt32(Console.ReadLine());
                    obj5.Deliver(nameFood);
                    break;

                default:
                    break;
            }


            








            //input                 3
            //output                You chose Pandok//// create Pandok instance

            //output                Pandoki Menu
            //                      Cooose what do you want

            //                      BBQ     -> press 1
            //                      Burger  -> press 2
            //                      Pizza   -> press 3

            //                      input count

            //                      Deliver

            //                      isDelivered

        }
    }
}
