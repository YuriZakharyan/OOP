using System;

namespace aaaa
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal myAnimal = new Animal();  // Create a Animal object
            //Animal myPig = new Pig();  // Create a Pig object
            //Animal myDog = new Dog();  // Create a Dog object
            //
            //myAnimal.animalSound();
            //myPig.animalSound();
            //myDog.animalSound();
            //



            //generic<int> ob = new generic<int>();
            //ob.Num1 = 5;
            //ob.Num2 = 8;
            //int a = ob.Num1;
            //int b = ob.Num2;
            //ob.Swap<int>(ref a, ref b);
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //generic<string> obj = new generic<string>();
            //string a1 = "a";
            //string a2 = "aa";
            //
            //obj.Swap(ref a1, ref a2);
            //Console.WriteLine(a1);
            //Console.WriteLine(a2);

            //generic<int> a = new generic<int>();
            //a.Swap<string>("aa", "a");    //error

            //DelEvent ob = new DelEvent(100);
            //ob.Notify += ob.DisplayMessage;
            //ob.Put(20);
            //Console.WriteLine($"Sum = : {ob.Sum}");
            //ob.Take(70);   // пытаемся снять со счета 70
            //Console.WriteLine($"Sum = : {ob.Sum}");
            //ob.Take(180);  // пытаемся снять со счета 180
            //Console.WriteLine($"Sum = : {ob.Sum}");

            //DelEvent delEvent = new DelEvent();
            //
            //
            //Call call = new Call(delEvent.Div);

            ///Console.WriteLine(call(5, 7));
            ///
            ///call += delEvent.Mul;
            ///Console.WriteLine(call(5, 7));
            ///
            ///call += delEvent.Sub;
            ///Console.WriteLine(call(5, 7));
            ///
            //Console.WriteLine(call(1,0));
            //delEvent.Equal(1, 0);


            ///Events_Delegates events_Delegates = new Events_Delegates();
            ///Print print1 = new Print(events_Delegates.Add);
            ///print1 += events_Delegates.Sub;
            ///print1 += events_Delegates.Mul;
            ///print1 += events_Delegates.Div;
            ///print1.Invoke(6,3);
            ///
            ///
            ///
            ///events_Delegates.printEvent += new Print(events_Delegates.Mul);



            Events_Delegates events_Delegates1 = new Events_Delegates();
            Morning morning = new Morning(events_Delegates1.Wash);
            morning += events_Delegates1.Tooth;
            morning += events_Delegates1.Break;


            Events_Delegates events_Delegates2 = new Events_Delegates();
            Evening evening = new Evening(events_Delegates2.Gym);
            evening += events_Delegates2.Fresh;
            evening += events_Delegates2.Sleep;

            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 10)
            {
                //morning
            }
            else
            {
                Evening evening1 = new Evening(evening);
                evening1.Invoke();
            }
















        }
    }
}
