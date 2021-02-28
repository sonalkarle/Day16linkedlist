using System;
using System.Collections.Generic;
using System.Text;

namespace Linkedlist
{
   public class LinkedList
    {
        public Node head;
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
        public void Display()
        {
            Node temp = head;
            if (this.head == null)
            {
                Console.WriteLine("Linked list is empty");
                
            }
            while(temp!=null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
