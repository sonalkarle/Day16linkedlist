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
            list.Add(56);
            list.Add(30);
            list.Add(76);
            list.Display();
        }
    }
}
