using System;
using System.Collections.Generic;

namespace Linkedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to linked list");
            LinkedList list = new LinkedList();
            Console.WriteLine("Linked list Number as follows");
            list.AddNodeAtStart(70);
            list.AddNodeAtStart(30);
            list.AddNodeAtStart(56);
            list.Display();
           
        }
    }
}
