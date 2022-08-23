using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresIntro
{
    public class LinkedListNode
    {
        public int data;
        public LinkedListNode next;

        public LinkedListNode(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
    public class QueueUsingLinkedList
    {
        LinkedListNode rear;
        LinkedListNode front;
        public QueueUsingLinkedList()
        {
            rear = null;
            front = null;
        }
        public LinkedListNode GetNode(int data)
        {
            LinkedListNode newNode = new LinkedListNode(data);
            return newNode;
        }
        public void Enqueue(int data)
        {
            LinkedListNode newNode = GetNode(data);
            if(front == null)
            {
                front = rear = newNode;
            }
            front.next = newNode;
            rear = newNode;
        }
        public int Dequeue()
        {
            int p = -1;
            if(front != null)
            {
                p = front.data;
                front = front.next;
            }
            return p;
        }
        public int Peek()
        {
            if(front != null)
            {
                return front.data;
            }
            return -1;
        }
        public bool isEmpty()
        {
            return front == null;
        }


    }
}
