using System;
using System.Collections.Generic;

namespace Linkedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to linked list");

            ///<summary>
            ///UC1: Create simple linked list
            ///UC3: Append details in list 
            ///</summary>
            Console.WriteLine("Welcome to linked list");
            LinkedList list = new LinkedList();
            Node node1 = new Node(56);
            Node node2 = new Node(30);
            Node node3 = new Node(70);
            list.AddNode(node1);
            list.AddNode(node2);
            list.AddNode(node3);
            list.Display();

            ///<summary>
            ///UC2: Create linked list add the data from start
            ///</summay>

            list.AddNodeAtStart(70);
            list.AddNodeAtStart(30);
            list.AddNodeAtStart(56);
            list.Display();

            ///<summary>
            ///UC4: Add Node between First and last node
            ///</summary>
            Console.WriteLine("Add Node In Between first and last node ");
            LinkedList newlist = new LinkedList();
            newlist.Append(56);
            newlist.Append(70);
            newlist.AddNodeAfterNode(30, 56);
            newlist.Display();

        }
    }
}
