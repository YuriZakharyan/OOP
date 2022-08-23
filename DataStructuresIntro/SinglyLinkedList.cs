using System;

namespace DataStructuresIntro
{
    public class Nodee
    {
        public int data;
        public Nodee next;
        public Nodee()
        {
        }
        public Nodee(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
    class SinglyLinkedList
    {
        Nodee head;
        public Nodee GetHeadNode()
        {
            return head;
        }
        public SinglyLinkedList()
        {
        }
        public void Add(int data, int pos)
        {
            if (head != null)
            {
                Nodee temp = head;
                Nodee current = null;
                Nodee next = null;

                for (int i = 0; i < pos - 2; i++)
                {
                    temp = temp.next;
                }
                current = temp;
                next = temp.next;

                Nodee newNode = new Nodee(data);
                temp.next = newNode;
                newNode.next = next;
            }
        }
        public void AddFirst(int data)
        {
            Nodee newNode = new Nodee(data);
            newNode.next = head;
            head = newNode;
        }
        public void AddLast(int data)
        {
            Nodee newNode = new Nodee(data);
            Nodee temp = head;
            if (head == null)
            {
                head = new Nodee();
                head.next = newNode;
                head = newNode;
            }
            else
            {
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
        }
        public void Print()
        {
            Nodee temp = head;
            while(temp.next != null)
            {
                Console.Write($"{temp.data} -> ");
                temp = temp.next;
            }
            Console.WriteLine();
        }

    }
}
