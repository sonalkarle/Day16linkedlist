using System;
using System.Collections.Generic;

namespace Linkedlist
{
    class Program
    {
        static void Main(string[] args)
        {

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
            ///UC3: Append linked list
            ///</summary>
            Console.WriteLine("Append the list");
            LinkedList newlist1 = new LinkedList();
            newlist1.Append(56);
            newlist1.Append(70);
            newlist1.Append(30);
            newlist1.Display();



            ///<summary>
            ///UC4: Add Node between First and last node
            ///</summary>
            Console.WriteLine("Add Node In Between first and last node ");
            LinkedList newlist = new LinkedList();
            newlist.Append(56);
            newlist.Append(70);
            newlist.AddNodeAfterNode(30, 56);
            newlist.Display();



            ///<summary>
            ///UC5: Delete the first node
            ///</summary>

            Console.WriteLine("Delete First Node");
            list.Display();
            list.DeleteNodeAtFirst();
            list.Display();

            ///<summary>
            ///UC6: Delete the last Node
            /// </summary>
            Console.WriteLine("Delete Last Node ");
            list.Display();
            list.DeleteNodeAtLast();
            list.Display();



            ///<summary>
            ///UC7: Search number from the Node
            /// </summary>
            Console.WriteLine("Static Linked List:");
            LinkedList staticlinkedList = new LinkedList();
            Node node56 = new Node(56);
            Node node30 = new Node(30);
            Node node70 = new Node(70);
            node56.next = node30;
            node30.next = node70;
            staticlinkedList.head = node56;
            staticlinkedList.Display();
            Console.WriteLine("Search for Node 30");
            staticlinkedList.Display();
            if (staticlinkedList.Search(30))
            {
                Console.WriteLine("Node found");

            }
            ///<summary>
            ///UC8: Add node 40 after 30 and display the details
            /// </summary>
            Console.WriteLine("Add Node After Node ");
            LinkedList linkedListAfterNode = new LinkedList();
            linkedListAfterNode.Append(56);
            linkedListAfterNode.Append(30);
            linkedListAfterNode.Append(70);
            linkedListAfterNode.AddNodeAfterNode(40, 30);
            linkedListAfterNode.Display();




        }
    }
}
