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
        public bool Search(int x)
        {
            Nodee temp = head;
            while(temp != null)
            {
                if(temp.data == x)
                {
                    return true;
                }
                temp = temp.next;
            }
            return false;
        }
        public void Print()
        {
            Nodee temp = head;
            while (temp != null)
            {
                Console.Write($"{temp.data} -> ");
                temp = temp.next;
            }
            Console.WriteLine();
        }

        public void DeleteAt(int pos)
        {
            if (pos < 1)
            {
                Console.Write("\nPosition should be >= 1.");
            }
            else if (pos == 1 && head != null)
            {
                Nodee nodeToDelete = head;
                head = head.next;
                nodeToDelete = null;
            }
            else
            {
                Nodee temp = new Nodee();
                temp = head;
                for (int i = 1; i < pos - 1; i++)
                {
                    if (temp != null)
                    {
                        temp = temp.next;
                    }

                }
                if (temp != null && temp.next != null)
                {
                    Nodee nodeToDelete = temp.next;
                    temp.next = temp.next.next;
                    nodeToDelete = null;
                }
                else
                {

                    //5. Else the given node will be empty.
                    Console.Write("\nThe node is already null.");
                }
            }
        }
    }
}
