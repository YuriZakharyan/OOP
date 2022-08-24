using System;
using System.Collections;
using System.Collections.Generic;
namespace DataStructuresIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Stack S = new Stack(5);

            S.Push(10);
            S.Push(20);
            S.Push(30);
            S.Push(40);
            S.Push(50);

            Console.WriteLine("Stack elements: ");
            S.PrintStack();
            
            S.Pop();
            S.Pop();
            S.Pop();
            S.Pop();
            S.Pop();
            */

            /*
                SortedList<int, string> names = new SortedList<int, string>();
                names.Add(1, "Harut");
                names.Add(3, "Hovo");
                names.Add(4, "Erik");
                names.Add(2, "Vahag");
                foreach(var item in names)
                {
                    Console.WriteLine(item);
                }
            */

            /*
            SortedList<string, string> names = new SortedList<string, string>();        //Ascii
            names.Add("H", "Harut");
            names.Add("B", "Babken");
            names.Add("V", "Vahag");
            foreach(var item in names)
            {
                Console.WriteLine(item);
            }
            */


            /*
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(2, "Harut");
            dict.Add(4, "Hovo");
            dict.Add(3, "Vahagn");
            foreach(var item in dict)
            {
                Console.WriteLine(item);
            }
            */
            /*
            HashSet<string> names1 = new HashSet<string>()
            {
                "Erik",
                "Harut",
                "Hovo",
                "Hovo",
                "Aram",
                "Erik",
                "Yuri"
            };
            HashSet<string> names2 = new HashSet<string>()
            {
                "Harut",
                "Hovo",
                "Hovo",
                "Aram",
                
            };
            names1.ExceptWith(names2);
            foreach(var item in names1)
            {
                Console.WriteLine(item);
            }
            */
            /*
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, 5);
            hashtable.Add(6, 6.3);
            hashtable.Add(3, "aaa");
            foreach(DictionaryEntry item in hashtable)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }
            */

            /*
            Hashtable studentsTable = new Hashtable();
            studentsTable.Add("Yuri", new Student(1,  90));
            studentsTable.Add("Harut", new Student(2,  80));
            studentsTable.Add("Vahag", new Student(3,  50));
            studentsTable.Add("Erik", new Student(4,  60));

            foreach(var item in studentsTable.Keys)
            {
                Console.WriteLine(item + "  " +  studentsTable[item]);
            }

            */

            /*
            //????????????
            Hashtable aaa = new Hashtable();
            aaa.Add(0, "Cpp");
            aaa.Add(1, "CSharp");
            aaa.Add(2, "Cpp");
            aaa.Add(3, "Java");
            aaa.Add(4, "Js");
            aaa.Add(5, "Python");
            foreach(int item in aaa.Keys)
            {
                Console.WriteLine($"{item}: {aaa[item]}");
            }
            for(int i = 0; i<aaa.Count; i++)
            {
                Console.WriteLine(aaa[i]);
            }
            */


            /*
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddFirst(0);
            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            linkedList.AddLast(4);
            linkedList.AddLast(5);
            linkedList.AddLast(6);
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            linkedList.Remove(4);
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            linkedList.RemoveFirst();
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            */
            /*
            StackUsingLinkedList obj = new StackUsingLinkedList();
            obj.push(5);
            obj.push(0);
            obj.push(-2);
            obj.push(1);
            obj.push(4);
            obj.push(7);
            obj.Display();
            Console.WriteLine();
            obj.pop();
            obj.Display();
            Console.WriteLine(obj.Peek());
            */


            //Queue queue = new Queue();
            //queue.Enqueue(5);
            //queue.Enqueue(1);
            //queue.Enqueue(1);
            //queue.Enqueue(0); 
            //queue.Enqueue(16);
            //queue.Enqueue(4);
            //foreach(var item in queue)
            //{
            //    Console.Write($"{item} <- ");
            //}
            //queue.Dequeue();
            //Console.WriteLine();
            //foreach(var item in queue)
            //{
            //    Console.Write($"{item} <- ");
            //}
            //



            /*
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, 'a');
            hashtable.Add(2, 'b');
            
                if (hashtable.Contains(3))
                {
                    Console.WriteLine("Hello world");
                }
                else
                {
                    Console.WriteLine("Hiiiii");
                }
            */

            /*
            HashSet<int> hashset = new HashSet<int>();
            hashset.Add(1);
            hashset.Add(2);
            hashset.Add(1);
            hashset.Add(6);
            hashset.Add(7);
            hashset.Add(1);
            hashset.Add(4);
            hashset.Add(6);
            HashSet<int> hashset2 = new HashSet<int>();
            hashset2.Add(1);
            hashset2.Add(2);
            hashset2.Add(1);
            hashset2.Add(6);
            hashset2.Add(7);
            hashset2.Add(1);
            hashset2.Add(6);
            hashset.ExceptWith(hashset2);
            //hashset.UnionWith(hashset2);

            foreach (var item in hashset)
            {
                Console.WriteLine(item);
            }
            */


            LinkedList<int> linkedlist = new LinkedList<int>();
            linkedlist.AddLast(1);
            linkedlist.AddLast(2);
            linkedlist.AddLast(3);
            linkedlist.AddLast(4);
            linkedlist.AddLast(5);
            linkedlist.AddLast(6);
            linkedlist.AddLast(7);
            foreach(var item in linkedlist)
            {
                Console.WriteLine(item);
            }

            SinglyLinkedList list = new SinglyLinkedList();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);
            list.AddLast(6);
            list.AddLast(7);
            list.Print();

        }
    }
}