using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresIntro
{
    class Node
    {
        public int data;
        public Node next;
    }
    class StackUsingLinkedList
    {
        Node top;

        public StackUsingLinkedList()
        {
            this.top = null;
        }
        public void push(int x)
        {
            Node temp = new Node();
            if (temp == null)
            {
                Console.WriteLine("Heap Overflow");
                return;
            }
            temp.data = x;
            temp.next = top;
            top = temp;
        }
        public bool isEmpty()
        {
            return top == null;
        }

        public int Peek()
        {
            if (!isEmpty())
            {
                return top.data;
            }
            else
            {
                Console.WriteLine("Is Empty");
                return -1;
            }
        }
        public void pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack Is Empty");
                return;
            }
            else
            {
                top = (top).next;
            }
        }
        public void Display()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Node temp = top;
                while(temp != null)
                {
                    Console.Write($"{temp.data} -> ");
                    temp = temp.next;
                }
            }
        }
    }
}