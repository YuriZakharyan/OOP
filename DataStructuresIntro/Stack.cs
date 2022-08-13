using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresIntro
{
    class Stack //Stack implementation using Array
    {
        private int[] elements;
        private int top;
        private int max;
        public Stack(int size)
        {
            elements = new int[size];
            top = -1;
            max = size;
        }
        public void Push(int item)
        {
            if (top == max - 1)
            {
                Console.WriteLine("Stack Overflow");
            }
            else
            {
                top = top+1;
                elements[top] = item;
            }
        }
        public int Pop()
        {
            if(top == -1)
            {
                Console.WriteLine("Stack UnderFlow");
                return -1;
            }
            else
            {
                Console.WriteLine($"Poped element is: {elements[top]}");
                return elements[top--];
            }
        }
        public void PrintStack()
        {
            if(top == -1)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                foreach(var item in elements)
                {
                    Console.WriteLine(item);
                }
            }
        }



    }

}
