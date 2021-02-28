using System;
using System.Collections.Generic;
using System.Text;

namespace Linkedlist
{
   public class LinkedList
    {
        public Node head;
        public Node tail;
        public void Add(int data)
        {
            Node node = new Node(data);
            if(this.head  == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }
        public void AddNodeAtStart(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
               this.head = node;
            }
            else
            {
                node.next = head;
                head = node;
            }
            Console.WriteLine($"Added {data} at start of the linkedlist");
        }

        public void Display()
        {
            Node temp = head;
            if (this.head == null)
            {
                Console.WriteLine("Linked list is empty");
                
            }
            while(temp!=null)
            {
                Console.Write(temp.data + " ");
                if (temp.next != null)
                {
                    Console.Write("->");
                }
                temp = temp.next;
            }
            Console.WriteLine();
        }
        
       

    }
}
